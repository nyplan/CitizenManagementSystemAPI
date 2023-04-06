using AutoMapper;
using CitizenManagementSystemAPI.DTOs.CitizenDTOs;
using CitizenManagementSystemAPI.DTOs.CurrentPlaceDto;
using CitizenManagementSystemAPI.DTOs.EntranceDTOs;
using CitizenManagementSystemAPI.DTOs.GenderDTOs;
using CitizenManagementSystemAPI.DTOs.ManagerDTOs;
using CitizenManagementSystemAPI.DTOs.RegionDTOs;
using CitizenManagementSystemAPI.DTOs.StreetDTOs;
using CitizenManagementSystemAPI.Entities;
using System.Globalization;

namespace CitizenManagementSystemAPI.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            #region CurrentPlace Mappings

            CreateMap<CurrentPlaceAddDto, CurrentPlace>();

            #endregion
            #region Citizen mappings

            CreateMap<Citizen, CitizensToListDto>()
                .ForMember(dest => dest.BirthPlace, src => src.MapFrom(c => c.BirthPlace.RegionName))
                .ForMember(dest => dest.CurrentPlace, src => src.MapFrom(c =>
                $"{c.CurrentPlace.Region.RegionName}, " +
                $"{c.CurrentPlace.Street.StreetName}, " +
                $"{c.CurrentPlace.Entrance.EntranceName}"))
                .ForMember(dest => dest.Gender, src => src.MapFrom(c => c.Gender.Value))
                .ForMember(dest => dest.FatherPin, src => src.MapFrom(c => c.Father.Pin))
                .ForMember(dest => dest.MotherPin, src => src.MapFrom(c => c.Mother.Pin))
                .ForMember(dest => dest.BirthDate, src => src.MapFrom(c => c.BirthDate.ToString("dd/MM/yyyy")));

            CreateMap<CitizenToAddDto, Citizen>()
                .ForMember(dest => dest.BirthDate, src => src.MapFrom(c => c.BirthDate))
                .ForMember(dest => dest.FatherId, src => src.Ignore())
                .ForMember(dest => dest.MotherId, src => src.Ignore());

            CreateMap<Citizen, CitizenByPinDto>()
                .ForMember(dest => dest.BirthPlace, src => src.MapFrom(c => c.BirthPlace.RegionName))
                .ForMember(dest => dest.CurrentPlace, src => src.MapFrom(c =>
                $"{c.CurrentPlace.Region.RegionName}, " +
                $"{c.CurrentPlace.Street.StreetName}, " +
                $"{c.CurrentPlace.Entrance.EntranceName}"))
                .ForMember(dest => dest.Gender, src => src.MapFrom(c => c.Gender.Value))
                .ForMember(dest => dest.FatherPin, src => src.MapFrom(c => c.Father.Pin))
                .ForMember(dest => dest.MotherPin, src => src.MapFrom(c => c.Mother.Pin))
                .ForMember(dest => dest.BirthDate, src => src.MapFrom(c => c.BirthDate.ToString("dd/MM/yyyy")));

            #endregion
            #region Region Mappings

            CreateMap<Region, RegionToListDto>();

            #endregion
            #region Street Mappings

            CreateMap<Street, StreetToListDto>();

            #endregion
            #region Entrance Mappings

            CreateMap<Entrance, EntranceToListDto>();

            #endregion
            #region Gender Mappings

            CreateMap<EnumValue, GenderToListDto>();

            #endregion
            #region Manager Mappings

            CreateMap<CheckManagerDto, Manager>();
            CreateMap<ManagerToAddDto, Manager>();
            CreateMap<ManagerToUpdateDto, Manager>();

            #endregion
        }
    }
}
