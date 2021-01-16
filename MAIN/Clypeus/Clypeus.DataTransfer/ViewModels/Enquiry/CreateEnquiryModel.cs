using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Clypeus.DataTransfer.ViewModels.Enquiry
{
    public class EnquiryForm
    {
        public DateTime? EnquiryDateAndTime { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Postcode { get; set; }


        [Display(Name = "Enquirer Title")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Enquirer Surname")]
        [Required]
        [StringLength(35, ErrorMessage = "Surname is too long.")]
        public string Surname {get;set;}

        [Display(Name = "Enquirer Forename")]
        [Required]
        [StringLength(35, ErrorMessage = "Forename is too long.")]
        public string Forename { get; set; }

        [StringLength(15, ErrorMessage = "Telephone is too long.")]
        public string TelephoneNumber { get; set; }

        [StringLength(15, ErrorMessage = "Mobile is too long.")]
        public string MobileNumber { get; set; }

        [Display(Name = "Enquirer Id")]
        [Required]
        public string EnquiryId { get; set; }

        [Display(Name = "Relationship Id")]
        [Required]
        public string RelationshipId { get; set; }

        [Display(Name = "Location Description")]
        [Required]
        [StringLength(125, ErrorMessage = "Location is too long.")]
        public string LocationDescription { get; set; }

        [Display(Name = "Enquiry Subject")]
        [Required]
        [StringLength(125, ErrorMessage = "Subject is too long.")]
        public string EnquirySubject { get; set; }

        [Display(Name = "Enquiry Details")]
        [Required]
        [StringLength(500, ErrorMessage = "Body is too long.")]
        public string EnquiryBody { get; set; }





    }
}
