using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Clypeus.DataTransfer.ViewModels.Enquiry
{
    public class CreateEnquiryModel
    {
        public DateTime? EnquiryDateAndTime { get; set; }

        [Required]
        [StringLength(35, ErrorMessage = "Familyname is too long.")]
        public string Surname {get;set;}

        [Required]
        [StringLength(35, ErrorMessage = "Forename is too long.")]
        public string Forename { get; set; }

        [Required]
        [StringLength(125, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }

        public int LocationId { get; set; }

        [Required]
        [StringLength(125, ErrorMessage = "Location is too long.")]
        public string LocationDescription { get; set; }


    }
}
