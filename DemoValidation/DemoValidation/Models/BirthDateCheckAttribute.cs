
using System.ComponentModel.DataAnnotations;

namespace DemoValodation.Models
{
	public class BirthDateCheckAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			var birthDate = (DateTime)value;
			if (birthDate >= DateTime.Now)
			{
				return new ValidationResult("Ngày sinh không được tương lai");
			}
			if (birthDate.AddYears(14) >= DateTime.Now)
			{
				return new ValidationResult("Phải đủ 14 tuổi");
			}
			return ValidationResult.Success;
		}
	}
}