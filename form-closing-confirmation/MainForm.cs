
using System.Diagnostics;

namespace form_closing_confirmation
{
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
}
