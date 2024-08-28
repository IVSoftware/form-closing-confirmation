namespace form_closing_confirmation
{
    partial class ChildFormB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonExit = new Button();
            buttonClose = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(317, 161);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(111, 34);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(317, 121);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(111, 34);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 166);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 1;
            label1.Text = "Optional Exit from Child Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 126);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Hide this form";
            // 
            // ChildFormA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            Controls.Add(buttonExit);
            Name = "ChildFormA";
            Text = "Child Form A";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label2;
        private Label label1;
        private Button buttonClose;
        private Button buttonExit;
    }
}