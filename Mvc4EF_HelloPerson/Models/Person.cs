using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc4EF_HelloPerson.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName ("First Name"), Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name"), Required]
        public string LastName { get; set; }
        [DisplayName("Middle Name"), Required]
        public string MiddleName { get; set; }
    }
}
