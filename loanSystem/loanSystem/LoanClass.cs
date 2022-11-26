using System;
namespace loanSystem
{
	public class LoanClass
	{
		public int Id;
		public DateOnly LoanDate;
		public DateOnly DueDate;
		public string Description;

		public LoanClass(int id, DateOnly loanDate, DateOnly dueDate, string description)
		{
			Id = id;
			LoanDate = loanDate;
			DueDate = dueDate;
			Description = description;
		}
	}
}
        