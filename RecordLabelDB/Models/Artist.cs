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
    /// <summary>
    /// Klasa artysty muzycznego
    /// </summary>
    class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [DisplayName("Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required!")]
        [Column(TypeName = "DATE")]
        [DisplayName("Date of birth")]
        public DateTime Birthdate { get; set; }

        
        public int CountryId { get; set; }

        public virtual List<StudioAlbum> StudioAlbums { get; set; } // one artist to many albums

        [ForeignKey("CountryId")] // foreign key
        public virtual Country Country { get; set; }




    }
}
