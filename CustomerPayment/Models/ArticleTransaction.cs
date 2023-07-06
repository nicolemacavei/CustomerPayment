using System.ComponentModel.DataAnnotations;

namespace CustomerPayment.Models
{
    public class ArticleTransaction
    {
        public ArticleTransaction(int id, int articleId, int transactionId)
        {
            Id = id;
            ArticleId = articleId;
            TransactionId = transactionId;
        }
        public int Id { get; set; }
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public Articles Articles { get; set; }
        public int TransactionId { get; set; }
        [Required]
        public Transactions Transactions { get; set; }
    }
}
