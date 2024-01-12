using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkListMaker.model
{
	public class PolyclinicArea
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Color { get; set; }
		public int NumberOfEmployeesRequired {get; set;}

		public PolyclinicArea() { }

		public PolyclinicArea(int id, string name, string color, int numberOfEmployeesRequired)
		{
			Id = id;
			Name = name;
			Color = color;
			NumberOfEmployeesRequired = numberOfEmployeesRequired;
		}


	}
}
