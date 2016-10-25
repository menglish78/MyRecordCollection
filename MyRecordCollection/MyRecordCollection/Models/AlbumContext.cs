using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyRecordCollection.Models
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Categories { get; set; }
    }
}