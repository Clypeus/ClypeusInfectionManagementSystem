using Clypeus.Data.Model.Principles;
using Clypeus.DataTransfer.ViewModels.Enquiry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Automapper.Profiles.Principle
{
    public class EnquiryProfile : AutoMapper.Profile
    {

        public EnquiryProfile()
        {
            CreateMap<Enquiry, EnquiryForm>()

                .ForMember(dest => dest.Id, source => source.MapFrom(f => f.Id))
                .ForMember(dest => dest.AddressLine1, source => source.MapFrom(f => f.HouseName))
                .ForMember(dest => dest.AddressLine2, source => source.MapFrom(f => f.Street))
                .ForMember(dest => dest.AddressLine3, source => source.MapFrom(f => f.Town))
                .ForMember(dest => dest.AddressLine4, source => source.MapFrom(f => f.Area))
                .ForMember(dest => dest.Postcode, source => source.MapFrom(f => f.Street))
                .ForMember(dest => dest.EnquirySubject, source => source.MapFrom(f => f.SubjectTitle))
                .ForMember(dest => dest.EnquiryBody, source => source.MapFrom(f => f.SubjectDescription))
                .ForMember(dest => dest.LocationDescription, source => source.MapFrom(f => f.Location))
                .ForMember(dest => dest.Forename, source => source.MapFrom(f => f.FirstName))
                .ForMember(dest => dest.Surname, source => source.MapFrom(f => f.Surname))
                .ForMember(dest => dest.Title, source => source.MapFrom(f => f.Title))
                .ForMember(dest => dest.MobileNumber, source => source.MapFrom(f => f.Mobile))
                .ForMember(dest => dest.TelephoneNumber, source => source.MapFrom(f => f.Telephone))
                .ForMember(dest => dest.RelationshipId, source => source.MapFrom(f => f.RelationshipTypeId))
                .ForMember(dest => dest.EnquiryId, source => source.MapFrom(f => f.EnquiryTypeId))
                .ReverseMap();

        }
    }
}
