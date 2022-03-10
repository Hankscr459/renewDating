namespace API.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int currentPage, int itemsPerage, int totalItems, int totalPages)
        {
            CurrentPage = currentPage;
            ItemsPerage = itemsPerage;
            TotalItems = totalItems;
            TotalPages = totalPages;
        }

        public int CurrentPage { get; set; }
        public int ItemsPerage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}