using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KeyboardMe
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteKey(textBox2.Text, enter1.Text);
        }
        void WriteKey(string str,string softtext)
        {
            IntPtr soft = FindWindow(null, softtext);
            if (soft != IntPtr.Zero)
            {
                SetForegroundWindow(soft);
                SendKeys.Send(str);
                SendKeys.Send("{ENTER}"); // Simulate pressing the Enter key

            }
            else
            {
                // Handle case where window is not found
            }
        }

        private void SoftwareTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteKey(textBox2.Text, SoftwareTxt.Text);

        }
    }
}
