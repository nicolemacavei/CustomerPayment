using System.ComponentModel.DataAnnotations;

namespace CustomerPayment.Models
{
    public class Customers
    {
        public Customers(int id, string name, string email, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
    }


}
