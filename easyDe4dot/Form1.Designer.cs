namespace easyDe4dot
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPrsrvTok = new System.Windows.Forms.CheckBox();
            this.chkKeepTypes = new System.Windows.Forms.CheckBox();
            this.chkDntRnm = new System.Windows.Forms.CheckBox();
            this.chkForceObf = new System.Windows.Forms.CheckBox();
            this.cmbObf = new System.Windows.Forms.ComboBox();
            this.chkStrtype = new System.Windows.Forms.CheckBox();
            this.cmbStrype = new System.Windows.Forms.ComboBox();
            this.lblStrtok = new System.Windows.Forms.Label();
            this.txtStrtok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chk64 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.AllowDrop = true;
            this.txtFile.Location = new System.Drawing.Point(68, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(424, 22);
            this.txtFile.TabIndex = 0;
            this.txtFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFile_DragDrop);
            this.txtFile.DragOver += new System.Windows.Forms.DragEventHandler(this.txtFile_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target";
            // 
            // chkPrsrvTok
            // 
            this.chkPrsrvTok.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrsrvTok.AutoSize = true;
            this.chkPrsrvTok.Location = new System.Drawing.Point(15, 46);
            this.chkPrsrvTok.Name = "chkPrsrvTok";
            this.chkPrsrvTok.Size = new System.Drawing.Size(131, 27);
            this.chkPrsrvTok.TabIndex = 2;
            this.chkPrsrvTok.Text = "--preserve-tokens";
            this.chkPrsrvTok.UseVisualStyleBackColor = true;
            // 
            // chkKeepTypes
            // 
            this.chkKeepTypes.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKeepTypes.AutoSize = true;
            this.chkKeepTypes.Location = new System.Drawing.Point(152, 46);
            this.chkKeepTypes.Name = "chkKeepTypes";
            this.chkKeepTypes.Size = new System.Drawing.Size(98, 27);
            this.chkKeepTypes.TabIndex = 2;
            this.chkKeepTypes.Text = "--keep-types";
            this.chkKeepTypes.UseVisualStyleBackColor = true;
            // 
            // chkDntRnm
            // 
            this.chkDntRnm.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDntRnm.AutoSize = true;
            this.chkDntRnm.Location = new System.Drawing.Point(256, 46);
            this.chkDntRnm.Name = "chkDntRnm";
            this.chkDntRnm.Size = new System.Drawing.Size(109, 27);
            this.chkDntRnm.TabIndex = 2;
            this.chkDntRnm.Text = "--dont-rename";
            this.chkDntRnm.UseVisualStyleBackColor = true;
            // 
            // chkForceObf
            // 
            this.chkForceObf.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkForceObf.AutoSize = true;
            this.chkForceObf.Location = new System.Drawing.Point(371, 46);
            this.chkForceObf.Name = "chkForceObf";
            this.chkForceObf.Size = new System.Drawing.Size(31, 27);
            this.chkForceObf.TabIndex = 2;
            this.chkForceObf.Text = "-p";
            this.chkForceObf.UseVisualStyleBackColor = true;
            // 
            // cmbObf
            // 
            this.cmbObf.FormattingEnabled = true;
            this.cmbObf.Items.AddRange(new object[] {
            "un (Unknown)",
            "an (Agile.NET)",
            "bl (Babel .NET)",
            "cf (CodeFort)",
            "cv (CodeVeil)",
            "cw (CodeWall)",
            "cr (Confuser)",
            "co (Crypto Obfuscator)",
            "ds (DeepSea)",
            "df (Dotfuscator)",
            "dr3 (.NET Reactor)",
            "dr4 (.NET Reactor)",
            "ef (Eazfuscator.NET)",
            "go (Goliath.NET)",
            "il (ILProtector)",
            "mc (MaxtoCode)",
            "mp (MPRESS)",
            "rm (Rummage)",
            "sk (Skater .NET)",
            "sa (SmartAssembly)",
            "sn (Spices.Net)",
            "xc (Xenocode)"});
            this.cmbObf.Location = new System.Drawing.Point(408, 48);
            this.cmbObf.Name = "cmbObf";
            this.cmbObf.Size = new System.Drawing.Size(121, 24);
            this.cmbObf.TabIndex = 3;
            this.cmbObf.Text = "un (Unknown)";
            // 
            // chkStrtype
            // 
            this.chkStrtype.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStrtype.AutoSize = true;
            this.chkStrtype.Location = new System.Drawing.Point(15, 76);
            this.chkStrtype.Name = "chkStrtype";
            this.chkStrtype.Size = new System.Drawing.Size(63, 27);
            this.chkStrtype.TabIndex = 2;
            this.chkStrtype.Text = "--strtyp";
            this.chkStrtype.UseVisualStyleBackColor = true;
            // 
            // cmbStrype
            // 
            this.cmbStrype.FormattingEnabled = true;
            this.cmbStrype.Items.AddRange(new object[] {
            "delegate",
            "emulate"});
            this.cmbStrype.Location = new System.Drawing.Point(84, 79);
            this.cmbStrype.Name = "cmbStrype";
            this.cmbStrype.Size = new System.Drawing.Size(121, 24);
            this.cmbStrype.TabIndex = 3;
            this.cmbStrype.Text = "delegate";
            // 
            // lblStrtok
            // 
            this.lblStrtok.AutoSize = true;
            this.lblStrtok.Location = new System.Drawing.Point(211, 81);
            this.lblStrtok.Name = "lblStrtok";
            this.lblStrtok.Size = new System.Drawing.Size(53, 17);
            this.lblStrtok.TabIndex = 1;
            this.lblStrtok.Text = "--strtok";
            // 
            // txtStrtok
            // 
            this.txtStrtok.Location = new System.Drawing.Point(271, 79);
            this.txtStrtok.Name = "txtStrtok";
            this.txtStrtok.Size = new System.Drawing.Size(258, 22);
            this.txtStrtok.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "can use many tokens, separate them with space";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Location = new System.Drawing.Point(499, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 27);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.ForeColor = System.Drawing.Color.Silver;
            this.txtLog.Location = new System.Drawing.Point(11, 150);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(517, 196);
            this.txtLog.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(11, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(192, 352);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(157, 39);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "exe|*.exe|dll|*.dll|All files|*.*";
            this.openFileDialog1.Title = "easyDe4dot - select file";
            // 
            // chk64
            // 
            this.chk64.AutoSize = true;
            this.chk64.Location = new System.Drawing.Point(476, 362);
            this.chk64.Name = "chk64";
            this.chk64.Size = new System.Drawing.Size(52, 21);
            this.chk64.TabIndex = 8;
            this.chk64.Text = "x64";
            this.chk64.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 397);
            this.Controls.Add(this.chk64);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbStrype);
            this.Controls.Add(this.cmbObf);
            this.Controls.Add(this.chkStrtype);
            this.Controls.Add(this.chkForceObf);
            this.Controls.Add(this.chkDntRnm);
            this.Controls.Add(this.chkKeepTypes);
            this.Controls.Add(this.chkPrsrvTok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStrtok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStrtok);
            this.Controls.Add(this.txtFile);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "easyDe4dot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPrsrvTok;
        private System.Windows.Forms.CheckBox chkKeepTypes;
        private System.Windows.Forms.CheckBox chkDntRnm;
        private System.Windows.Forms.CheckBox chkForceObf;
        private System.Windows.Forms.ComboBox cmbObf;
        private System.Windows.Forms.CheckBox chkStrtype;
        private System.Windows.Forms.ComboBox cmbStrype;
        private System.Windows.Forms.Label lblStrtok;
        private System.Windows.Forms.TextBox txtStrtok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chk64;
    }
}

