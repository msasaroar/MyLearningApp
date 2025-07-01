using MyLearningApp.Models;

namespace MyLearningAppLibrary.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
    }
}
