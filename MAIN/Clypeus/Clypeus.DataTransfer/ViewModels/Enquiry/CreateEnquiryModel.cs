using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Clypeus.DataTransfer.ViewModels.Enquiry
{
    public class CreateEnquiryFormModel
    {
        public DateTime? EnquiryDateAndTime { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Postcode { get; set; }


        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(35, ErrorMessage = "Surname is too long.")]
        public string Surname {get;set;}

        [Required]
        [StringLength(35, ErrorMessage = "Forename is too long.")]
        public string Forename { get; set; }

        [Required]
        [StringLength(125, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }

        [StringLength(15, ErrorMessage = "Telephone is too long.")]
        public string TelephoneNumber { get; set; }

        [StringLength(15, ErrorMessage = "Mobile is too long.")]
        public string MobileNumber { get; set; }

        [Required]
        public string EnquiryId { get; set; }

        [Required]
        public string RelationshipId { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        [StringLength(125, ErrorMessage = "Location is too long.")]
        public string LocationDescription { get; set; }





    }
}
