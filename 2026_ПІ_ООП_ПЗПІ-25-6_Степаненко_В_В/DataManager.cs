using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace MusicDirectory
{
    /// <summary>
    /// Клас для керування всіма даними програми (колекціями).
    /// Забезпечує збереження та завантаження даних з файлів.
    /// </summary>
    public class DataManager
    {
        // Наші три головні списки
        public List<Artist> Artists { get; set; } = new List<Artist>();
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Disk> Disks { get; set; } = new List<Disk>();

        // Шляхи до файлів збереження
        private string artistsFile = "artists.json";
        private string songsFile = "songs.json";
        private string disksFile = "disks.json";

        /// <summary>
        /// Зберігає всі колекції у відповідні файли у форматі JSON.
        /// </summary>
        public void SaveData()
        {
            File.WriteAllText(artistsFile, JsonSerializer.Serialize(Artists));
            File.WriteAllText(songsFile, JsonSerializer.Serialize(Songs));
            File.WriteAllText(disksFile, JsonSerializer.Serialize(Disks));
        }

        /// <summary>
        /// Завантажує дані з файлів у списки (якщо файли існують).
        /// </summary>
        public void LoadData()
        {
            if (File.Exists(artistsFile))
                Artists = JsonSerializer.Deserialize<List<Artist>>(File.ReadAllText(artistsFile));

            if (File.Exists(songsFile))
                Songs = JsonSerializer.Deserialize<List<Song>>(File.ReadAllText(songsFile));

            if (File.Exists(disksFile))
                Disks = JsonSerializer.Deserialize<List<Disk>>(File.ReadAllText(disksFile));
        }
    }
}
