using EasyCup.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyCup.Domain
{
    public class Player : AutoIncrementBaseDomain
    {
        public string Name { get; set; }

        public string Nickname { get; set; }

        public DateTime BirthDate { get; set; }

        public ushort Age { get { return Convert.ToUInt16(Math.Truncate(DateTime.Now.Date.Subtract(BirthDate).Days / 365M)); } }

        public string WhatsApp { get; set; }



        public List<ChampionshipTeamPlayer> ChampionshipTeamPlayer { get; set; }
    }
}