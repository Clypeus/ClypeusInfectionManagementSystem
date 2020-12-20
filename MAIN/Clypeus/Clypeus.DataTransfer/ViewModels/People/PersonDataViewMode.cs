using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clypeus.DataTransfer.ViewModels.People
{
    public class PersonDataViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "The code is too long.")]
        public string Code { get; set; }


        [Required]
        [StringLength(35, ErrorMessage = "The name is too long.")]
        public string Name { get; set; }

    }
}
