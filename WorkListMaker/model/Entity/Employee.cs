using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkListMaker.model
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string TcId { get; set; }
		public int MaxDailyWorkingHours { get; set; }
		public int MinDailyWorkingHours { get; set;}
		public int MaxWorkingHoursPerMonth { get; set;}
		public int SpecialStatusCode { get; set; }
		public int OvertimeHours { get; set; }

		public Employee() { }

		public Employee(int id, string tcId, string name, int maxDailyWorkingHours, int minDailyWorkingHours,
			int maxWorkingHoursPerMonth, int specialStatusCode, int overtimeHours)
		{
			Id = id;
			TcId = tcId;
			Name = name;
			MaxDailyWorkingHours = maxDailyWorkingHours;
			MinDailyWorkingHours = minDailyWorkingHours;
			MaxWorkingHoursPerMonth = maxWorkingHoursPerMonth;
			SpecialStatusCode = specialStatusCode;
			OvertimeHours = overtimeHours;
		}
	}
}
