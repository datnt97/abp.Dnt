using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace abp.Dnt.Application.Contracts.Books
{
    public interface IBookService : 
        ICrudAppService<
            BookDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateBookDto>
    {
    }
}
