using AutoMapper;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Expense;
using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Application.Mappings.Profiles
{
    public class ExpenseProfile : Profile
    {
        public ExpenseProfile()
        {
            CreateMap<Expense, ExpenseDto>();
        }
    }
}
