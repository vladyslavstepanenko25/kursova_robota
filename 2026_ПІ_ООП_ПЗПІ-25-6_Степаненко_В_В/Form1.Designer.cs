namespace MusicDirectory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGenre = new TextBox();
            txtYear = new TextBox();
            txtCountry = new TextBox();
            txtArtistName = new TextBox();
            btnDeleteArtist = new Button();
            btnEditArtist = new Button();
            btnAddArtist = new Button();
            listBoxArtists = new ListBox();
            tabPage2 = new TabPage();
            btnDeleteSong = new Button();
            btnEditSong = new Button();
            btnAddSong = new Button();
            cmbSongArtist = new ComboBox();
            cmbFilterArtist = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtSongLanguage = new TextBox();
            txtSongDuration = new TextBox();
            txtSongTitle = new TextBox();
            listBoxSongs = new ListBox();
            tabPage3 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnDeleteDisk = new Button();
            btnEditDisk = new Button();
            btnAddDisk = new Button();
            checkedListBoxSongs = new CheckedListBox();
            txtDiskLabel = new TextBox();
            txtDiskYear = new TextBox();
            txtDiskTitle = new TextBox();
            cmbFilterSong = new ComboBox();
            listBoxDisks = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(854, 513);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtGenre);
            tabPage1.Controls.Add(txtYear);
            tabPage1.Controls.Add(txtCountry);
            tabPage1.Controls.Add(txtArtistName);
            tabPage1.Controls.Add(btnDeleteArtist);
            tabPage1.Controls.Add(btnEditArtist);
            tabPage1.Controls.Add(btnAddArtist);
            tabPage1.Controls.Add(listBoxArtists);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(846, 480);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Виконавці";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(527, 127);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 11;
            label4.Text = "Жанр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(527, 94);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 10;
            label3.Text = "Рік";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 61);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 9;
            label2.Text = "Країна";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 8;
            label1.Text = "Назва";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(632, 124);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(184, 27);
            txtGenre.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(632, 91);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(184, 27);
            txtYear.TabIndex = 6;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(632, 58);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(184, 27);
            txtCountry.TabIndex = 5;
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(632, 25);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(184, 27);
            txtArtistName.TabIndex = 4;
            // 
            // btnDeleteArtist
            // 
            btnDeleteArtist.Location = new Point(22, 267);
            btnDeleteArtist.Name = "btnDeleteArtist";
            btnDeleteArtist.Size = new Size(94, 29);
            btnDeleteArtist.TabIndex = 3;
            btnDeleteArtist.Text = "Видалити";
            btnDeleteArtist.UseVisualStyleBackColor = true;
            btnDeleteArtist.Click += btnDeleteArtist_Click;
            // 
            // btnEditArtist
            // 
            btnEditArtist.Location = new Point(22, 302);
            btnEditArtist.Name = "btnEditArtist";
            btnEditArtist.Size = new Size(94, 29);
            btnEditArtist.TabIndex = 2;
            btnEditArtist.Text = "Редагувати";
            btnEditArtist.UseVisualStyleBackColor = true;
            btnEditArtist.Click += btnEditArtist_Click;
            // 
            // btnAddArtist
            // 
            btnAddArtist.Location = new Point(22, 232);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(94, 29);
            btnAddArtist.TabIndex = 1;
            btnAddArtist.Text = "Додати";
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // listBoxArtists
            // 
            listBoxArtists.FormattingEnabled = true;
            listBoxArtists.Location = new Point(22, 25);
            listBoxArtists.Name = "listBoxArtists";
            listBoxArtists.Size = new Size(182, 184);
            listBoxArtists.TabIndex = 0;
            listBoxArtists.SelectedIndexChanged += listBoxArtists_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteSong);
            tabPage2.Controls.Add(btnEditSong);
            tabPage2.Controls.Add(btnAddSong);
            tabPage2.Controls.Add(cmbSongArtist);
            tabPage2.Controls.Add(cmbFilterArtist);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtSongLanguage);
            tabPage2.Controls.Add(txtSongDuration);
            tabPage2.Controls.Add(txtSongTitle);
            tabPage2.Controls.Add(listBoxSongs);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(846, 480);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пісні";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSong
            // 
            btnDeleteSong.Location = new Point(21, 294);
            btnDeleteSong.Name = "btnDeleteSong";
            btnDeleteSong.Size = new Size(94, 29);
            btnDeleteSong.TabIndex = 11;
            btnDeleteSong.Text = "Видалити";
            btnDeleteSong.UseVisualStyleBackColor = true;
            btnDeleteSong.Click += btnDeleteSong_Click;
            // 
            // btnEditSong
            // 
            btnEditSong.Location = new Point(21, 259);
            btnEditSong.Name = "btnEditSong";
            btnEditSong.Size = new Size(94, 29);
            btnEditSong.TabIndex = 10;
            btnEditSong.Text = "Редагувати";
            btnEditSong.UseVisualStyleBackColor = true;
            btnEditSong.Click += btnEditSong_Click;
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new Point(21, 224);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(94, 29);
            btnAddSong.TabIndex = 9;
            btnAddSong.Text = "Додати";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // cmbSongArtist
            // 
            cmbSongArtist.FormattingEnabled = true;
            cmbSongArtist.Location = new Point(627, 135);
            cmbSongArtist.Name = "cmbSongArtist";
            cmbSongArtist.Size = new Size(178, 28);
            cmbSongArtist.TabIndex = 8;
            // 
            // cmbFilterArtist
            // 
            cmbFilterArtist.FormattingEnabled = true;
            cmbFilterArtist.Location = new Point(20, 18);
            cmbFilterArtist.Name = "cmbFilterArtist";
            cmbFilterArtist.Size = new Size(178, 28);
            cmbFilterArtist.TabIndex = 7;
            cmbFilterArtist.SelectedIndexChanged += cmbFilterArtist_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 92);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 6;
            label7.Text = "Мова";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 59);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 5;
            label6.Text = "Тривалість";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 26);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Назва";
            // 
            // txtSongLanguage
            // 
            txtSongLanguage.Location = new Point(627, 89);
            txtSongLanguage.Name = "txtSongLanguage";
            txtSongLanguage.Size = new Size(178, 27);
            txtSongLanguage.TabIndex = 3;
            // 
            // txtSongDuration
            // 
            txtSongDuration.Location = new Point(627, 56);
            txtSongDuration.Name = "txtSongDuration";
            txtSongDuration.Size = new Size(178, 27);
            txtSongDuration.TabIndex = 2;
            // 
            // txtSongTitle
            // 
            txtSongTitle.Location = new Point(627, 23);
            txtSongTitle.Name = "txtSongTitle";
            txtSongTitle.Size = new Size(178, 27);
            txtSongTitle.TabIndex = 1;
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(21, 59);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(177, 144);
            listBoxSongs.TabIndex = 0;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(btnDeleteDisk);
            tabPage3.Controls.Add(btnEditDisk);
            tabPage3.Controls.Add(btnAddDisk);
            tabPage3.Controls.Add(checkedListBoxSongs);
            tabPage3.Controls.Add(txtDiskLabel);
            tabPage3.Controls.Add(txtDiskYear);
            tabPage3.Controls.Add(txtDiskTitle);
            tabPage3.Controls.Add(cmbFilterSong);
            tabPage3.Controls.Add(listBoxDisks);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(846, 480);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Диски";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(558, 98);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 11;
            label10.Text = "Лейбл";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(558, 65);
            label9.Name = "label9";
            label9.Size = new Size(28, 20);
            label9.TabIndex = 10;
            label9.Text = "Рік";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(558, 32);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 9;
            label8.Text = "Назва";
            // 
            // btnDeleteDisk
            // 
            btnDeleteDisk.Location = new Point(22, 267);
            btnDeleteDisk.Name = "btnDeleteDisk";
            btnDeleteDisk.Size = new Size(94, 29);
            btnDeleteDisk.TabIndex = 8;
            btnDeleteDisk.Text = "Видалити";
            btnDeleteDisk.UseVisualStyleBackColor = true;
            btnDeleteDisk.Click += btnDeleteDisk_Click;
            // 
            // btnEditDisk
            // 
            btnEditDisk.Location = new Point(22, 232);
            btnEditDisk.Name = "btnEditDisk";
            btnEditDisk.Size = new Size(94, 29);
            btnEditDisk.TabIndex = 7;
            btnEditDisk.Text = "Редагувати";
            btnEditDisk.UseVisualStyleBackColor = true;
            btnEditDisk.Click += btnEditDisk_Click;
            // 
            // btnAddDisk
            // 
            btnAddDisk.Location = new Point(22, 197);
            btnAddDisk.Name = "btnAddDisk";
            btnAddDisk.Size = new Size(94, 29);
            btnAddDisk.TabIndex = 6;
            btnAddDisk.Text = "Додати";
            btnAddDisk.UseVisualStyleBackColor = true;
            btnAddDisk.Click += btnAddDisk_Click;
            // 
            // checkedListBoxSongs
            // 
            checkedListBoxSongs.FormattingEnabled = true;
            checkedListBoxSongs.Location = new Point(640, 150);
            checkedListBoxSongs.Name = "checkedListBoxSongs";
            checkedListBoxSongs.Size = new Size(175, 158);
            checkedListBoxSongs.TabIndex = 5;
            // 
            // txtDiskLabel
            // 
            txtDiskLabel.Location = new Point(640, 95);
            txtDiskLabel.Name = "txtDiskLabel";
            txtDiskLabel.Size = new Size(175, 27);
            txtDiskLabel.TabIndex = 4;
            // 
            // txtDiskYear
            // 
            txtDiskYear.Location = new Point(640, 62);
            txtDiskYear.Name = "txtDiskYear";
            txtDiskYear.Size = new Size(175, 27);
            txtDiskYear.TabIndex = 3;
            // 
            // txtDiskTitle
            // 
            txtDiskTitle.Location = new Point(640, 29);
            txtDiskTitle.Name = "txtDiskTitle";
            txtDiskTitle.Size = new Size(175, 27);
            txtDiskTitle.TabIndex = 2;
            // 
            // cmbFilterSong
            // 
            cmbFilterSong.FormattingEnabled = true;
            cmbFilterSong.Location = new Point(22, 28);
            cmbFilterSong.Name = "cmbFilterSong";
            cmbFilterSong.Size = new Size(187, 28);
            cmbFilterSong.TabIndex = 1;
            cmbFilterSong.SelectedIndexChanged += cmbFilterSong_SelectedIndexChanged;
            // 
            // listBoxDisks
            // 
            listBoxDisks.FormattingEnabled = true;
            listBoxDisks.Location = new Point(22, 71);
            listBoxDisks.Name = "listBoxDisks";
            listBoxDisks.Size = new Size(187, 104);
            listBoxDisks.TabIndex = 0;
            listBoxDisks.SelectedIndexChanged += listBoxDisks_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 537);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtArtistName;
        private Button btnDeleteArtist;
        private Button btnEditArtist;
        private Button btnAddArtist;
        private ListBox listBoxArtists;
        private TextBox txtGenre;
        private TextBox txtYear;
        private TextBox txtCountry;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBoxSongs;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtSongLanguage;
        private TextBox txtSongDuration;
        private TextBox txtSongTitle;
        private ComboBox cmbSongArtist;
        private ComboBox cmbFilterArtist;
        private Button btnDeleteSong;
        private Button btnEditSong;
        private Button btnAddSong;
        private ComboBox cmbFilterSong;
        private ListBox listBoxDisks;
        private TextBox txtDiskLabel;
        private TextBox txtDiskYear;
        private TextBox txtDiskTitle;
        private Button btnDeleteDisk;
        private Button btnEditDisk;
        private Button btnAddDisk;
        private CheckedListBox checkedListBoxSongs;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}
