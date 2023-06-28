using EasyCup.Domain.Base;
using EasyCup.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyCup.Domain
{
    public class Match: AutoIncrementBaseDomain
    {
        [ForeignKey("TeamA")]
        public int TeamAID { get; set; }

        public Team TeamA { get; set; }

        [ForeignKey("TeamB")]
        public int TeamBID { get; set; }

        public Team TeamB { get; set; }

        public DateTime Date { get; set; }

        public Championship Championship { get; set; }

        public ushort TeamAResult { get; set; }

        public ushort TeamBResult { get; set; }

        public EnumMatchState MatchState
        {
            get
            {
                if (DateTime.Now.Date > Date)
                {
                    return EnumMatchState.Concluded;
                }
                else
                {
                    return EnumMatchState.WillOccur;
                }
            }
        }

    }
}