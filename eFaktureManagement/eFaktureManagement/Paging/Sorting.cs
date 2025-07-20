namespace eFaktureManagement.Paging
{
    public class Sorting
    {
        public string? SortBy { get; set; }
        public bool IsDescending { get; set; }

        public Sorting(string? sortBy, bool isDescending = false)
        {
            SortBy = sortBy;
            IsDescending = isDescending;
        }

        public Sorting()
        {
            SortBy = null;
            IsDescending = false;
        }
    }
}
