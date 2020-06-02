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
    class Track
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [DisplayName("Track name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Length is required!")]
        [Column(TypeName = "FLOAT")]
        [DisplayName("Length")]
        public float Length { get; set; }

        public int StudioAlbumId { get; set; }

   
        [ForeignKey("StudioAlbumId")]
        public virtual StudioAlbum StudioAlbum { get; set; } // foreign key of studioalbum

        
    }
}
