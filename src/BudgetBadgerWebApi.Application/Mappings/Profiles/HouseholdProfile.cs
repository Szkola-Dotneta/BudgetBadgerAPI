using AutoMapper;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Household;
using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Application.Mappings.Profiles
{
    public class HouseholdProfile : Profile
    {
        public HouseholdProfile()
        {
            CreateMap<Household, HouseholdShortDto>();
        }
    }
}
