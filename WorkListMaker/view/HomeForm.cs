using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkListMaker.model;
using WorkListMaker.model.Context;
using WorkListMaker.utils;
using WorkListMaker.view;

namespace WorkListMaker
{
	public partial class HomeForm : Form
	{
		public HomeForm()
		{
			InitializeComponent();
		}

		private void HomeForm_Load(object sender, EventArgs e)
		{
			Random rand = new Random();
			List<string> strings = new List<string>();
			Queue<string> queue = new Queue<string>();
			for(int k = 1; k < 50;k++) // calisan sayisi
			{
				strings.Add("calisan"+k);
			}
			int emplCount = 0;
			for (int i=1; i<31; i++)//planlanacak gun sayisi
			{
				if(i>3 && queue.Count>0)
				{
					for(int ii=0; ii<16; ii++) // 16 kisinin dinlenmesi bitti
					{// bu sayı artabilir eger adam eksik ise 18-20 veya ne kadar lazım ise o kadar artar
						//boyle olunca ama gunasiri calismis oluyorlar
						queue.Dequeue();
					}
				}
				Console.Write("gun:" + i+ " ");
				for(int jj=0; jj<11;  jj++) // 4 alan varsa
				{
					Console.WriteLine("alan" + jj);
					if(jj<6)
					{
						emplCount = 1;
					} 
					else
					{
						emplCount = 2;
					}
					
					for (int j = 0; j < emplCount; j++) // alanda gereken personel sayisi
					{
						int val = rand.Next(1, 49);
						while (queue.Contains(strings[val]))
						{
							val = rand.Next(1, 49);
						}
						queue.Enqueue(strings[val]);
						Console.Write(strings[val] + " ");
					}
					Console.WriteLine();
				}
				
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
			addEmployeeForm.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddPolyclinicAreaForm addPolyclinicAreaForm = new AddPolyclinicAreaForm();
			addPolyclinicAreaForm.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			FileUtils fileUtils = new FileUtils();
			fileUtils.createExcelFile();
		}

	}
}
