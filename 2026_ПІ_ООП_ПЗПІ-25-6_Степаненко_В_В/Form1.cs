using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class Form1 : Form
    {
        private DataManager dataManager = new DataManager();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataManager.LoadData();

            UpdateArtistList();

            UpdateArtistComboBoxes(); 
            UpdateSongList();         

            UpdateSongListsForDisks();
            UpdateDiskList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataManager.SaveData();
        }

        private void UpdateArtistList()
        {
            listBoxArtists.Items.Clear(); 

            foreach (var artist in dataManager.Artists)
            {
                listBoxArtists.Items.Add(artist); 
            }

            UpdateArtistComboBoxes();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArtistName.Text))
            {
                MessageBox.Show("Назва виконавця не може бути порожньою!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Artist newArtist = new Artist();
            newArtist.Name = txtArtistName.Text.Trim();
            newArtist.Country = txtCountry.Text.Trim(); 
            newArtist.Genre = txtGenre.Text.Trim();     

            if (int.TryParse(txtYear.Text.Trim(), out int year))
            {
                newArtist.FoundationYear = year;
            }

            dataManager.Artists.Add(newArtist);
            UpdateArtistList();

            txtArtistName.Clear();
            txtCountry.Clear();
            txtYear.Clear();
            txtGenre.Clear();
        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem != null)
            {
                Artist selectedArtist = (Artist)listBoxArtists.SelectedItem;

                DialogResult result = MessageBox.Show($"Ви дійсно хочете видалити виконавця '{selectedArtist.Name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataManager.Artists.Remove(selectedArtist);
                    UpdateArtistList();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть виконавця для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem != null)
            {
                Artist selectedArtist = (Artist)listBoxArtists.SelectedItem;

                txtArtistName.Text = selectedArtist.Name;
                txtCountry.Text = selectedArtist.Country;
                txtGenre.Text = selectedArtist.Genre;

                txtYear.Text = selectedArtist.FoundationYear == 0 ? "" : selectedArtist.FoundationYear.ToString();
            }
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem != null)
            {
                if (string.IsNullOrWhiteSpace(txtArtistName.Text))
                {
                    MessageBox.Show("Назва виконавця не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Artist selectedArtist = (Artist)listBoxArtists.SelectedItem;

                selectedArtist.Name = txtArtistName.Text.Trim();
                selectedArtist.Country = txtCountry.Text.Trim();
                selectedArtist.Genre = txtGenre.Text.Trim();

                if (int.TryParse(txtYear.Text.Trim(), out int year))
                {
                    selectedArtist.FoundationYear = year;
                }

                UpdateArtistList();

                txtArtistName.Clear();
                txtCountry.Clear();
                txtYear.Clear();
                txtGenre.Clear();

                MessageBox.Show("Дані успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть виконавця для редагування.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateArtistComboBoxes()
        {
            cmbFilterArtist.Items.Clear();
            cmbSongArtist.Items.Clear();

            cmbFilterArtist.Items.Add("Всі виконавці");

            foreach (var artist in dataManager.Artists)
            {
                cmbFilterArtist.Items.Add(artist);
                cmbSongArtist.Items.Add(artist);
            }

            if (cmbFilterArtist.Items.Count > 0)
            {
                cmbFilterArtist.SelectedIndex = 0;
            }
        }

        private void UpdateSongList()
        {
            listBoxSongs.Items.Clear();
            foreach (var song in dataManager.Songs)
            {
                listBoxSongs.Items.Add(song);
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSongTitle.Text))
            {
                MessageBox.Show("Назва пісні не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSongArtist.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть виконавця зі списку праворуч!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Artist selectedArtist = (Artist)cmbSongArtist.SelectedItem;

            Song newSong = new Song();
            newSong.Title = txtSongTitle.Text.Trim();
            newSong.Duration = txtSongDuration.Text.Trim();
            newSong.Language = txtSongLanguage.Text.Trim();
            newSong.ArtistId = selectedArtist.Id;

            dataManager.Songs.Add(newSong);
            UpdateSongList();

            txtSongTitle.Clear();
            txtSongDuration.Clear();
            txtSongLanguage.Clear();
            cmbSongArtist.SelectedIndex = -1;

            cmbFilterArtist.SelectedIndex = 0;

            UpdateSongListsForDisks();
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem != null)
            {
                Song selectedSong = (Song)listBoxSongs.SelectedItem;

                txtSongTitle.Text = selectedSong.Title;
                txtSongDuration.Text = selectedSong.Duration;
                txtSongLanguage.Text = selectedSong.Language;

                foreach (var item in cmbSongArtist.Items)
                {
                    if (item is Artist artist && artist.Id == selectedSong.ArtistId)
                    {
                        cmbSongArtist.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem != null)
            {
                Song selectedSong = (Song)listBoxSongs.SelectedItem;

                DialogResult result = MessageBox.Show($"Ви дійсно хочете видалити пісню '{selectedSong.Title}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataManager.Songs.Remove(selectedSong);
                    UpdateSongList();

                    txtSongTitle.Clear();
                    txtSongDuration.Clear();
                    txtSongLanguage.Clear();
                    cmbSongArtist.SelectedIndex = -1;

                    cmbFilterArtist.SelectedIndex = 0;
                    UpdateSongListsForDisks();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть пісню для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditSong_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem != null)
            {
                if (string.IsNullOrWhiteSpace(txtSongTitle.Text))
                {
                    MessageBox.Show("Назва пісні не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbSongArtist.SelectedItem == null)
                {
                    MessageBox.Show("Будь ласка, оберіть виконавця зі списку праворуч!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Song selectedSong = (Song)listBoxSongs.SelectedItem;
                Artist selectedArtist = (Artist)cmbSongArtist.SelectedItem;

                selectedSong.Title = txtSongTitle.Text.Trim();
                selectedSong.Duration = txtSongDuration.Text.Trim();
                selectedSong.Language = txtSongLanguage.Text.Trim();
                selectedSong.ArtistId = selectedArtist.Id;

                UpdateSongList();

                txtSongTitle.Clear();
                txtSongDuration.Clear();
                txtSongLanguage.Clear();
                cmbSongArtist.SelectedIndex = -1;

                cmbFilterArtist.SelectedIndex = 0;

                UpdateSongListsForDisks();

                MessageBox.Show("Дані пісні успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть пісню для редагування.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbFilterArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSongs.Items.Clear();

            if (cmbFilterArtist.SelectedItem == null) return;

            if (cmbFilterArtist.SelectedItem is string && cmbFilterArtist.SelectedItem.ToString() == "Всі виконавці")
            {
                foreach (var song in dataManager.Songs)
                {
                    listBoxSongs.Items.Add(song);
                }
            }
            else if (cmbFilterArtist.SelectedItem is Artist selectedArtist)
            {
                foreach (var song in dataManager.Songs)
                {
                    if (song.ArtistId == selectedArtist.Id)
                    {
                        listBoxSongs.Items.Add(song);
                    }
                }
            }
        }

        private void UpdateSongListsForDisks()
        {
            checkedListBoxSongs.Items.Clear();
            cmbFilterSong.Items.Clear();

            cmbFilterSong.Items.Add("Всі пісні");

            foreach (var song in dataManager.Songs)
            {
                checkedListBoxSongs.Items.Add(song);
                cmbFilterSong.Items.Add(song);
            }

            if (cmbFilterSong.Items.Count > 0)
            {
                cmbFilterSong.SelectedIndex = 0;
            }
        }

        private void UpdateDiskList()
        {
            listBoxDisks.Items.Clear();
            foreach (var disk in dataManager.Disks)
            {
                listBoxDisks.Items.Add(disk);
            }
        }

        private void btnAddDisk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiskTitle.Text))
            {
                MessageBox.Show("Назва диску не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Disk newDisk = new Disk();
            newDisk.Title = txtDiskTitle.Text.Trim();
            newDisk.Label = txtDiskLabel.Text.Trim();

            if (int.TryParse(txtDiskYear.Text.Trim(), out int year))
            {
                newDisk.ReleaseYear = year;
            }

            foreach (var item in checkedListBoxSongs.CheckedItems)
            {
                if (item is Song checkedSong)
                {
                    newDisk.SongIds.Add(checkedSong.Id);
                }
            }

            dataManager.Disks.Add(newDisk);
            UpdateDiskList();

            txtDiskTitle.Clear();
            txtDiskYear.Clear();
            txtDiskLabel.Clear();

            cmbFilterSong.SelectedIndex = 0;

            for (int i = 0; i < checkedListBoxSongs.Items.Count; i++)
            {
                checkedListBoxSongs.SetItemChecked(i, false);
            }
        }

        private void listBoxDisks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDisks.SelectedItem != null)
            {
                Disk selectedDisk = (Disk)listBoxDisks.SelectedItem;

                txtDiskTitle.Text = selectedDisk.Title;
                txtDiskLabel.Text = selectedDisk.Label;
                txtDiskYear.Text = selectedDisk.ReleaseYear == 0 ? "" : selectedDisk.ReleaseYear.ToString();

                for (int i = 0; i < checkedListBoxSongs.Items.Count; i++)
                {
                    checkedListBoxSongs.SetItemChecked(i, false);
                }

                for (int i = 0; i < checkedListBoxSongs.Items.Count; i++)
                {
                    if (checkedListBoxSongs.Items[i] is Song song)
                    {
                        if (selectedDisk.SongIds.Contains(song.Id))
                        {
                            checkedListBoxSongs.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void btnDeleteDisk_Click(object sender, EventArgs e)
        {
            if (listBoxDisks.SelectedItem != null)
            {
                Disk selectedDisk = (Disk)listBoxDisks.SelectedItem;

                DialogResult result = MessageBox.Show($"Ви дійсно хочете видалити диск '{selectedDisk.Title}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataManager.Disks.Remove(selectedDisk);
                    UpdateDiskList();

                    txtDiskTitle.Clear();
                    txtDiskYear.Clear();
                    txtDiskLabel.Clear();

                    cmbFilterSong.SelectedIndex = 0;

                    for (int i = 0; i < checkedListBoxSongs.Items.Count; i++)
                    {
                        checkedListBoxSongs.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть диск для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditDisk_Click(object sender, EventArgs e)
        {
            if (listBoxDisks.SelectedItem != null)
            {
                if (string.IsNullOrWhiteSpace(txtDiskTitle.Text))
                {
                    MessageBox.Show("Назва диску не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Disk selectedDisk = (Disk)listBoxDisks.SelectedItem;

                selectedDisk.Title = txtDiskTitle.Text.Trim();
                selectedDisk.Label = txtDiskLabel.Text.Trim();
                if (int.TryParse(txtDiskYear.Text.Trim(), out int year))
                {
                    selectedDisk.ReleaseYear = year;
                }

                selectedDisk.SongIds.Clear();
                foreach (var item in checkedListBoxSongs.CheckedItems)
                {
                    if (item is Song checkedSong)
                    {
                        selectedDisk.SongIds.Add(checkedSong.Id);
                    }
                }

                UpdateDiskList();

                txtDiskTitle.Clear();
                txtDiskYear.Clear();
                txtDiskLabel.Clear();
                for (int i = 0; i < checkedListBoxSongs.Items.Count; i++)
                {
                    checkedListBoxSongs.SetItemChecked(i, false);
                }

                cmbFilterSong.SelectedIndex = 0;

                MessageBox.Show("Дані диску успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть диск для редагування.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbFilterSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDisks.Items.Clear();

            if (cmbFilterSong.SelectedItem == null) return;

            if (cmbFilterSong.SelectedItem is string && cmbFilterSong.SelectedItem.ToString() == "Всі пісні")
            {
                foreach (var disk in dataManager.Disks)
                {
                    listBoxDisks.Items.Add(disk);
                }
            }
            else if (cmbFilterSong.SelectedItem is Song selectedSong)
            {
                foreach (var disk in dataManager.Disks)
                {
                    if (disk.SongIds.Contains(selectedSong.Id))
                    {
                        listBoxDisks.Items.Add(disk);
                    }
                }
            }
        }
    }
}