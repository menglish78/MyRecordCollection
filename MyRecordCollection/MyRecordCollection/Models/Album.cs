﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyRecordCollection.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        [Required(ErrorMessage = "Please enter an album title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter an artist.")]
        public string Artist { get; set; }
        [Required(ErrorMessage = "Please enter a year.")]
        [Range (1900, 3000, ErrorMessage = "Please enter a valid year.")]
        public int Year { get; set; }
        public string Label { get; set; }
        public string Format { get; set; }
    }
}