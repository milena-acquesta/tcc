using EasyCup.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyCup.Domain
{
    public class Team : AutoIncrementBaseDomain
    {
        public string Name { get; set; }

        public List<ChampionshipTeamPlayer> ChampionshipTeamPlayer { get; set; }

        //public List<Match> Matches { get; set; }
    }
}