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
    class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Genre name is required!")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [DisplayName("Genre name")]
        public string Name { get; set; }

        public virtual List<StudioAlbum> StudioAlbum { get; set; } // one track to many albums
    }
}
