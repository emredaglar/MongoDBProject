using MongoDBProject.Dtos;

namespace MongoDBProject.Services
{
	public interface ICustomerService
	{
		Task<List<ResultCustomerDto>> GetAllCustomerAsync();
		Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
		Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);
		Task DeleteCustomerAsync(string id);
		Task<GetByIdCustomerDto> GetByIdCustomerAsync(string id);
	}
}
