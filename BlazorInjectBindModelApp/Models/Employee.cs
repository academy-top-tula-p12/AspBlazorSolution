namespace BlazorInjectBindModelApp.Models
{
    public class Employee
    {
        public string Name { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public bool Maried { get; set; }
        public string Gender { get; set; } = "";
        public List<string> Skills { get; set; } = new();
    }
}
