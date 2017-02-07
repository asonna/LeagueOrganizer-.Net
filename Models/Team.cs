using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOrganizer.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string CaptainName { get; set; }
        public int DivisionId { get; set; }
        public virtual Division Division { get; set; }
    }
}
