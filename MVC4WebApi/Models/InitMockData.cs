namespace MVC4WebApi.Models
{
    /// <summary>
    /// OUR MOCK DATA !
    /// </summary>

    public class InitMockData : CustomerRepository
    { 
        public InitMockData()
        {
            Add(new Customer
            {
                ID = 1,
                Name = @"Giorgio Bottega",
                Money = 55.25f,

            });
            Add(new Customer
            {
                ID = 1,
                Name = "Christiano Redrez",
                Money = 19.75f,

            });
            Add(new Customer
            {
                ID = 2,
                Name =
                    "Robe Di Kappa",
                Money = 22.5f,

            });
        }



    }
}