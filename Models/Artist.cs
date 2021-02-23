using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace skivor.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        
        public List<Record> Records { get; set; }

        public Artist()
        { 
        }
    }
}
