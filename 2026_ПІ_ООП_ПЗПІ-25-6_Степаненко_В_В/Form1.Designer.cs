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
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            label4.Location = new Point(605, 108);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 11;
            label4.Text = "Жанр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 75);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 10;
            label3.Text = "Рік";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(605, 42);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 9;
            label2.Text = "Країна";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 8;
            label1.Text = "Назва";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(694, 105);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(146, 27);
            txtGenre.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(694, 72);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(146, 27);
            txtYear.TabIndex = 6;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(694, 39);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(146, 27);
            txtCountry.TabIndex = 5;
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(694, 6);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(146, 27);
            txtArtistName.TabIndex = 4;
            // 
            // btnDeleteArtist
            // 
            btnDeleteArtist.Location = new Point(6, 226);
            btnDeleteArtist.Name = "btnDeleteArtist";
            btnDeleteArtist.Size = new Size(94, 29);
            btnDeleteArtist.TabIndex = 3;
            btnDeleteArtist.Text = "Видалити";
            btnDeleteArtist.UseVisualStyleBackColor = true;
            btnDeleteArtist.Click += btnDeleteArtist_Click;
            // 
            // btnEditArtist
            // 
            btnEditArtist.Location = new Point(6, 191);
            btnEditArtist.Name = "btnEditArtist";
            btnEditArtist.Size = new Size(94, 29);
            btnEditArtist.TabIndex = 2;
            btnEditArtist.Text = "Редагувати";
            btnEditArtist.UseVisualStyleBackColor = true;
            btnEditArtist.Click += btnEditArtist_Click;
            // 
            // btnAddArtist
            // 
            btnAddArtist.Location = new Point(6, 156);
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
            listBoxArtists.Location = new Point(6, 6);
            listBoxArtists.Name = "listBoxArtists";
            listBoxArtists.Size = new Size(179, 144);
            listBoxArtists.TabIndex = 0;
            listBoxArtists.SelectedIndexChanged += listBoxArtists_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(846, 480);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пісні";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(846, 480);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Диски";
            tabPage3.UseVisualStyleBackColor = true;
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
    }
}
