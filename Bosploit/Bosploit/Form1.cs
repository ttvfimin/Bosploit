using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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
                string selctedFile = fileChoose.FileName;

                var fileStream = fileChoose.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string fileContent = reader.ReadToEnd();
                }
                try
                {
                    fastColoredTextBox1.Text = fileContent;
                }
                catch(Exception error)
                {
                    Console.WriteLine(error);
                }
            }
        }
    }
}
