using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Exp { get; set; }
    }
}

