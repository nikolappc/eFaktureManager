namespace eFaktureManagement.Paging
{
    public class PageRequest<T, F>
    {
        public int PageNumber { get; set; } 
        public int PageSize { get; set; }

        public Sorting? Sorting { get; set; }   

        public F? Filter { get; set; }  
    }
}
