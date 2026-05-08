using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDirectory
{
    /// <summary>
    /// Клас, що представляє музичну композицію.
    /// Зв'язаний з виконавцем через властивість ArtistId.
    /// </summary>
    public class Song
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Duration { get; set; } // Формат "ХХ:ХХ"
        public string Language { get; set; }

        // Посилання на виконавця
        public Guid ArtistId { get; set; }

        public override string ToString() => Title;
    }
}
