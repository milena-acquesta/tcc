using EasyCup.Domain.Base;

namespace EasyCup.Domain
{
    public class FootballSchool: AutoIncrementBaseDomain
    {
        public string Name { get; set; }

        public List<FootballSchoolUnit> FootballSchoolUnits { get; set; }
    }
}