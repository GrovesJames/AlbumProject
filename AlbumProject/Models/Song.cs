﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumProject.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }

        public Album Album { get; set; }
        public int AlbumId { get; set; }

        public Song()
        {

        }
    }
}
