﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkListMaker.model.Context;
using WorkListMaker.model;

namespace WorkListMaker.view
{
	public partial class AddEmployeeForm : Form
	{
		public AddEmployeeForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (MyDbContext myDbContext = new MyDbContext())
			{
				myDbContext.Employees.Add(new model.Employee
				{
					Name = textBoxAdSoyad.Text,
					MaxDailyWorkingHours = Convert.ToInt32(textBoxMaxCalismaSaati.Text),
					MaxWorkingHoursPerMonth = Convert.ToInt32(textBoxAylıkMaxCalismaSaati.Text),
					MinDailyWorkingHours = Convert.ToInt32(textBoxMinCalismaSaati.Text),
					SpecialStatusCode = Convert.ToInt32(textBoxOzelDurumKodu.Text),
					TcId = textBoxTcNo.Text
				});

				myDbContext.SaveChanges();
			}
		}

		private void AddEmployeeForm_Load(object sender, EventArgs e)
		{
			using(MyDbContext myDbContext = new MyDbContext())
			{
				var allPolyclinicAreas = myDbContext.PolyclinicAreas.ToList();
				foreach (var area in allPolyclinicAreas)
				{
					comboBoxCalismaAlanlari.Items.Add(area.Name);
				}
			}
			
		}
	}
}
