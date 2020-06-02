using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordLabelDB.Models
{
    class RecordLabelContext : DbContext
    {
        public RecordLabelContext() : base("AppContext")
        {

        }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<StudioAlbum> StudioAlbums { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

    }
}
