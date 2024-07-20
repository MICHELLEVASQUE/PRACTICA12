﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Todo5061893.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public string name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}
