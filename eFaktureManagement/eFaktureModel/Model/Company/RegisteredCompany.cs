

using System.ComponentModel.DataAnnotations;

namespace eFaktureModel.Model.Company
{

    public partial class RegisteredCompany {


        [Key]
        public int Id   { get; set; }


        // Useful to connect with the id in eFakture system
        public int? eFaktureCompanyId { get; set; }


        public string BugetCompanyNumber { get; set; }

        public string RegistrationCode { get; set; }

        public string VatRegistrationCode { get; set; }

        public string Name { get; set; }
        public int? CountryId { get; set; }

        

        public DateTime? RegistrationDate { get; set; }

        public DateTime? DeletionDate { get; set; }


        // efakture data might be usefull
        public bool? IsPrivateCompany { get; set; }


    }
}
