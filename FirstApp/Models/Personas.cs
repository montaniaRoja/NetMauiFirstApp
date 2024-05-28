using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FirstApp.Models
{
    [Table ("Personas")]
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }=string.Empty ;
        [MaxLength(100)]
        public string LastName { get; set; }=string.Empty ;

        public DateTime FechaNac { get; set; }

        [Unique]
        public string Telefono { get; set; } = string.Empty;

        public Personas() { }
        


    }
}
