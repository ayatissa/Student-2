using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class _Gender
    {

        public enum Gender
        {

            [Display(Name = "Male")]
            Male = 1,
            [Display(Name = "Female")]
            Femalen = 2
        }


    }
}
