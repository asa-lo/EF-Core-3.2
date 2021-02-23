using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace skivor.Models
{
    public class Record
    {
        [Key]
        public int CdId { get; set; }
        public string CdName { get; set; }

        public int ArtistId { get; set; }
        public string ArtistName { get; set; }

        public Artist Artist { get; set; }
    }
}
