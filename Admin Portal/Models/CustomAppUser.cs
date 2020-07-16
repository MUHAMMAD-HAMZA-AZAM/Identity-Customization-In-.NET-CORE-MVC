using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_Portal.Models
{
    public class CustomAppUser : IdentityUser
    {

        //At The Time Of Scaffolding , I've Created AdminPortalContext

        // For the Additional Properties I Have Created CustomeAppUser

        [Required(ErrorMessage ="* Please Enter Your First Name ")]
        [Display(Name =" First Name ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Please Enter Your Last Name ")]
        [Display(Name = " Last Name ")]
        public string LastName { get; set; }


    }
}
