using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGames.Data.CodeFirst.Entities
{
    public class Games
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Genre { get; set; }
        public string Developer { get; set; }
        public string Platform { get; set; }
        public Nullable<int> YearLaunch { get; set; }
    }
}
