﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRecordCollection.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Label { get; set; }
        public string Format { get; set; }
    }
}