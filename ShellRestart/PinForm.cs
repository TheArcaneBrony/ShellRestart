using System;
using System.IO;
using System.Windows.Forms;

namespace ShellRestart
{
    public partial class PinForm : Form
    {
        public PinForm()
        {
            InitializeComponent();
            File.Create(".nopin").Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}