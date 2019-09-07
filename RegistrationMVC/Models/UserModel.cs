using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationMVC.Models
{
    public class UserModel
    {
        public UserModel() { }

        public UserModel(int id, string name, string emailid, string password, string mobilenumber, string url, string gender, int sid)
        {
            this.UserId = id;
            this.UserName = name;
            this.EmailId = emailid;
            this.Password = password;
            this.MobileNumber = mobilenumber;
            this.UserImageUrl = url;
            this.Gender = gender;
            this.StateId = new StateModel() { StateId = sid };
        }
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "enter UserName")]
        [Display(Name = "UserName*")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "enter emailid")]
        [Display(Name = "emailid*")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "enter password")]
        [Display(Name = "password*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "confirm password")]
        [Display(Name = "password*")]
        [Compare("Password", ErrorMessage = "doesnt match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "enter mobile number")]
        [Display(Name = "mobilenumber*")]
        public string MobileNumber { get; set; }

        public string UserImageUrl { get; set; }
        [Required]
        public string Gender { get; set; }

        public StateModel StateId { get; set; }

        public List<StateModel> GetStates
        {
            get
            {
                return new List<StateModel>()
                {
                    new StateModel()
                    {
                        StateId=1,
                        StateName="GJ"
                    },
                    new StateModel()
                    {
                        StateId=2,
                        StateName="NYC"
                    }
                };
            }
        }
    }
}