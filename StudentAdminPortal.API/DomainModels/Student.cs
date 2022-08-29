using StudentAdminPortal.API.DataModels;
using System.ComponentModel.DataAnnotations;

namespace StudentAdminPortal.API.DomainModels
{
    public class Student
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public long Mobile { get; set; }
        public String? ProfileImageURL { get; set; }
        public Guid GenderID { get; set; }
   
        public Gender Gender { get; set; }
        public Address Address { get; set; }


    }
}
