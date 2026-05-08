using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class Form1 : Form
    {
        // Створюємо наш головний менеджер бази даних
        private DataManager dataManager = new DataManager();

        public Form1()
        {
            InitializeComponent();

            // Жорстко прив'язуємо події завантаження та збереження в коді
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        // Цей метод спрацює автоматично під час запуску програми
        private void Form1_Load(object sender, EventArgs e)
        {
            // Завантажуємо збережені файли (якщо вони є)
            dataManager.LoadData();

            // Виводимо виконавців на екран
            UpdateArtistList();
        }

        // Цей метод спрацює під час закриття вікна хрестиком
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Автоматично зберігаємо всі дані у JSON-файли
            dataManager.SaveData();
        }

        // Допоміжний метод для оновлення списку виконавців на екрані
        private void UpdateArtistList()
        {
            listBoxArtists.Items.Clear(); // Очищаємо старі дані візуально

            foreach (var artist in dataManager.Artists)
            {
                listBoxArtists.Items.Add(artist); // Додаємо актуальні дані з пам'яті
            }
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
            newArtist.Country = txtCountry.Text.Trim(); // Зберігаємо країну
            newArtist.Genre = txtGenre.Text.Trim();     // Зберігаємо жанр

            // Рік - це число, тому текст треба перетворити в int
            if (int.TryParse(txtYear.Text.Trim(), out int year))
            {
                newArtist.FoundationYear = year;
            }

            dataManager.Artists.Add(newArtist);
            UpdateArtistList();

            // Очищаємо всі поля після додавання
            txtArtistName.Clear();
            txtCountry.Clear();
            txtYear.Clear();
            txtGenre.Clear();
        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи виділив користувач когось у списку
            if (listBoxArtists.SelectedItem != null)
            {
                // Отримуємо виділеного виконавця
                Artist selectedArtist = (Artist)listBoxArtists.SelectedItem;

                // Запитуємо підтвердження (як вимагається в методичці )
                DialogResult result = MessageBox.Show($"Ви дійсно хочете видалити виконавця '{selectedArtist.Name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Видаляємо зі списку
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
                txtCountry.Text = selectedArtist.Country; // Виводимо країну
                txtGenre.Text = selectedArtist.Genre;     // Виводимо жанр

                // Рік (число) перетворюємо назад у текст
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

                // Оновлюємо всі властивості
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
                // Той самий важливий захист від помилок
                MessageBox.Show("Будь ласка, оберіть виконавця для редагування.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}