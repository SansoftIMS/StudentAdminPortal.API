using System.ComponentModel.DataAnnotations;

namespace StudentAdminPortal.API.DomainModels
{
    public class UpdateStudentRequest
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string DateofBirth { get; set; }
        public String Email { get; set; }
        public long Mobile { get; set; }
        public Guid GenderID { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }


    }
}
