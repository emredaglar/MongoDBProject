using AutoMapper;
using MongoDBProject.Dtos;
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

		}
	}
}
