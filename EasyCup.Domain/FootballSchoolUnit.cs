using EasyCup.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyCup.Domain
{
    public class FootballSchoolUnit: AutoIncrementBaseDomain
    {
        public string Name { get; set; }

        public string CEP { get; set; }

        public string PublicPlace { get; set; }

        public string Number { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        [ForeignKey("FootballSchool")]
        public int FootballSchoolID { get; set; }

        public FootballSchool FootballSchool { get; set; }


        [ForeignKey("CupManager")]
        public int CupManagerID { get; set; }

        public CupManager CupManager { get; set; }       
    }
}