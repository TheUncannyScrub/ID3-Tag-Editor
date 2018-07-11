namespace ID3Editor
{
    partial class ID3Editor
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
            this.btn_getFolder = new System.Windows.Forms.Button();
            this.chkbx_writeArtist = new System.Windows.Forms.CheckBox();
            this.txt_artistName = new System.Windows.Forms.TextBox();
            this.txt_songName = new System.Windows.Forms.TextBox();
            this.chkbx_writeSong = new System.Windows.Forms.CheckBox();
            this.lbl_artistName = new System.Windows.Forms.Label();
            this.lbl_songName = new System.Windows.Forms.Label();
            this.lbl_nextSong = new System.Windows.Forms.Button();
            this.lbl_previousSong = new System.Windows.Forms.Button();
            this.lbl_writeData = new System.Windows.Forms.Button();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.lbx_songList = new System.Windows.Forms.ListBox();
            this.lbl_selectedSong = new System.Windows.Forms.Label();
            this.txt_selectedSong = new System.Windows.Forms.TextBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.txt_yearMade = new System.Windows.Forms.TextBox();
            this.chkbx_writeYear = new System.Windows.Forms.CheckBox();
            this.chkbx_albumName = new System.Windows.Forms.CheckBox();
            this.txt_albumName = new System.Windows.Forms.TextBox();
            this.lbl_albumName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_getFolder
            // 
            this.btn_getFolder.Location = new System.Drawing.Point(21, 21);
            this.btn_getFolder.Name = "btn_getFolder";
            this.btn_getFolder.Size = new System.Drawing.Size(78, 23);
            this.btn_getFolder.TabIndex = 0;
            this.btn_getFolder.Text = "Select Folder";
            this.btn_getFolder.UseVisualStyleBackColor = true;
            this.btn_getFolder.Click += new System.EventHandler(this.btn_getFolder_Click);
            // 
            // chkbx_writeArtist
            // 
            this.chkbx_writeArtist.AutoSize = true;
            this.chkbx_writeArtist.Location = new System.Drawing.Point(211, 77);
            this.chkbx_writeArtist.Name = "chkbx_writeArtist";
            this.chkbx_writeArtist.Size = new System.Drawing.Size(116, 17);
            this.chkbx_writeArtist.TabIndex = 2;
            this.chkbx_writeArtist.Text = "Enable Artist Name";
            this.chkbx_writeArtist.UseVisualStyleBackColor = true;
            this.chkbx_writeArtist.CheckedChanged += new System.EventHandler(this.chkbx_writeArtist_CheckedChanged);
            // 
            // txt_artistName
            // 
            this.txt_artistName.Enabled = false;
            this.txt_artistName.Location = new System.Drawing.Point(105, 75);
            this.txt_artistName.Name = "txt_artistName";
            this.txt_artistName.Size = new System.Drawing.Size(100, 20);
            this.txt_artistName.TabIndex = 4;
            this.txt_artistName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_songName
            // 
            this.txt_songName.Enabled = false;
            this.txt_songName.Location = new System.Drawing.Point(105, 102);
            this.txt_songName.Name = "txt_songName";
            this.txt_songName.Size = new System.Drawing.Size(100, 20);
            this.txt_songName.TabIndex = 5;
            this.txt_songName.TextChanged += new System.EventHandler(this.txt_songName_TextChanged);
            // 
            // chkbx_writeSong
            // 
            this.chkbx_writeSong.AutoSize = true;
            this.chkbx_writeSong.Location = new System.Drawing.Point(211, 104);
            this.chkbx_writeSong.Name = "chkbx_writeSong";
            this.chkbx_writeSong.Size = new System.Drawing.Size(118, 17);
            this.chkbx_writeSong.TabIndex = 6;
            this.chkbx_writeSong.Text = "Enable Song Name";
            this.chkbx_writeSong.UseVisualStyleBackColor = true;
            this.chkbx_writeSong.CheckedChanged += new System.EventHandler(this.chkbx_writeSong_CheckedChanged);
            // 
            // lbl_artistName
            // 
            this.lbl_artistName.AutoSize = true;
            this.lbl_artistName.Location = new System.Drawing.Point(36, 78);
            this.lbl_artistName.Name = "lbl_artistName";
            this.lbl_artistName.Size = new System.Drawing.Size(64, 13);
            this.lbl_artistName.TabIndex = 7;
            this.lbl_artistName.Text = "Artist Name:";
            // 
            // lbl_songName
            // 
            this.lbl_songName.AutoSize = true;
            this.lbl_songName.Location = new System.Drawing.Point(34, 105);
            this.lbl_songName.Name = "lbl_songName";
            this.lbl_songName.Size = new System.Drawing.Size(66, 13);
            this.lbl_songName.TabIndex = 8;
            this.lbl_songName.Text = "Song Name:";
            // 
            // lbl_nextSong
            // 
            this.lbl_nextSong.Location = new System.Drawing.Point(211, 187);
            this.lbl_nextSong.Name = "lbl_nextSong";
            this.lbl_nextSong.Size = new System.Drawing.Size(75, 23);
            this.lbl_nextSong.TabIndex = 9;
            this.lbl_nextSong.Text = "Next";
            this.lbl_nextSong.UseVisualStyleBackColor = true;
            this.lbl_nextSong.Click += new System.EventHandler(this.lbl_nextSong_Click);
            // 
            // lbl_previousSong
            // 
            this.lbl_previousSong.Location = new System.Drawing.Point(49, 187);
            this.lbl_previousSong.Name = "lbl_previousSong";
            this.lbl_previousSong.Size = new System.Drawing.Size(75, 23);
            this.lbl_previousSong.TabIndex = 10;
            this.lbl_previousSong.Text = "Previous";
            this.lbl_previousSong.UseVisualStyleBackColor = true;
            this.lbl_previousSong.Click += new System.EventHandler(this.lbl_previousSong_Click);
            // 
            // lbl_writeData
            // 
            this.lbl_writeData.Location = new System.Drawing.Point(130, 187);
            this.lbl_writeData.Name = "lbl_writeData";
            this.lbl_writeData.Size = new System.Drawing.Size(75, 23);
            this.lbl_writeData.TabIndex = 11;
            this.lbl_writeData.Text = "Write";
            this.lbl_writeData.UseVisualStyleBackColor = true;
            this.lbl_writeData.Click += new System.EventHandler(this.lbl_writeData_Click);
            // 
            // txt_folder
            // 
            this.txt_folder.Location = new System.Drawing.Point(105, 23);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(222, 20);
            this.txt_folder.TabIndex = 12;
            this.txt_folder.TextChanged += new System.EventHandler(this.txt_folder_TextChanged);
            // 
            // lbx_songList
            // 
            this.lbx_songList.FormattingEnabled = true;
            this.lbx_songList.Location = new System.Drawing.Point(355, 12);
            this.lbx_songList.Name = "lbx_songList";
            this.lbx_songList.Size = new System.Drawing.Size(307, 550);
            this.lbx_songList.TabIndex = 14;
            this.lbx_songList.SelectedIndexChanged += new System.EventHandler(this.lbx_songList_SelectedIndexChanged);
            // 
            // lbl_selectedSong
            // 
            this.lbl_selectedSong.AutoSize = true;
            this.lbl_selectedSong.Location = new System.Drawing.Point(22, 52);
            this.lbl_selectedSong.Name = "lbl_selectedSong";
            this.lbl_selectedSong.Size = new System.Drawing.Size(80, 13);
            this.lbl_selectedSong.TabIndex = 15;
            this.lbl_selectedSong.Text = "Selected Song:";
            // 
            // txt_selectedSong
            // 
            this.txt_selectedSong.Enabled = false;
            this.txt_selectedSong.Location = new System.Drawing.Point(105, 49);
            this.txt_selectedSong.Name = "txt_selectedSong";
            this.txt_selectedSong.Size = new System.Drawing.Size(222, 20);
            this.txt_selectedSong.TabIndex = 16;
            this.txt_selectedSong.TextChanged += new System.EventHandler(this.txt_selectedSong_TextChanged);
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(68, 155);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(32, 13);
            this.lbl_Year.TabIndex = 17;
            this.lbl_Year.Text = "Year:";
            // 
            // txt_yearMade
            // 
            this.txt_yearMade.Enabled = false;
            this.txt_yearMade.Location = new System.Drawing.Point(105, 152);
            this.txt_yearMade.Name = "txt_yearMade";
            this.txt_yearMade.Size = new System.Drawing.Size(100, 20);
            this.txt_yearMade.TabIndex = 18;
            // 
            // chkbx_writeYear
            // 
            this.chkbx_writeYear.AutoSize = true;
            this.chkbx_writeYear.Location = new System.Drawing.Point(211, 154);
            this.chkbx_writeYear.Name = "chkbx_writeYear";
            this.chkbx_writeYear.Size = new System.Drawing.Size(114, 17);
            this.chkbx_writeYear.TabIndex = 19;
            this.chkbx_writeYear.Text = "Enable Year Made";
            this.chkbx_writeYear.UseVisualStyleBackColor = true;
            this.chkbx_writeYear.CheckedChanged += new System.EventHandler(this.chkbx_writeYear_CheckedChanged);
            // 
            // chkbx_albumName
            // 
            this.chkbx_albumName.AutoSize = true;
            this.chkbx_albumName.Location = new System.Drawing.Point(211, 130);
            this.chkbx_albumName.Name = "chkbx_albumName";
            this.chkbx_albumName.Size = new System.Drawing.Size(122, 17);
            this.chkbx_albumName.TabIndex = 20;
            this.chkbx_albumName.Text = "Enable Album Name";
            this.chkbx_albumName.UseVisualStyleBackColor = true;
            this.chkbx_albumName.CheckedChanged += new System.EventHandler(this.chkbx_albumName_CheckedChanged);
            // 
            // txt_albumName
            // 
            this.txt_albumName.Enabled = false;
            this.txt_albumName.Location = new System.Drawing.Point(105, 128);
            this.txt_albumName.Name = "txt_albumName";
            this.txt_albumName.Size = new System.Drawing.Size(100, 20);
            this.txt_albumName.TabIndex = 21;
            // 
            // lbl_albumName
            // 
            this.lbl_albumName.AutoSize = true;
            this.lbl_albumName.Location = new System.Drawing.Point(30, 131);
            this.lbl_albumName.Name = "lbl_albumName";
            this.lbl_albumName.Size = new System.Drawing.Size(70, 13);
            this.lbl_albumName.TabIndex = 22;
            this.lbl_albumName.Text = "Album Name:";
            // 
            // ID3Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 580);
            this.Controls.Add(this.lbl_albumName);
            this.Controls.Add(this.txt_albumName);
            this.Controls.Add(this.chkbx_albumName);
            this.Controls.Add(this.chkbx_writeYear);
            this.Controls.Add(this.txt_yearMade);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.txt_selectedSong);
            this.Controls.Add(this.lbl_selectedSong);
            this.Controls.Add(this.lbx_songList);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.lbl_writeData);
            this.Controls.Add(this.lbl_previousSong);
            this.Controls.Add(this.lbl_nextSong);
            this.Controls.Add(this.lbl_songName);
            this.Controls.Add(this.lbl_artistName);
            this.Controls.Add(this.chkbx_writeSong);
            this.Controls.Add(this.txt_songName);
            this.Controls.Add(this.txt_artistName);
            this.Controls.Add(this.chkbx_writeArtist);
            this.Controls.Add(this.btn_getFolder);
            this.MaximizeBox = false;
            this.Name = "ID3Editor";
            this.ShowIcon = false;
            this.Text = "ID3 MP3 Tag Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getFolder;
        private System.Windows.Forms.CheckBox chkbx_writeArtist;
        private System.Windows.Forms.TextBox txt_artistName;
        private System.Windows.Forms.TextBox txt_songName;
        private System.Windows.Forms.CheckBox chkbx_writeSong;
        private System.Windows.Forms.Label lbl_artistName;
        private System.Windows.Forms.Label lbl_songName;
        private System.Windows.Forms.Button lbl_nextSong;
        private System.Windows.Forms.Button lbl_previousSong;
        private System.Windows.Forms.Button lbl_writeData;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.ListBox lbx_songList;
        private System.Windows.Forms.Label lbl_selectedSong;
        private System.Windows.Forms.TextBox txt_selectedSong;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.TextBox txt_yearMade;
        private System.Windows.Forms.CheckBox chkbx_writeYear;
        private System.Windows.Forms.CheckBox chkbx_albumName;
        private System.Windows.Forms.TextBox txt_albumName;
        private System.Windows.Forms.Label lbl_albumName;
    }
}

