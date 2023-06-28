using EasyCup.Domain.Base;
using EasyCup.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyCup.Domain
{
    public class ChampionshipTeamPlayer : BaseDomain
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Championship")]
        public int ChampionshipID { get; set; }

        public Championship Championship { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Team")]
        public int TeamID { get; set; }

        public Team Team { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("Player")]
        public int PlayerID { get; set; }

        public Player Player { get; set; }
    }
}