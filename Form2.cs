using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rateBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you like this application?";
            string caption = "Rate this app!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\valyb\source\repos\MediaProject\MediaProject\Resurse\like.png");
            }
            else if (result == DialogResult.No)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\valyb\source\repos\MediaProject\MediaProject\Resurse\hate.jpg");
            }
            else if (result == DialogResult.Cancel)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
