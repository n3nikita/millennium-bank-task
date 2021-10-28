using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace millennium.Models
{
    public class Person
    {
        [Display(Name = "Nickname", ResourceType = typeof(MyResources.Resource))]
        [Required(ErrorMessageResourceType = typeof(MyResources.Resource), ErrorMessageResourceName = "NicknameRequired")]
        [MaxLength(30, ErrorMessageResourceType = typeof(MyResources.Resource), ErrorMessageResourceName = "NicknameMaxLength")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessageResourceType = typeof(MyResources.Resource), ErrorMessageResourceName = "NicknameOnlyLetters")]
        public string Nickname {  get; set; }

        [Display(Name = "Email", ResourceType = typeof(MyResources.Resource))]
        [Required(ErrorMessageResourceType = typeof(MyResources.Resource), ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(MyResources.Resource), ErrorMessageResourceName = "EmailError")]
        public string Email { get; set; }
    }
}