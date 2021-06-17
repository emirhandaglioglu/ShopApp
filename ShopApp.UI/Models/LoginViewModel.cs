using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        [DisplayName("User Name")]
        [MaxLength(30, ErrorMessage = "The User Name cannot be longer than 30 characters.")]
        public string UserName { get; set; }

        [DisplayName("First Name")]
        //[Required(ErrorMessage = "* Bu alan gereklidir!")]
        [MaxLength(250, ErrorMessage = "The First Name cannot be longer than 250 characters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "* This field is required!")]
        [DisplayName("Last Name")]
        [MaxLength(250, ErrorMessage = "The Last Name cannot be longer than 250 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* This field is required!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "* E-mail is not valid!")]
        [DisplayName("Email Address")]
        public string Email { get; set; }
       // [Required(ErrorMessage = "* This field is required!")]
        [MinLength(6, ErrorMessage = "The Password cannot be min than 6 characters.")]
        public string Password { get; set; }
        public bool? IsActive { get; set; }


        [Required(ErrorMessage = "* This field is required!")]
        [DisplayName("User Role")]
        public int UserRoleId { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
        public string RoleName { get; set; }
    }
}