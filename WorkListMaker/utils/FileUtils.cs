using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkListMaker.model.Context;

namespace WorkListMaker.utils
{
	public class FileUtils
	{
		private ExcelWorksheet Sheet {get; set;}

		public FileUtils()
		{
			
		}

		private string createFileName()
		{
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			string nowTime = DateTime.Now.ToShortDateString() +
				"-" + DateTime.Now.Hour + "." + DateTime.Now.Minute;
			string fileName = "CalismaListesi-" + nowTime + ".xlsx";
			string fullPath = Path.Combine(documentsPath, fileName);
			return fullPath;
		}

		public void createExcelFile()
		{
			using (var package = new ExcelPackage())
			{
				var sheet = package.Workbook.Worksheets.Add("CalismaListesiSheet1");
				Sheet = sheet;
				initSheet();
				

				
				var file = new System.IO.FileInfo(createFileName());
				package.SaveAs(file);
				MessageBox.Show("kaydedildi");
			}
		}

		private void initSheet()
		{
			aligmentCenter();
			Sheet.Cells["A1"].Value = "No";
			Sheet.Cells["B1"].Value = "TC No";
			Sheet.Cells["C1"].Value = "Ad Soyad";
			Sheet.Cells["D1"].Value = "Toplam Çalışma Saati";

			for(int i =5;  i < 35; i++)
			{
				Sheet.Cells[1, i].Value = i - 4;
			}

			using (MyDbContext dbContext = new MyDbContext())
			{
				var allEmployee = dbContext.Employees.ToList();
				int i = 2;
				foreach (var employee in allEmployee)
				{
					Sheet.Cells["A" + i].Value = i - 1;
					Sheet.Cells["B" + i].Value = employee.TcId;
					Sheet.Cells["C" + i].Value = employee.Name;
					Sheet.Cells["D" + i].Value = employee.OvertimeHours;
					fillCells("D" + i, "Red");
					i++;
				}
			}
		}

		private void aligmentCenter()
		{
			for(int i = 1; i <60;  i++)
			{
				Sheet.Column(i).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
			}
		}

		public void fillCells(string cells, string colorName)
		{
			using (var range = Sheet.Cells[cells])
			{
				range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
				range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromName(colorName));
			}
			
		}


	}
}
