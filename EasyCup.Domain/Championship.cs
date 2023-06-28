using EasyCup.Domain.Base;
using EasyCup.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyCup.Domain
{
    public class Championship : AutoIncrementBaseDomain
    {
        public string Name { get; set; }

        [ForeignKey("FootballSchoolUnit")]
        public int FootballSchoolUnitID { get; set; }

        public FootballSchoolUnit FootballSchoolUnit { get; set; }

        public DateTime StartRegistration { get; set; }

        public DateTime EndRegistration { get; set; }

        public DateTime StartChampionship { get; set; }

        public DateTime? CancelledChampionship { get; set; }

        public DateTime EndChampionship { get; set; }

        public DateTime StartPublicity { get; set; }

        public EnumChampionshipState ChampionshipState
        {
            get
            {
                if(DateTime.Now.Date > EndChampionship)
                {
                    return EnumChampionshipState.Concluded;
                }
                else if (DateTime.Now.Date > StartChampionship)
                {
                    return EnumChampionshipState.InProgress;
                }
                else if (CancelledChampionship != null)
                {
                    return EnumChampionshipState.Cancelled;
                }
                else 
                {
                    return EnumChampionshipState.Planned;
                }
            }
        }

        public List<ChampionshipTeamPlayer> ChampionshipTeamPlayer { get; set; }

        public Team? FirstPlace { get; set; }

        public Team? SecondPlace { get; set; }

        public Team? ThirdPlace { get; set; }
    }
}