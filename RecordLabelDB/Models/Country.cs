using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordLabelDB.Models
{
    class Country
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Country name is required!")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [DisplayName("Country name")]
        public string Name { get; set; }

        public virtual List<Artist> Artists { get; set; } // one country to many artists
    }
}
