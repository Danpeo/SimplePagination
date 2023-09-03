using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePagination
{
    public class PaginationData
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int NextPage => CurrentPage + 1;
        public int PreviousPage => CurrentPage - 1;
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
    }
}
