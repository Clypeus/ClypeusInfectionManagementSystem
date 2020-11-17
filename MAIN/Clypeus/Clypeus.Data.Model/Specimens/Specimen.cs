using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Specimens
{
    public class Specimen
    {
        public long Id { get; set; }
        public string LabSpecimenCode{ get; set; }
        public string LabEpisodeCode { get; set; }
        public string LabPatientIdentifier { get; set; }
        public string LocalPatientIdentifier { get; set; }
        public string LabPatientCode { get; set; }
        public string LabPatientSurname { get; set; }
        public string LabPatientDateOfBirth { get; set; }
        public DateTime? Requested { get; set; }
        public bool Authorised { get; set; }
        public DateTime Inserted { get; set; }

        public virtual ICollection<SpecimenSensitivity> SpecimenSensitivity { get; set; }

    }
}
