﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class SearchResultsViewModel
    {
        public SearchResultsViewModel(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}