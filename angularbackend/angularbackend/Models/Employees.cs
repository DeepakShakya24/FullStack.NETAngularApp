namespace angularbackend.Models
{
    public class Employees
    {
        public string id { get; set; } = Guid.NewGuid().ToString();

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string department { get; set; }
    }
}
