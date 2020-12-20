using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clypeus.DataTransfer.ViewModels.People
{
    public class MedicalPractitonerViewModel:PersonDataViewModel
    {
        [Required]
        public int PracticeId { get; set; }
    }
}
