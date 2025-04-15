using AutoMapper;
using MongoDBProject.Dtos;
using MongoDBProject.Dtos.CategoryDtos;
using MongoDBProject.Dtos.ProductDtos;
using MongoDBProject.Entities;

namespace MongoDBProject.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<Customer,ResultCustomerDto>().ReverseMap();
			CreateMap<Customer,CreateCustomerDto>().ReverseMap();
			CreateMap<Customer,UpdateCustomerDto>().ReverseMap();
			CreateMap<Customer,GetByIdCustomerDto>().ReverseMap();

			CreateMap<Product,ResultProductDto>().ReverseMap();
			CreateMap<Product,CreateProductDto>().ReverseMap();
			CreateMap<Product,GetByIdProductDto>().ReverseMap();
			CreateMap<Product,UpdateProductDto>().ReverseMap();
			CreateMap<Category,CreateCategoryDto>().ReverseMap();
			

		}
	}
}
