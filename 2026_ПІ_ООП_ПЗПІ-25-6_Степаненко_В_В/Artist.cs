using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDirectory
{
    /// <summary>
    /// Клас, що представляє музичний гурт або виконавця.
    /// Містить основну біографічну інформацію.
    /// </summary>
    public class Artist
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Country { get; set; }
        public int FoundationYear { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }

        // Перевизначення ToString для зручного відображення у ListBox/ComboBox
        public override string ToString() => Name;
    }
}