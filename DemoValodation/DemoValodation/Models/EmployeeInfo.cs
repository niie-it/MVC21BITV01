using System.ComponentModel.DataAnnotations;

namespace DemoValodation.Models
{
	public class EmployeeInfo
	{
		[Required(ErrorMessage ="*")]
		[MinLength(5, ErrorMessage ="Tối thiểu 5 kí tự")]
		public string FullName { get; set; }

		[Range(18, 65, ErrorMessage ="Tuổi từ 18 đến 65")]
		public int Age { get; set; }
	}

}
