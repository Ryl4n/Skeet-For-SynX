namespace WindowsFormsApp6
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skeetBackground1 = new SkeetFramework.SkeetBackground();
            this.label1 = new System.Windows.Forms.Label();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.skeetButton3 = new SkeetFramework.SkeetButton();
            this.skeetGroupBox1 = new SkeetFramework.SkeetGroupBox();
            this.skeetToggle2 = new SkeetFramework.SkeetToggle();
            this.skeetToggle1 = new SkeetFramework.SkeetToggle();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.skeetButton5 = new SkeetFramework.SkeetButton();
            this.skeetButton4 = new SkeetFramework.SkeetButton();
            this.skeetButton2 = new SkeetFramework.SkeetButton();
            this.skeetButton1 = new SkeetFramework.SkeetButton();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.skeetTextBox1 = new SkeetFramework.SkeetTextBox();
            this.skeetBackground1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.skeetGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skeetBackground1
            // 
            this.skeetBackground1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetBackground1.Controls.Add(this.label1);
            this.skeetBackground1.Controls.Add(this.fastColoredTextBox1);
            this.skeetBackground1.Controls.Add(this.webBrowser1);
            this.skeetBackground1.Controls.Add(this.skeetButton3);
            this.skeetBackground1.Controls.Add(this.skeetGroupBox1);
            this.skeetBackground1.Controls.Add(this.skeetButton5);
            this.skeetBackground1.Controls.Add(this.skeetButton4);
            this.skeetBackground1.Controls.Add(this.skeetButton2);
            this.skeetBackground1.Controls.Add(this.skeetButton1);
            this.skeetBackground1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skeetBackground1.Location = new System.Drawing.Point(0, 0);
            this.skeetBackground1.Name = "skeetBackground1";
            this.skeetBackground1.Size = new System.Drawing.Size(653, 341);
            this.skeetBackground1.TabIndex = 0;
            this.skeetBackground1.Text = "pp poop";
            this.skeetBackground1.Click += new System.EventHandler(this.skeetBackground1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = " loading";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(95, 12);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 12;
            this.fastColoredTextBox1.CharWidth = 7;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.FoldingIndicatorColor = System.Drawing.Color.Aqua;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(13, 19);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(509, 281);
            this.fastColoredTextBox1.TabIndex = 9;
            this.fastColoredTextBox1.Text = "-- Skeet X";
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(509, 281);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // skeetButton3
            // 
            this.skeetButton3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.skeetButton3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skeetButton3.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetButton3.Location = new System.Drawing.Point(528, 306);
            this.skeetButton3.Name = "skeetButton3";
            this.skeetButton3.Size = new System.Drawing.Size(113, 23);
            this.skeetButton3.TabIndex = 7;
            this.skeetButton3.Text = "close";
            this.skeetButton3.Click += new System.EventHandler(this.skeetButton3_Click_1);
            // 
            // skeetGroupBox1
            // 
            this.skeetGroupBox1.Controls.Add(this.skeetTextBox1);
            this.skeetGroupBox1.Controls.Add(this.skeetToggle2);
            this.skeetGroupBox1.Controls.Add(this.skeetToggle1);
            this.skeetGroupBox1.Controls.Add(this.listBox1);
            this.skeetGroupBox1.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetGroupBox1.Location = new System.Drawing.Point(528, 19);
            this.skeetGroupBox1.Name = "skeetGroupBox1";
            this.skeetGroupBox1.Size = new System.Drawing.Size(113, 281);
            this.skeetGroupBox1.TabIndex = 5;
            this.skeetGroupBox1.TabStop = false;
            this.skeetGroupBox1.Text = "scripts/settings";
            this.skeetGroupBox1.Enter += new System.EventHandler(this.skeetGroupBox1_Enter);
            // 
            // skeetToggle2
            // 
            this.skeetToggle2.BackColor = System.Drawing.Color.Transparent;
            this.skeetToggle2.Checked = false;
            this.skeetToggle2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.skeetToggle2.ColorBottom1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.skeetToggle2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.skeetToggle2.ColorTop1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.skeetToggle2.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetToggle2.Location = new System.Drawing.Point(6, 245);
            this.skeetToggle2.Name = "skeetToggle2";
            this.skeetToggle2.Size = new System.Drawing.Size(86, 12);
            this.skeetToggle2.TabIndex = 12;
            this.skeetToggle2.Text = "Watermark";
            this.skeetToggle2.CheckedChanged += new SkeetFramework.SkeetToggle.CheckedChangedEventHandler(this.skeetToggle2_CheckedChanged);
            // 
            // skeetToggle1
            // 
            this.skeetToggle1.BackColor = System.Drawing.Color.Transparent;
            this.skeetToggle1.Checked = false;
            this.skeetToggle1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.skeetToggle1.ColorBottom1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.skeetToggle1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.skeetToggle1.ColorTop1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.skeetToggle1.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetToggle1.Location = new System.Drawing.Point(6, 263);
            this.skeetToggle1.Name = "skeetToggle1";
            this.skeetToggle1.Size = new System.Drawing.Size(69, 12);
            this.skeetToggle1.TabIndex = 11;
            this.skeetToggle1.Text = "Topmost";
            this.skeetToggle1.CheckedChanged += new SkeetFramework.SkeetToggle.CheckedChangedEventHandler(this.skeetToggle1_CheckedChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "hi"});
            this.listBox1.Location = new System.Drawing.Point(7, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 216);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // skeetButton5
            // 
            this.skeetButton5.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.skeetButton5.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skeetButton5.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetButton5.Location = new System.Drawing.Point(313, 306);
            this.skeetButton5.Name = "skeetButton5";
            this.skeetButton5.Size = new System.Drawing.Size(94, 23);
            this.skeetButton5.TabIndex = 4;
            this.skeetButton5.Text = "attach";
            this.skeetButton5.Click += new System.EventHandler(this.skeetButton5_Click);
            // 
            // skeetButton4
            // 
            this.skeetButton4.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.skeetButton4.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skeetButton4.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetButton4.Location = new System.Drawing.Point(213, 306);
            this.skeetButton4.Name = "skeetButton4";
            this.skeetButton4.Size = new System.Drawing.Size(94, 23);
            this.skeetButton4.TabIndex = 3;
            this.skeetButton4.Text = "open";
            this.skeetButton4.Click += new System.EventHandler(this.skeetButton4_Click);
            // 
            // skeetButton2
            // 
            this.skeetButton2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.skeetButton2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skeetButton2.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetButton2.Location = new System.Drawing.Point(113, 306);
            this.skeetButton2.Name = "skeetButton2";
            this.skeetButton2.Size = new System.Drawing.Size(94, 23);
            this.skeetButton2.TabIndex = 1;
            this.skeetButton2.Text = "clear";
            this.skeetButton2.Click += new System.EventHandler(this.skeetButton2_Click);
            // 
            // skeetButton1
            // 
            this.skeetButton1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.skeetButton1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skeetButton1.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetButton1.Location = new System.Drawing.Point(13, 306);
            this.skeetButton1.Name = "skeetButton1";
            this.skeetButton1.Size = new System.Drawing.Size(94, 23);
            this.skeetButton1.TabIndex = 0;
            this.skeetButton1.Text = "execute";
            this.skeetButton1.Click += new System.EventHandler(this.skeetButton1_Click_1);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.skeetBackground1;
            // 
            // skeetTextBox1
            // 
            this.skeetTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skeetTextBox1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.skeetTextBox1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetTextBox1.FocusOnHover = false;
            this.skeetTextBox1.Location = new System.Drawing.Point(7, 199);
            this.skeetTextBox1.MaxLength = 32767;
            this.skeetTextBox1.Multiline = false;
            this.skeetTextBox1.Name = "skeetTextBox1";
            this.skeetTextBox1.ReadOnly = false;
            this.skeetTextBox1.Size = new System.Drawing.Size(75, 23);
            this.skeetTextBox1.TabIndex = 13;
            this.skeetTextBox1.Text = "local ScreenGui = Instance.new(\"ScreenGui\")";
            this.skeetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skeetTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skeetTextBox1.UseSystemPasswordChar = false;
            this.skeetTextBox1.Visible = false;
            this.skeetTextBox1.TextChanged += new System.EventHandler(this.skeetTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 341);
            this.Controls.Add(this.skeetBackground1);
            this.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skeetBackground1.ResumeLayout(false);
            this.skeetBackground1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.skeetGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SkeetFramework.SkeetBackground skeetBackground1;
        private SkeetFramework.SkeetButton skeetButton2;
        private SkeetFramework.SkeetButton skeetButton1;
        private SkeetFramework.SkeetGroupBox skeetGroupBox1;
        private SkeetFramework.SkeetButton skeetButton5;
        private SkeetFramework.SkeetButton skeetButton4;
        private System.Windows.Forms.ListBox listBox1;
        private SkeetFramework.SkeetButton skeetButton3;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Label label1;
        private SkeetFramework.SkeetToggle skeetToggle1;
        private SkeetFramework.SkeetToggle skeetToggle2;
        private SkeetFramework.SkeetTextBox skeetTextBox1;
    }
}

