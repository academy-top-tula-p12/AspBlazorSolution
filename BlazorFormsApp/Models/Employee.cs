using System.ComponentModel.DataAnnotations;

namespace BlazorFormsApp.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина имени от {2} до {1} символов")]
        public string Name { get; set; } = "";
        public DateTime BirthDate { get; set; }

        [Range(17000, 1000000, ErrorMessage = "Размер зарплаты от {1} до {2} рублей")]
        public int Salary { get; set; }
        public bool Married { get; set; }

        [EmployeeGenderValidator(new[] {"Male", "Female"})]
        public string Gender { get; set; } = "";
        public string[] Skills { get; set; } = [];
    }

    public class EmployeeGenderValidator : ValidationAttribute
    {
        string[] genders;
        public EmployeeGenderValidator(string[] genders)
        {
            this.genders = genders;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (genders.Contains(value?.ToString()))
                return ValidationResult.Success;
            else
                return new ValidationResult("Некооректный гендер");
        }
    }
}
