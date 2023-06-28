using EasyCup.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyCup.Domain
{
    public class CupManager : AutoIncrementBaseDomain
    {
        public string Name { get; set; }

        [ForeignKey("FootballSchoolUnit")]
        public int FootballSchoolUnitID { get; set; }

        public FootballSchoolUnit FootballSchoolUnit { get; set; }
    }
}