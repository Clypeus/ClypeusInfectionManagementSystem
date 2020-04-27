using Clypeus.Data.Model.Geography;
using Clypeus.Data.Model.Organisations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.People
{
    public class MedicalPractioner
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string PrinciplePracticeId { get; set; }
        public PrimaryCarePractice PrinciplePractice { get; set; }
    }
}
