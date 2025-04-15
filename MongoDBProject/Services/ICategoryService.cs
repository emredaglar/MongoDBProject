using MongoDBProject.Dtos.CategoryDtos;

namespace MongoDBProject.Services
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
    }
}
