using AutoMapper;
using Clinic.DTO;
using Clinic.Models;

namespace Clinic.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Patient, PatientDto>();
            Mapper.CreateMap<City, CityDto>();
            Mapper.CreateMap<Doctor, DoctorDto>();
            Mapper.CreateMap<Specialization, SpecializationDto>();
        }
    }
}