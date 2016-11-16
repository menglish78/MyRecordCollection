using MyRecordCollection.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyRecordCollection
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public AlbumContext()
        {
            //Initialize database. Drop if Model changes.
            Database.SetInitializer<AlbumContext>(new DropCreateDatabaseIfModelChanges<AlbumContext>());
        }
    }
}

