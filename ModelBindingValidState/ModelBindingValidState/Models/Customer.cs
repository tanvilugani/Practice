using System.ComponentModel.DataAnnotations;

namespace ModelBindingValidState.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        [Range(18,60)]
        public int Age { get; set; }

        public Customer GetCustomer()
        {
            var customer = new Customer()
            {
                Name = "Tanvi",
                Address = "ABC colony",
                Age=17
            };

            return customer;
        }
    }
}