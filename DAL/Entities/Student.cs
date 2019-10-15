using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Entities._Gender;

namespace DAL
{
    public class Student
    {
        public int StudentId { get; set; }

        //[Display(Name = "Name")]
        [Required(ErrorMessage = "First Names is required.")]
        [StringLength (20 , MinimumLength =2,ErrorMessage ="Must at least 2 character long  ")]
        public string F_Name { get; set; }

        [Required(ErrorMessage = " Middle Names is required.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must at least 2 character long  ")]
        public string M_Name { get; set; }

        [Required(ErrorMessage = " Last Names is required.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must at least 2 character long  ")]
        public string L_Name { get; set; }
        
        [Range(5, 80)]
        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Is Active")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }


        [Display(Name = "Creation Data")]
        public DateTime CreationData
        {
            get { return DateTime.Now; }
        }



        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Cite is Required")]
        public string Cite { get; set; }


        [Required(ErrorMessage = "Cite is Required")]
        public string Country { get; set; }

        [Display(Name = " Zip Code")]
        [Required(ErrorMessage = "Zip is Required")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string ZipCode { get; set; }


        
        public Gender gender { get; set; }

        


    }
}


//public enum Gender
//{

//    [Display(Name = "Male")]
//    Male = 1,
//    [Display(Name = "Female")]
//    Femalen = 2
//}