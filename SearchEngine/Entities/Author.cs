using System.ComponentModel.DataAnnotations;

namespace SearchEngine.Entities;

public class Author
{
    public int ID { get; set; }
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Biography is required.")]
    public string Biography { get; set; }


    [Required(ErrorMessage = "Birth Date is required.")]
    public int BirthDate { get; set; }
    public int DeathDate { get; set; }
    [Required(ErrorMessage = "Nationality is required.")]
    public string Nationality { get; set; }
    public ICollection<Books> Book { get; set; }
}
