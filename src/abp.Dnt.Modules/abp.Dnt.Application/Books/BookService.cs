using abp.Dnt.Application.Contracts.Books;
using abp.Dnt.Domain.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abp.Dnt.Application.Books
{
    public class BookService :
        CrudAppService<
            Book,
            BookDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateBookDto>,
        IBookService 
    {
        public BookService(IRepository<Book, Guid> repository) : base(repository)
        {

        }
    }
}
