namespace Entities
{
    public class Book
    {
        public int Id { get; set; } 
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publication {  get; set; }
        public float? Price { get; set; }
        public Char BookType { get; set; }

        public DateTime? CreatedDate { get; set; }= DateTime.Now;
        public DateTime? Updated { get; set; }=DateTime.Now;
        public Book()
        {

        }

        public Book(int id, string? title, string? author, string? publication, float? price, char bookType, DateTime? createdDate, DateTime? updated)
        {
            Id = id;
            Title = title;
            Author = author;
            Publication = publication;
            Price = price;
            BookType = bookType;
            CreatedDate = createdDate;
            Updated = updated;
        }
    }
}
