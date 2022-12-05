using AutoMapper;
using BudgetBadgerWebApi.Application.Mappings.Dtos.HouseMemberExpense;
using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Application.Mappings.Profiles
{
    public class HouseMemberExpenseProfile : Profile
    {
        public HouseMemberExpenseProfile()
        {
            CreateMap<HouseMemberExpense, HouseMemberExpenseShortDto>();
        }
    }
}
