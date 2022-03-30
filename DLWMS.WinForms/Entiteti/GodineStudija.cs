using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.WinForms.Entiteti
{
    [Table("GodineStudija")]
    public class GodineStudija
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public byte[] Raspored { get; set; }
        public override string ToString()
        {
            return Opis; 
        }
    }
}
