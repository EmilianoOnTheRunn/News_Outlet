namespace NewsOutlet
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
            this.settxt = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.txtxSetTime = new System.Windows.Forms.TextBox();
            this.Showgrpbx = new System.Windows.Forms.GroupBox();
            this.keywordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showRecentrbtn = new System.Windows.Forms.RadioButton();
            this.ShowTrendingsrbtn = new System.Windows.Forms.RadioButton();
            this.setbtn = new System.Windows.Forms.Button();
            this.lstbxNews = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Showgrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // settxt
            // 
            this.settxt.AutoSize = true;
            this.settxt.Location = new System.Drawing.Point(62, 46);
            this.settxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.settxt.Name = "settxt";
            this.settxt.Size = new System.Drawing.Size(111, 13);
            this.settxt.TabIndex = 0;
            this.settxt.Text = "Enter the time set:";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(44, 100);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(120, 48);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // txtxSetTime
            // 
            this.txtxSetTime.Location = new System.Drawing.Point(176, 43);
            this.txtxSetTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtxSetTime.Name = "txtxSetTime";
            this.txtxSetTime.Size = new System.Drawing.Size(116, 20);
            this.txtxSetTime.TabIndex = 8;
            // 
            // Showgrpbx
            // 
            this.Showgrpbx.Controls.Add(this.keywordtxt);
            this.Showgrpbx.Controls.Add(this.label1);
            this.Showgrpbx.Controls.Add(this.txtID);
            this.Showgrpbx.Controls.Add(this.lblID);
            this.Showgrpbx.Controls.Add(this.btnShow);
            this.Showgrpbx.Controls.Add(this.showRecentrbtn);
            this.Showgrpbx.Controls.Add(this.ShowTrendingsrbtn);
            this.Showgrpbx.Location = new System.Drawing.Point(304, 12);
            this.Showgrpbx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Showgrpbx.Name = "Showgrpbx";
            this.Showgrpbx.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Showgrpbx.Size = new System.Drawing.Size(333, 159);
            this.Showgrpbx.TabIndex = 12;
            this.Showgrpbx.TabStop = false;
            this.Showgrpbx.Text = "SHOW";
            // 
            // keywordtxt
            // 
            this.keywordtxt.Location = new System.Drawing.Point(136, 45);
            this.keywordtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.keywordtxt.Name = "keywordtxt";
            this.keywordtxt.Size = new System.Drawing.Size(116, 20);
            this.keywordtxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter keyword:";
            // 
            // showRecentrbtn
            // 
            this.showRecentrbtn.AutoSize = true;
            this.showRecentrbtn.Location = new System.Drawing.Point(25, 119);
            this.showRecentrbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showRecentrbtn.Name = "showRecentrbtn";
            this.showRecentrbtn.Size = new System.Drawing.Size(83, 17);
            this.showRecentrbtn.TabIndex = 12;
            this.showRecentrbtn.TabStop = true;
            this.showRecentrbtn.Text = "RECENTS";
            this.showRecentrbtn.UseVisualStyleBackColor = true;
            this.showRecentrbtn.CheckedChanged += new System.EventHandler(this.showRecentrbtn_CheckedChanged);
            // 
            // ShowTrendingsrbtn
            // 
            this.ShowTrendingsrbtn.AutoSize = true;
            this.ShowTrendingsrbtn.Location = new System.Drawing.Point(25, 96);
            this.ShowTrendingsrbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowTrendingsrbtn.Name = "ShowTrendingsrbtn";
            this.ShowTrendingsrbtn.Size = new System.Drawing.Size(98, 17);
            this.ShowTrendingsrbtn.TabIndex = 11;
            this.ShowTrendingsrbtn.TabStop = true;
            this.ShowTrendingsrbtn.Text = "TRENDINGS";
            this.ShowTrendingsrbtn.UseVisualStyleBackColor = true;
            this.ShowTrendingsrbtn.CheckedChanged += new System.EventHandler(this.ShowTrendingsrbtn_CheckedChanged);
            // 
            // setbtn
            // 
            this.setbtn.Location = new System.Drawing.Point(176, 100);
            this.setbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.setbtn.Name = "setbtn";
            this.setbtn.Size = new System.Drawing.Size(120, 48);
            this.setbtn.TabIndex = 13;
            this.setbtn.Text = "SET";
            this.setbtn.UseVisualStyleBackColor = true;
            this.setbtn.Click += new System.EventHandler(this.setbtn_Click);
            // 
            // lstbxNews
            // 
            this.lstbxNews.FormattingEnabled = true;
            this.lstbxNews.Location = new System.Drawing.Point(11, 176);
            this.lstbxNews.Margin = new System.Windows.Forms.Padding(2);
            this.lstbxNews.Name = "lstbxNews";
            this.lstbxNews.Size = new System.Drawing.Size(626, 121);
            this.lstbxNews.TabIndex = 14;
            this.lstbxNews.SelectedIndexChanged += new System.EventHandler(this.lstbxNews_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 26);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "Enter ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 19);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 20);
            this.txtID.TabIndex = 16;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(136, 88);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 48);
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(109, 326);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 112);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Selected News:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lstbxNews);
            this.Controls.Add(this.setbtn);
            this.Controls.Add(this.Showgrpbx);
            this.Controls.Add(this.txtxSetTime);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.settxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Showgrpbx.ResumeLayout(false);
            this.Showgrpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settxt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox txtxSetTime;
        private System.Windows.Forms.GroupBox Showgrpbx;
        private System.Windows.Forms.TextBox keywordtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton showRecentrbtn;
        private System.Windows.Forms.RadioButton ShowTrendingsrbtn;
        private System.Windows.Forms.Button setbtn;
        private System.Windows.Forms.ListBox lstbxNews;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
    }
}

