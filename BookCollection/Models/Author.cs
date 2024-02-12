namespace BookCollection.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Book>? Books { get; set;}
    }
}
