using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TVProject.Domain.Entities.User
{
    public class UDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Username")]
        [StringLength(50,MinimumLength = 5,ErrorMessage ="Username cannot be shorter thann 5 characters")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(50,MinimumLength = 8,ErrorMessage ="Password Cannot be shorter than 8 characters")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [StringLength(30)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }
        
        [StringLength(30)]
        public string LasIp { get; set; }
    }
}
