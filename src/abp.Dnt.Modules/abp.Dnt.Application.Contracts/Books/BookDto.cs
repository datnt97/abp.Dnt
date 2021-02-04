using Volo.Abp.Application.Dtos;

namespace abp.Dnt.Application.Contracts.Books
{
    public class BookDto : AuditedEntityDto
    {
        public string Name { get; set; }

        public BookType MyProperty { get; set; }
    }
}
