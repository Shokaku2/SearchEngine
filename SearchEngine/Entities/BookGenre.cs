namespace SearchEngine.Entities
{
    public class BookGenre
    {
        public int BookId { get; set; }
        public Books Book { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
