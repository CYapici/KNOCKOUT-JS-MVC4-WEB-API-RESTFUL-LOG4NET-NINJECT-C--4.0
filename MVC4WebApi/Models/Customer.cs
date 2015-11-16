///
/// BASE MODEL
/// 
/// 
namespace MVC4WebApi.Models
{

    public class Customer
    {
        //for empty initialization
        public Customer() { }
        public Customer(long money, string name)
        {
            Money = money;
            Name = name;
        }

        public long ID { get; set; }

        //  [DataMember(IsRequired = true)]
        public string Name { get; set; }

        // [Required] 
        public double Money { get; set; }




    }
}