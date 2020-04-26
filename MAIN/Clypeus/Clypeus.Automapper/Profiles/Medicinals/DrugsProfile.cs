using Clypeus.Data.Model.Medicinals;
using Clypeus.DataTransfer.ViewModels.Reference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Automapper.Profiles.Medicinals
{
    public class DrugsProfile :AutoMapper.Profile
    {
        public DrugsProfile()
        {
            CreateMap<Drugs, DrugsViewModel>()
                .ForMember(dest => dest.Code, source => source.MapFrom(f => f.Code))
                .ForMember(dest => dest.AtcCode, source => source.MapFrom(f => f.Atc))
                .ForMember(dest => dest.Description, source => source.MapFrom(f => f.Description))
                .ForMember(dest => dest.DrugGroup, source => source.MapFrom(f => f.PrincipleDrugGroup != null ? f.PrincipleDrugGroup.Description : string.Empty));


        }
    }
}
