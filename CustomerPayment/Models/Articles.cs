using System.ComponentModel.DataAnnotations;

namespace CustomerPayment.Models
{
    public class Articles
    {
        public Articles() { }
        public Articles(int id, string title, string description) {
            Id = id;
            Title = title;
            Description = description;
        }
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
