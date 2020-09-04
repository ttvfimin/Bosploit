namespace Bosploit
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.killBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ffBtn = new System.Windows.Forms.Button();
            this.espBtn = new System.Windows.Forms.Button();
            this.hiphieghtBtn = new System.Windows.Forms.Button();
            this.nofloatBtn = new System.Windows.Forms.Button();
            this.floatBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.blockheadBtn = new System.Windows.Forms.Button();
            this.nolimbsBtn = new System.Windows.Forms.Button();
            this.noarmsBtn = new System.Windows.Forms.Button();
            this.nolegsBtn = new System.Windows.Forms.Button();
            this.fireBtn = new System.Windows.Forms.Button();
            this.noffBtn = new System.Windows.Forms.Button();
            this.sparklesBtn = new System.Windows.Forms.Button();
            this.nosparklesBtn = new System.Windows.Forms.Button();
            this.btoolsBtn = new System.Windows.Forms.Button();
            this.smokeBtn = new System.Windows.Forms.Button();
            this.nosmokeBtn = new System.Windows.Forms.Button();
            this.nofireBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bosploit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by ttvfimin.";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(12, 61);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(890, 421);
            this.fastColoredTextBox1.TabIndex = 2;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1009, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 15);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(927, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 15);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(151, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Inject";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(730, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 43);
            this.button4.TabIndex = 6;
            this.button4.Text = "Execute (Limited Lua)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(598, 489);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 42);
            this.button5.TabIndex = 7;
            this.button5.Text = "Execute (Lua)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(14, 489);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "Open from file";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lime;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(831, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 44);
            this.button9.TabIndex = 12;
            this.button9.Text = "Top";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(460, 488);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 42);
            this.button10.TabIndex = 13;
            this.button10.Text = "Execute (Lua C)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(25)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(909, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 808);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(25)))), ((int)(((byte)(10)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 808);
            this.panel2.TabIndex = 15;
            // 
            // killBtn
            // 
            this.killBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killBtn.Location = new System.Drawing.Point(14, 650);
            this.killBtn.Name = "killBtn";
            this.killBtn.Size = new System.Drawing.Size(118, 42);
            this.killBtn.TabIndex = 15;
            this.killBtn.Text = "Kill (S)";
            this.killBtn.UseVisualStyleBackColor = true;
            this.killBtn.Click += new System.EventHandler(this.killBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(25)))), ((int)(((byte)(10)))));
            this.panel4.Location = new System.Drawing.Point(-19, 538);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(937, 10);
            this.panel4.TabIndex = 16;
            // 
            // ffBtn
            // 
            this.ffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffBtn.Location = new System.Drawing.Point(766, 554);
            this.ffBtn.Name = "ffBtn";
            this.ffBtn.Size = new System.Drawing.Size(118, 42);
            this.ffBtn.TabIndex = 18;
            this.ffBtn.Text = "FF (S)";
            this.ffBtn.UseVisualStyleBackColor = true;
            this.ffBtn.Click += new System.EventHandler(this.ffBtn_Click);
            // 
            // espBtn
            // 
            this.espBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espBtn.Location = new System.Drawing.Point(642, 554);
            this.espBtn.Name = "espBtn";
            this.espBtn.Size = new System.Drawing.Size(118, 42);
            this.espBtn.TabIndex = 19;
            this.espBtn.Text = "Box ESP (S)";
            this.espBtn.UseVisualStyleBackColor = true;
            this.espBtn.Click += new System.EventHandler(this.espBtn_Click);
            // 
            // hiphieghtBtn
            // 
            this.hiphieghtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiphieghtBtn.Location = new System.Drawing.Point(108, 602);
            this.hiphieghtBtn.Name = "hiphieghtBtn";
            this.hiphieghtBtn.Size = new System.Drawing.Size(148, 42);
            this.hiphieghtBtn.TabIndex = 20;
            this.hiphieghtBtn.Text = "Hipheight 100 (S)";
            this.hiphieghtBtn.UseVisualStyleBackColor = true;
            this.hiphieghtBtn.Click += new System.EventHandler(this.hiphieghtBtn_Click);
            // 
            // nofloatBtn
            // 
            this.nofloatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nofloatBtn.Location = new System.Drawing.Point(394, 554);
            this.nofloatBtn.Name = "nofloatBtn";
            this.nofloatBtn.Size = new System.Drawing.Size(118, 42);
            this.nofloatBtn.TabIndex = 21;
            this.nofloatBtn.Text = "Nofloat (S)";
            this.nofloatBtn.UseVisualStyleBackColor = true;
            this.nofloatBtn.Click += new System.EventHandler(this.nofloatBtn_Click);
            // 
            // floatBtn
            // 
            this.floatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatBtn.Location = new System.Drawing.Point(262, 554);
            this.floatBtn.Name = "floatBtn";
            this.floatBtn.Size = new System.Drawing.Size(118, 42);
            this.floatBtn.TabIndex = 22;
            this.floatBtn.Text = "Float (S)";
            this.floatBtn.UseVisualStyleBackColor = true;
            this.floatBtn.Click += new System.EventHandler(this.floatBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Is injected: false";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(495, 716);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 22);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 713);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "User to effect (full user name, blank for self): ";
            // 
            // blockheadBtn
            // 
            this.blockheadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockheadBtn.Location = new System.Drawing.Point(262, 602);
            this.blockheadBtn.Name = "blockheadBtn";
            this.blockheadBtn.Size = new System.Drawing.Size(118, 42);
            this.blockheadBtn.TabIndex = 31;
            this.blockheadBtn.Text = "Blockhead";
            this.blockheadBtn.UseVisualStyleBackColor = true;
            this.blockheadBtn.Click += new System.EventHandler(this.blockheadBtn_Click);
            // 
            // nolimbsBtn
            // 
            this.nolimbsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nolimbsBtn.Location = new System.Drawing.Point(394, 602);
            this.nolimbsBtn.Name = "nolimbsBtn";
            this.nolimbsBtn.Size = new System.Drawing.Size(118, 42);
            this.nolimbsBtn.TabIndex = 30;
            this.nolimbsBtn.Text = "Nolimbs";
            this.nolimbsBtn.UseVisualStyleBackColor = true;
            this.nolimbsBtn.Click += new System.EventHandler(this.nolimbsBtn_Click);
            // 
            // noarmsBtn
            // 
            this.noarmsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noarmsBtn.Location = new System.Drawing.Point(518, 602);
            this.noarmsBtn.Name = "noarmsBtn";
            this.noarmsBtn.Size = new System.Drawing.Size(118, 42);
            this.noarmsBtn.TabIndex = 29;
            this.noarmsBtn.Text = "Noarms";
            this.noarmsBtn.UseVisualStyleBackColor = true;
            this.noarmsBtn.Click += new System.EventHandler(this.noarmsBtn_Click);
            // 
            // nolegsBtn
            // 
            this.nolegsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nolegsBtn.Location = new System.Drawing.Point(642, 602);
            this.nolegsBtn.Name = "nolegsBtn";
            this.nolegsBtn.Size = new System.Drawing.Size(118, 42);
            this.nolegsBtn.TabIndex = 28;
            this.nolegsBtn.Text = "Nolegs";
            this.nolegsBtn.UseVisualStyleBackColor = true;
            this.nolegsBtn.Click += new System.EventHandler(this.nolegsBtn_Click);
            // 
            // fireBtn
            // 
            this.fireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireBtn.Location = new System.Drawing.Point(766, 602);
            this.fireBtn.Name = "fireBtn";
            this.fireBtn.Size = new System.Drawing.Size(118, 42);
            this.fireBtn.TabIndex = 27;
            this.fireBtn.Text = "Fire (S)";
            this.fireBtn.UseVisualStyleBackColor = true;
            this.fireBtn.Click += new System.EventHandler(this.fireBtn_Click);
            // 
            // noffBtn
            // 
            this.noffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noffBtn.Location = new System.Drawing.Point(518, 554);
            this.noffBtn.Name = "noffBtn";
            this.noffBtn.Size = new System.Drawing.Size(118, 42);
            this.noffBtn.TabIndex = 26;
            this.noffBtn.Text = "NoFF (S)";
            this.noffBtn.UseVisualStyleBackColor = true;
            this.noffBtn.Click += new System.EventHandler(this.noffBtn_Click);
            // 
            // sparklesBtn
            // 
            this.sparklesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sparklesBtn.Location = new System.Drawing.Point(262, 650);
            this.sparklesBtn.Name = "sparklesBtn";
            this.sparklesBtn.Size = new System.Drawing.Size(118, 42);
            this.sparklesBtn.TabIndex = 37;
            this.sparklesBtn.Text = "Sparkles (S)";
            this.sparklesBtn.UseVisualStyleBackColor = true;
            this.sparklesBtn.Click += new System.EventHandler(this.sparklesBtn_Click);
            // 
            // nosparklesBtn
            // 
            this.nosparklesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosparklesBtn.Location = new System.Drawing.Point(386, 650);
            this.nosparklesBtn.Name = "nosparklesBtn";
            this.nosparklesBtn.Size = new System.Drawing.Size(126, 42);
            this.nosparklesBtn.TabIndex = 36;
            this.nosparklesBtn.Text = "Nosparkles (S)";
            this.nosparklesBtn.UseVisualStyleBackColor = true;
            this.nosparklesBtn.Click += new System.EventHandler(this.nosparklesBtn_Click);
            // 
            // btoolsBtn
            // 
            this.btoolsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoolsBtn.Location = new System.Drawing.Point(518, 650);
            this.btoolsBtn.Name = "btoolsBtn";
            this.btoolsBtn.Size = new System.Drawing.Size(118, 42);
            this.btoolsBtn.TabIndex = 35;
            this.btoolsBtn.Text = "Btools (S)";
            this.btoolsBtn.UseVisualStyleBackColor = true;
            this.btoolsBtn.Click += new System.EventHandler(this.btoolsBtn_Click);
            // 
            // smokeBtn
            // 
            this.smokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smokeBtn.Location = new System.Drawing.Point(642, 650);
            this.smokeBtn.Name = "smokeBtn";
            this.smokeBtn.Size = new System.Drawing.Size(118, 42);
            this.smokeBtn.TabIndex = 34;
            this.smokeBtn.Text = "Smoke (S)";
            this.smokeBtn.UseVisualStyleBackColor = true;
            this.smokeBtn.Click += new System.EventHandler(this.smokeBtn_Click);
            // 
            // nosmokeBtn
            // 
            this.nosmokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosmokeBtn.Location = new System.Drawing.Point(766, 650);
            this.nosmokeBtn.Name = "nosmokeBtn";
            this.nosmokeBtn.Size = new System.Drawing.Size(118, 42);
            this.nosmokeBtn.TabIndex = 33;
            this.nosmokeBtn.Text = "Nosmoke (S)";
            this.nosmokeBtn.UseVisualStyleBackColor = true;
            this.nosmokeBtn.Click += new System.EventHandler(this.nosmokeBtn_Click);
            // 
            // nofireBtn
            // 
            this.nofireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nofireBtn.Location = new System.Drawing.Point(138, 650);
            this.nofireBtn.Name = "nofireBtn";
            this.nofireBtn.Size = new System.Drawing.Size(118, 42);
            this.nofireBtn.TabIndex = 32;
            this.nofireBtn.Text = "Nofire (S)";
            this.nofireBtn.UseVisualStyleBackColor = true;
            this.nofireBtn.Click += new System.EventHandler(this.nofireBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 33);
            this.label5.TabIndex = 38;
            this.label5.Text = "S MEANS SELF";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(927, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 663);
            this.listBox1.TabIndex = 39;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(925, 698);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 39);
            this.button7.TabIndex = 40;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1074, 741);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sparklesBtn);
            this.Controls.Add(this.nosparklesBtn);
            this.Controls.Add(this.btoolsBtn);
            this.Controls.Add(this.smokeBtn);
            this.Controls.Add(this.nosmokeBtn);
            this.Controls.Add(this.nofireBtn);
            this.Controls.Add(this.blockheadBtn);
            this.Controls.Add(this.nolimbsBtn);
            this.Controls.Add(this.noarmsBtn);
            this.Controls.Add(this.nolegsBtn);
            this.Controls.Add(this.fireBtn);
            this.Controls.Add(this.noffBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floatBtn);
            this.Controls.Add(this.nofloatBtn);
            this.Controls.Add(this.hiphieghtBtn);
            this.Controls.Add(this.espBtn);
            this.Controls.Add(this.ffBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.killBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button killBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ffBtn;
        private System.Windows.Forms.Button espBtn;
        private System.Windows.Forms.Button hiphieghtBtn;
        private System.Windows.Forms.Button nofloatBtn;
        private System.Windows.Forms.Button floatBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button blockheadBtn;
        private System.Windows.Forms.Button nolimbsBtn;
        private System.Windows.Forms.Button noarmsBtn;
        private System.Windows.Forms.Button nolegsBtn;
        private System.Windows.Forms.Button fireBtn;
        private System.Windows.Forms.Button noffBtn;
        private System.Windows.Forms.Button sparklesBtn;
        private System.Windows.Forms.Button nosparklesBtn;
        private System.Windows.Forms.Button btoolsBtn;
        private System.Windows.Forms.Button smokeBtn;
        private System.Windows.Forms.Button nosmokeBtn;
        private System.Windows.Forms.Button nofireBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
    }
}

