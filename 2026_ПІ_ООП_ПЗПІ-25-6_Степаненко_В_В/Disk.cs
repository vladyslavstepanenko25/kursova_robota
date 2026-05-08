using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDirectory
{
    /// <summary>
    /// Клас, що представляє музичний альбом (диск).
    /// Містить колекцію ідентифікаторів пісень, які входять до альбому.
    /// </summary>
    public class Disk
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Label { get; set; }

        // Список ідентифікаторів пісень на цьому диску
        public List<Guid> SongIds { get; set; } = new List<Guid>();

        public override string ToString() => Title;
    }
}