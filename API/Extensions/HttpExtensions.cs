using System.Runtime.Serialization.Json;
using System.Text.Json;
using API.Helpers;

namespace API.Extensions
{
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse response, int currentPage, int itemsPerage, int totalItems, int totalPages)
        {
            var PaginationHeader = new PaginationHeader(currentPage, itemsPerage, totalItems, totalPages);
            response.Headers.Add("Pagination", JsonSerializer.Serialize(PaginationHeader));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}