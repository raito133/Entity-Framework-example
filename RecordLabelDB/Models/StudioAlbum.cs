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
    class StudioAlbum
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        [DisplayName("Album name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is required!")]
        [Column(TypeName = "DATE")]
        [DisplayName("Release date")]
        public DateTime ReleaseDate { get; set; }

        public int GenreId { get; set; }
        
        public int ArtistId { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; } // foreign key of genre

        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; } // foreign key of artist

        public virtual List<Track> Tracks { get; set; } // one album to many tracks
        
    }
}
