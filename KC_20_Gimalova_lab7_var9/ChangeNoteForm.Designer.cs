namespace KC_20_Gimalova_lab7_var9
{
    partial class ChangeNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeNoteForm));
            this.numEndPage = new System.Windows.Forms.NumericUpDown();
            this.numFirstPage = new System.Windows.Forms.NumericUpDown();
            this.JournalImg = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtNumJournal = new System.Windows.Forms.TextBox();
            this.txtTom = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtNameArticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNameJournal = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.trackBarYear = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYear)).BeginInit();
            this.SuspendLayout();
            // 
            // numEndPage
            // 
            this.numEndPage.Location = new System.Drawing.Point(198, 329);
            this.numEndPage.Name = "numEndPage";
            this.numEndPage.Size = new System.Drawing.Size(120, 22);
            this.numEndPage.TabIndex = 43;
            // 
            // numFirstPage
            // 
            this.numFirstPage.Location = new System.Drawing.Point(72, 329);
            this.numFirstPage.Name = "numFirstPage";
            this.numFirstPage.Size = new System.Drawing.Size(120, 22);
            this.numFirstPage.TabIndex = 42;
            // 
            // JournalImg
            // 
            this.JournalImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.JournalImg.Location = new System.Drawing.Point(516, 97);
            this.JournalImg.Name = "JournalImg";
            this.JournalImg.Size = new System.Drawing.Size(174, 207);
            this.JournalImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JournalImg.TabIndex = 41;
            this.JournalImg.TabStop = false;
            this.JournalImg.Click += new System.EventHandler(this.JournalImg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(325, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "Номер страницы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(325, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Номер журнала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(325, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Номер тома";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(325, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Авторы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(325, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Название статьи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(325, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Название журнала";
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(606, 373);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(99, 86);
            this.btnClearAll.TabIndex = 33;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnChange
            // 
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(516, 373);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(99, 86);
            this.btnChange.TabIndex = 32;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtNumJournal
            // 
            this.txtNumJournal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumJournal.Location = new System.Drawing.Point(17, 277);
            this.txtNumJournal.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtNumJournal.Name = "txtNumJournal";
            this.txtNumJournal.Size = new System.Drawing.Size(309, 22);
            this.txtNumJournal.TabIndex = 30;
            // 
            // txtTom
            // 
            this.txtTom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTom.Location = new System.Drawing.Point(17, 231);
            this.txtTom.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtTom.Name = "txtTom";
            this.txtTom.Size = new System.Drawing.Size(309, 22);
            this.txtTom.TabIndex = 29;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Location = new System.Drawing.Point(17, 185);
            this.txtAuthor.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(309, 22);
            this.txtAuthor.TabIndex = 28;
            // 
            // txtNameArticle
            // 
            this.txtNameArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameArticle.Location = new System.Drawing.Point(17, 139);
            this.txtNameArticle.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtNameArticle.Name = "txtNameArticle";
            this.txtNameArticle.Size = new System.Drawing.Size(309, 22);
            this.txtNameArticle.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(89, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Изменить запись";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 77);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txtNameJournal
            // 
            this.txtNameJournal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameJournal.Location = new System.Drawing.Point(17, 93);
            this.txtNameJournal.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtNameJournal.Name = "txtNameJournal";
            this.txtNameJournal.Size = new System.Drawing.Size(309, 22);
            this.txtNameJournal.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(414, 51);
            this.txtID.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(83, 22);
            this.txtID.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(381, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "ID";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.lblYear.Location = new System.Drawing.Point(325, 394);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(20, 24);
            this.lblYear.TabIndex = 48;
            this.lblYear.Text = "0";
            // 
            // trackBarYear
            // 
            this.trackBarYear.LargeChange = 1;
            this.trackBarYear.Location = new System.Drawing.Point(17, 373);
            this.trackBarYear.Maximum = 2050;
            this.trackBarYear.Minimum = 1950;
            this.trackBarYear.Name = "trackBarYear";
            this.trackBarYear.Size = new System.Drawing.Size(301, 56);
            this.trackBarYear.TabIndex = 47;
            this.trackBarYear.Value = 1950;
            this.trackBarYear.Scroll += new System.EventHandler(this.trackBarYear_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(325, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Год";
            // 
            // ChangeNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(719, 490);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.trackBarYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.numEndPage);
            this.Controls.Add(this.numFirstPage);
            this.Controls.Add(this.JournalImg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtNumJournal);
            this.Controls.Add(this.txtTom);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtNameArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNameJournal);
            this.Name = "ChangeNoteForm";
            this.Text = "ChangeNoteForm";
            this.Load += new System.EventHandler(this.ChangeNoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEndPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown numEndPage;
        public System.Windows.Forms.NumericUpDown numFirstPage;
        public System.Windows.Forms.PictureBox JournalImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.TextBox txtNumJournal;
        public System.Windows.Forms.TextBox txtTom;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.TextBox txtNameArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtNameJournal;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TrackBar trackBarYear;
    }
}