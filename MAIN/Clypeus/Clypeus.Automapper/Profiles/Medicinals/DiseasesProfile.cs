using Clypeus.Data.Model.Medicinals;
using Clypeus.DataTransfer.ViewModels.Reference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Automapper.Profiles.Medicinals
{
    public class DiseasesProfile : AutoMapper.Profile
    {
        public DiseasesProfile()
        {
            CreateMap<NotifiableDisease, NotifiableDiseasesViewModel>()
                .ForMember(dest => dest.Code, source => source.MapFrom(f => f.Code))
                .ForMember(dest => dest.Description, source => source.MapFrom(f => f.Description));
        }
    }
}
