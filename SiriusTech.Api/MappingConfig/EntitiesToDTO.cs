using AutoMapper;
using SiriusTech.Data.Models;
using SiriusTech.Domain.DTOs.Response;

namespace SiriusTech.Api.Config
{
    public class EntitiesToDTO : Profile
    {
        public EntitiesToDTO()
        {

            CreateMap<Entidade, EntidadeResponse>.ReverseMap();

            
        }
    }
}
