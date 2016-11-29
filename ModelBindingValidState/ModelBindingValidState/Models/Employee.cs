
namespace ModelBindingValidState.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee GetEmployee()
        {
            var employee = new Employee()
            {
                Id = 1,
                Name = "Tanvi",
                Department = "IT",
                Salary = 34000
            };

            return employee;
        }
    }
}