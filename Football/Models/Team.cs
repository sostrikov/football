using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Football.Models
{
    public class Team
    {
        public int Id { get; set; }
        [DisplayName("Название команды")]
        public string Name { get; set; }
        [DisplayName("Тренер")]
        public string Coach { get; set; }

        public ICollection<Player> Players { get; set; }
        public Team()
        {
            Players = new List<Player>();
        }
    }
}