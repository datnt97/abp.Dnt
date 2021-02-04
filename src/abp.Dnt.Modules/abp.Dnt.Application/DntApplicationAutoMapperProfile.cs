using abp.Dnt.Application.Contracts.Books;
using abp.Dnt.Domain.Books;
using AutoMapper;

namespace abp.Dnt.Application
{
    public class DntApplicationAutoMapperProfile : Profile
    {
        public DntApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
