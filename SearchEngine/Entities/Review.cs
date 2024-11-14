using Microsoft.AspNetCore.Identity;


namespace SearchEngine.Entities;

public class Review
{
    public int ID { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public int BookId { get; set; }
    public Books Book { get; set; }
    public int Rating { get; set; }
    public string ReviewText { get; set; }
    public DateTime ReviewDate { get; set; }
}
