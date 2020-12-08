﻿using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabaseProject.Models
{
    public class MovieModel
    {
        public MovieModel()
        {

        }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Poster { get; set; }
        }
}