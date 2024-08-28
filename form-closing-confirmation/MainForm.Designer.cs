namespace form_closing_confirmation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonShowFormA = new Button();
            buttonShowFormB = new Button();
            SuspendLayout();
            // 
            // buttonShowFormA
            // 
            buttonShowFormA.Location = new Point(46, 110);
            buttonShowFormA.Name = "buttonShowFormA";
            buttonShowFormA.Size = new Size(112, 34);
            buttonShowFormA.TabIndex = 0;
            buttonShowFormA.Text = "Form A";
            buttonShowFormA.UseVisualStyleBackColor = true;
            // 
            // buttonShowFormB
            // 
            buttonShowFormB.Location = new Point(191, 110);
            buttonShowFormB.Name = "buttonShowFormB";
            buttonShowFormB.Size = new Size(112, 34);
            buttonShowFormB.TabIndex = 1;
            buttonShowFormB.Text = "Form B";
            buttonShowFormB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(buttonShowFormB);
            Controls.Add(buttonShowFormA);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonShowFormA;
        private Button buttonShowFormB;
    }
}
