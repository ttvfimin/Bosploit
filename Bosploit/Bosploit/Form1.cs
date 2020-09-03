using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Bosploit
{
    public partial class Form1 : Form
    {
        string fileContent = "-- Hey there!\n-- Thanks for downloading Bosploit! Before you start exploiting,\n-- please remember that this program is currently in it's development\n-- phases. Some items may not be complete, some may be useless\n-- and some may be buggy. If you notice anything, be sure to\n-- report it to the project's github repository (account below)\n\n-- Remember to always inject as soon as you run Bosploit!\n\n-- Socials and contact!\n\n-- Email: kcliix@cyberservices.com\n-- Instagram: @2._.5.14\n-- Instagram: @b._vvvvvvv\n-- Twitter: @2_5_14_\n-- Reddit: /u/_fimin\n-- Github: ttvfimin\n\n-- Example program, does not actually cause anything to happen in game.\n\na = '1'\nb = '2'\n\nprint(a)\nprint(b)";
        readonly ExploitAPI api = new ExploitAPI();
        public Form1()
        {
            InitializeComponent();
            fastColoredTextBox1.Text = fileContent;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
            logLabel.Text += "\n(Attempted to) Injected WRD API";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLimitedLuaScript(script);
            logLabel.Text += "\nSent Limited Lua Script";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLuaScript(script);
            logLabel.Text += "\nSent Lua Script";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChoose = new OpenFileDialog();
            fileChoose.Filter = "Text Files (*.txt)|*.txt";
            fileChoose.FilterIndex = 1;
            fileChoose.Multiselect = false;

            if (fileChoose.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = fileChoose.FileName;

                string fileContent = File.ReadAllText(selectedFile);
                try
                {
                    fastColoredTextBox1.Text = fileContent;
                }
                catch(Exception error)
                {
                    fastColoredTextBox1.Text = "-- An error occured trying to load your file.";
                    fastColoredTextBox1.Text += "--" + error;
                    fastColoredTextBox1.Text = "-- Please contact the developer with the above error via github!\n-- Github: ttvfimin";
                }
            }

            logLabel.Text += "\n(Attempted to) Opened file.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logLabel.Text += "\nStarted Bosploit";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(logLabel.Visible == false)
            {
                logLabel.Visible = true;
            }
            else
            {
                logLabel.Visible = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            logLabel.Text = "Log";
        }
    }
}
