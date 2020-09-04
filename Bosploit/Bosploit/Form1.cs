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
        public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

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
            string injectStatus = "false";
            if(api.isAPIAttached())
            {
                button3.Visible = false;
                if(api.isAPIAttached())
                {
                    injectStatus = "true";
                }
                label3.Text = "Is injected: "+ injectStatus;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLimitedLuaScript(script);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLuaScript(script);
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string exploit = fastColoredTextBox1.Text;
            api.SendLuaCScript(exploit);
        }

        private void killBtn_Click(object sender, EventArgs e)
        {
            string command = "kill me";
            api.SendCommand(command);
        }

        private void floatBtn_Click(object sender, EventArgs e)
        {
            string command = "float me";
            api.SendCommand(command);
        }

        private void nofloatBtn_Click(object sender, EventArgs e)
        {
            string command = "nofloat me";
            api.SendCommand(command);
        }

        private void hiphieghtBtn_Click(object sender, EventArgs e)
        {
            string command = "hipheight me 100";
            api.SendCommand(command);
        }

        private void espBtn_Click(object sender, EventArgs e)
        {
            string command = "boxesp";
            api.SendCommand(command);
        }

        private void ffBtn_Click(object sender, EventArgs e)
        {
            string command = "ff me";
            api.SendCommand(command);
        }

        private void noffBtn_Click(object sender, EventArgs e)
        {
            string command = "noff me";
            api.SendCommand(command);
        }

        private void blockheadBtn_Click(object sender, EventArgs e)
        {
            string user = richTextBox1.Text;
            if (user == "") { user = "me"; }
            string command = "blockhead " + user;
            api.SendCommand(command);
        }

        private void nolimbsBtn_Click(object sender, EventArgs e)
        {
            string user = richTextBox1.Text;
            if (user == "") { user = "me"; }
            string command = "nolimbs " + user;
            api.SendCommand(command);
        }

        private void noarmsBtn_Click(object sender, EventArgs e)
        {
            string user = richTextBox1.Text;
            if (user == "") { user = "me"; }
            string command = "noarms " + user;
            api.SendCommand(command);
        }

        private void nolegsBtn_Click(object sender, EventArgs e)
        {
            string user = richTextBox1.Text;
            if (user == "") { user = "me"; }
            string command = "nolegs " + user;
            api.SendCommand(command);
        }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            string command = "fire me";
            api.SendCommand(command);
        }

        private void nofireBtn_Click(object sender, EventArgs e)
        {
            string command = "nofire me";
            api.SendCommand(command);
        }

        private void sparklesBtn_Click(object sender, EventArgs e)
        {
            string command = "sparkles me";
            api.SendCommand(command);
        }

        private void nosparklesBtn_Click(object sender, EventArgs e)
        {
            string command = "nosparkles me";
            api.SendCommand(command);
        }

        private void btoolsBtn_Click(object sender, EventArgs e)
        {
            string command = "btools me";
            api.SendCommand(command);
        }

        private void smokeBtn_Click(object sender, EventArgs e)
        {
            string command = "smoke me";
            api.SendCommand(command);
        }

        private void nosmokeBtn_Click(object sender, EventArgs e)
        {
            string command = "nosmoke me";
            api.SendCommand(command);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }
    }
}
