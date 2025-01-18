namespace BlazorFormsApp.Models
{
    public class Employee
    {
        public string Name { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public bool Married { get; set; }
        public string Gender { get; set; } = "";
        public string[] Skills { get; set; } = [];
    }
}
