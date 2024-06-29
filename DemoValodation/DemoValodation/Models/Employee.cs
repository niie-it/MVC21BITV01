using System.ComponentModel.DataAnnotations;

namespace DemoValodation.Models
{
	public class Employee
	{
		public int? Id { get; set; }

		public string EmployeeNo { get; set; }

		[MinLength(5, ErrorMessage ="Tối thiểu 5 kí tự")]
		public string FullName { get; set; }


		[EmailAddress(ErrorMessage ="Chưa đúng định dạng email")]
		public string Email { get; set; }


		[Url(ErrorMessage ="Chưa đúng định dạng url")]
		public string Website { get; set; }

		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }

		public string Gender { get; set; }

		[Range(0, double.MaxValue)]
		public double Salary { get; set; }

		public string Address { get; set; }

		[RegularExpression(@"0[98753]\d{8}")]
		public string Phone { get; set; }

		public bool IsPartTime { get; set; }

		[CreditCard]
		public string? CreditCard { get; set; }

		[DataType(DataType.Password)]
		[MinLength(6, ErrorMessage ="Tối thiểu 6 kí tự")]
		public string Password { get; set; }

		[MaxLength(255)]
		[DataType(DataType.MultilineText)]
		public string Description { get; set; }
	}
}
