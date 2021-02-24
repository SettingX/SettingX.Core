using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class PaginatedList<T> : List<T>
    {
        [JsonPropertyName("page_index")]
        public int PageIndex { get; private set; }
        
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; private set; }

        [JsonPropertyName("has_previous_page")]
        public bool HasPreviousPage => PageIndex > 1;

        [JsonPropertyName("has_next_page")]
        public bool HasNextPage => PageIndex < TotalPages;

        public PaginatedList(List<T> items, int totalCount, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            AddRange(items);
        }
    }
}
