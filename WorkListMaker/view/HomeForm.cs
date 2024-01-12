﻿using OfficeOpenXml;
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
