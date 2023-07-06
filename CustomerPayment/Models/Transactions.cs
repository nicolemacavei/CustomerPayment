using System.ComponentModel.DataAnnotations;

namespace CustomerPayment.Models
{
    public class Transactions
    {
        public Transactions(int id, string name,string description, string type) { 
            Id = id;
            Name = name;
            Description = description;
            Type = type;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Type { get; set; }

    }
}
