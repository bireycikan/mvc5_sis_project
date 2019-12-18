using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Entities.Entities
{
    public class UniversityType
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public ICollection<University> Universities { get; set; }
    }
}
