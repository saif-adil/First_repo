using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiTulgberk.Domain
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPageCount { get; private set; }
        public PaginatedList(
        int pageIndex, int pageSize,
        int totalCount, IQueryable<T> source)
        {
            AddRange(source);
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPageCount = (int)Math.Ceiling(totalCount / (double)pageSize);
        }
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPageCount);
            }
        }

        public global::PingYourPackage.API.Model.Dtos.PaginatedDto<global::PingYourPackage.API.Model.Dtos.ShipmentDto> ToPaginatedDto(IEnumerable<TResult> enumerable)
        {
            throw new NotImplementedException();
        }

        public global::PingYourPackage.API.Model.Dtos.PaginatedDto<global::PingYourPackage.API.Model.Dtos.ShipmentDto> ToPaginatedDto(IEnumerable<TResult> enumerable)
        {
            throw new NotImplementedException();
        }
    }
}
