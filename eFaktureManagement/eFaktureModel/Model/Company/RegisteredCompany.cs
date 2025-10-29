

namespace eFaktureModel.Model.Company
{

    public partial class RegisteredCompany { 


        public string BugetCompanyNumber { get; set; }


        public string RegistrationCode { get; set; }

        public string VatRegistrationCode { get; set; }

        public string Name { get; set; }

        public DateTime? RegistrationDate { get; set; }


        public DateTime? DeletionDate { get; set; }

    }
}
