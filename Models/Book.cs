using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Bara_Davide_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }


        [Required(ErrorMessage = "The Title field is required.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "The Title must be between 3 and 150 characters.")]
        public string Title { get; set; }
        [Display(Name = "Book Title")]
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        [Range(0.01, 500)]

        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? BorrowingID { get; set; }
        public Borrowing? Borrowing { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
