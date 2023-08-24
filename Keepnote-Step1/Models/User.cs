using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Keepnote_Step1.Models
{
    [Table("tblUsers")]
    public class User
        // Data Annotations
    {   [Key]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Column("SecondName")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime Dob { get; set; }
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password")]
        public string ReTypePassword { get; set; }

    }
}
