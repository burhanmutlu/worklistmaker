using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkListMaker.model;
using WorkListMaker.model.Context;

namespace WorkListMaker.view
{
	public partial class AddPolyclinicAreaForm : Form
	{
		private string _color;

		public AddPolyclinicAreaForm()
		{
			InitializeComponent();
		}

		private void AddPolyclinicAreaForm_Load(object sender, EventArgs e)
		{
		
			
		}

		private void buttonRenkSecme_Click(object sender, EventArgs e)
		{
			using(ColorDialog colorDialog = new ColorDialog())
			{
				DialogResult dialogResult = colorDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					_color = colorDialog.Color.Name;
					buttonRenkSecme.BackColor = colorDialog.Color;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using(MyDbContext myDbContext = new MyDbContext())
			{
				PolyclinicArea polyclinicArea = new PolyclinicArea();
				polyclinicArea.Name = textBoxAlanAdi.Text;
				polyclinicArea.NumberOfEmployeesRequired = 
					Convert.ToInt32(textBoxAlandaCalisanSayisi.Text);
				polyclinicArea.Color = _color;
				myDbContext.PolyclinicAreas.Add(polyclinicArea);
				myDbContext.SaveChanges();
			}
		}
	}
}
