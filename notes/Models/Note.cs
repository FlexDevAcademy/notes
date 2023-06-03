﻿
using System.ComponentModel.DataAnnotations;

namespace notes.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; } 

        public DateTime Created {get; set; }

        public DateTime DateOfEdition { get; set; }
    }
}
