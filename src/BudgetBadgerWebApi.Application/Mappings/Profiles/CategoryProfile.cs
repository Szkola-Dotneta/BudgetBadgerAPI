using AutoMapper;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Category;
using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Application.Mappings.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>();
        }
    }
}
