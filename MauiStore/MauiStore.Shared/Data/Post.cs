﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStore.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string ShortDesc { get; set; }
        public string Content { get; set; }
        public string PostedDate { get; set; }
    }
}
