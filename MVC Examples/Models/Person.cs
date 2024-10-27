using MVC_Examples.Enum;

namespace MVC_Examples.Models
{
    public class Person
    {
        public string? Name { get; set; }
        public DateTime Dob { get; set; }
        public string? Address { get; set; }
        public Gender gender { get; set; }
        public List<string>? ChildernNames { get; set; }

        public List<string>? mycars { get; set; }

        public int GetAge()
        {
            return (DateTime.Now.Year - Dob.Year);
        }
    }

}
