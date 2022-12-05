using AutoMapper;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Application.Mappings.Profiles
{
    public class IncomeProfile : Profile
    {
        public IncomeProfile()
        {
            CreateMap<Income, IncomeDto>();
        }
    }
}
