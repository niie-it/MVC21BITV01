namespace LabAndDemoBuoi05.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Mark { get; set; } = 0;
		public string Grade
		{
			get
			{
				if (Mark < 4) return "F";
				if (Mark < 5.5) return "D";
				if (Mark < 7) return "C";
				if (Mark < 8.5) return "B";
				return "A";
			}
		}
	}
}
