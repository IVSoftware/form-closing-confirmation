Reading your code and bullet items carefully, my understanding is that you have a main form for the app and have "multiple forms" that can be shown concurrently and non-modally, whose visibility can come and go as the user sees fit. A general case minimal example might look like this:

[![multiple forms][1]][1]

___

So you could experiment with simplifying `MainForm.OnFormClosing()` which will be invoked by "any" `Application.Exit` call from anywhere in the code. There shouldn't be any need to check the `CloseReason` here, and by passing `this` in the `Show(this)` it ensures that the child forms stay on top of the main form in the Z-Order and dispose when `MainForm` does (as the debug writes will attest). To put a finer point on it, there's no need to call `ApplicationExit()` here because if it's the main form that's closing and the prompt doesn't cancel it, then the app _will exit_. 

```csharp
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();            
        buttonShowFormA.Click += (sender, e) => _formA.Show(this);
        buttonShowFormB.Click += (sender, e) => _formB.Show(this);
        _formA.VisibleChanged += (sender, e) => buttonShowFormA.Enabled = !_formA.Visible;
        _formB.VisibleChanged += (sender, e) => buttonShowFormB.Enabled = !_formB.Visible;
#if DEBUG
        _formA.Disposed += (sender, e) => Debug.WriteLine("Disposing Form A");
        _formB.Disposed += (sender, e) => Debug.WriteLine("Disposing Form B");
#endif
    }
    ChildFormA _formA = new() { StartPosition = FormStartPosition.Manual };
    ChildFormB _formB = new () { StartPosition = FormStartPosition.Manual };
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _formA.Location = new() { X = Right + 10, Y = Top };
        _formB.Location = new() { X = Right + 10, Y = Top + _formA.Height + 10 };
        _formA.Show(this);
        _formB.Show(this);
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.No)
        {
            e.Cancel = true; // Cancel the form closing
            return;
        }
    }
}
```

___

The `CloseReason` _is_ important in the child forms, as we need to change the `Form` behavior where by default the window `Handle` disposes when the form is closed, (which is a big problem when being able to cycle the child form visibility repeatedly is desired).

A common way of dealing with this is to cancel the `Close` and convert it to `Hide` the form instead, only allowing the `Close` to proceed is the `CloseReason` is application exit or some other system-related shutdown.

```
public partial class ChildFormA : Form
{
    public ChildFormA()
    {
        InitializeComponent();
        buttonClose.Click += (sender, e) => Close();
        buttonExit.Click += (sender, e) => Application.Exit();
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        switch (e.CloseReason)
        {
            case CloseReason.UserClosing:
                e.Cancel = true;
                Hide();
                break;
        }
    }
}
```

This basic example should hopefully touch on most of the points in your question. Setting the `this` pointer when you show other forms will go a long way toward windows behaving the way that you'd expect.

  [1]: https://i.sstatic.net/bImskzUr.png