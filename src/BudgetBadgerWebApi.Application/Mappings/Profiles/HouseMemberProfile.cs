using AutoMapper;
using BudgetBadgerWebApi.Application.Mappings.Dtos.HouseMember;
using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Application.Mappings.Profiles
{
    public class HouseMemberProfile : Profile
    {
        public HouseMemberProfile()
        {
            CreateMap<HouseMember, HouseMemberShortDto>();
        }
    }
}
