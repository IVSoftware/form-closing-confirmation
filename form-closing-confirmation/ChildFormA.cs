using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_closing_confirmation
{
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
}
