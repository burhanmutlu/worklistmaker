﻿namespace WorkListMaker.view
{
	partial class AddEmployeeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxTcNo = new System.Windows.Forms.TextBox();
			this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
			this.textBoxMinCalismaSaati = new System.Windows.Forms.TextBox();
			this.textBoxMaxCalismaSaati = new System.Windows.Forms.TextBox();
			this.textBoxOzelDurumKodu = new System.Windows.Forms.TextBox();
			this.textBoxAylıkMaxCalismaSaati = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBoxCalismaAlanlari = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxTcNo
			// 
			this.textBoxTcNo.Location = new System.Drawing.Point(23, 34);
			this.textBoxTcNo.Name = "textBoxTcNo";
			this.textBoxTcNo.Size = new System.Drawing.Size(215, 20);
			this.textBoxTcNo.TabIndex = 0;
			// 
			// textBoxAdSoyad
			// 
			this.textBoxAdSoyad.Location = new System.Drawing.Point(23, 73);
			this.textBoxAdSoyad.Name = "textBoxAdSoyad";
			this.textBoxAdSoyad.Size = new System.Drawing.Size(215, 20);
			this.textBoxAdSoyad.TabIndex = 1;
			// 
			// textBoxMinCalismaSaati
			// 
			this.textBoxMinCalismaSaati.Location = new System.Drawing.Point(23, 119);
			this.textBoxMinCalismaSaati.Name = "textBoxMinCalismaSaati";
			this.textBoxMinCalismaSaati.Size = new System.Drawing.Size(215, 20);
			this.textBoxMinCalismaSaati.TabIndex = 2;
			// 
			// textBoxMaxCalismaSaati
			// 
			this.textBoxMaxCalismaSaati.Location = new System.Drawing.Point(23, 165);
			this.textBoxMaxCalismaSaati.Name = "textBoxMaxCalismaSaati";
			this.textBoxMaxCalismaSaati.Size = new System.Drawing.Size(215, 20);
			this.textBoxMaxCalismaSaati.TabIndex = 3;
			// 
			// textBoxOzelDurumKodu
			// 
			this.textBoxOzelDurumKodu.Location = new System.Drawing.Point(23, 211);
			this.textBoxOzelDurumKodu.Name = "textBoxOzelDurumKodu";
			this.textBoxOzelDurumKodu.Size = new System.Drawing.Size(215, 20);
			this.textBoxOzelDurumKodu.TabIndex = 4;
			// 
			// textBoxAylıkMaxCalismaSaati
			// 
			this.textBoxAylıkMaxCalismaSaati.Location = new System.Drawing.Point(23, 258);
			this.textBoxAylıkMaxCalismaSaati.Name = "textBoxAylıkMaxCalismaSaati";
			this.textBoxAylıkMaxCalismaSaati.Size = new System.Drawing.Size(215, 20);
			this.textBoxAylıkMaxCalismaSaati.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tc Kimlik Numarası";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Günde Min Çalışma Saati";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Ad Soyad";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Günde Max Çalışma Saati";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Aylık Max Çalışma Saati";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Özel Durum Kodu";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(70, 366);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBoxCalismaAlanlari
			// 
			this.comboBoxCalismaAlanlari.FormattingEnabled = true;
			this.comboBoxCalismaAlanlari.Location = new System.Drawing.Point(23, 306);
			this.comboBoxCalismaAlanlari.Name = "comboBoxCalismaAlanlari";
			this.comboBoxCalismaAlanlari.Size = new System.Drawing.Size(215, 21);
			this.comboBoxCalismaAlanlari.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 290);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Çalışma Alanı";
			// 
			// AddEmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 413);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBoxCalismaAlanlari);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxAylıkMaxCalismaSaati);
			this.Controls.Add(this.textBoxOzelDurumKodu);
			this.Controls.Add(this.textBoxMaxCalismaSaati);
			this.Controls.Add(this.textBoxMinCalismaSaati);
			this.Controls.Add(this.textBoxAdSoyad);
			this.Controls.Add(this.textBoxTcNo);
			this.Name = "AddEmployeeForm";
			this.Text = "AddEmployeeForm";
			this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxTcNo;
		private System.Windows.Forms.TextBox textBoxAdSoyad;
		private System.Windows.Forms.TextBox textBoxMinCalismaSaati;
		private System.Windows.Forms.TextBox textBoxMaxCalismaSaati;
		private System.Windows.Forms.TextBox textBoxOzelDurumKodu;
		private System.Windows.Forms.TextBox textBoxAylıkMaxCalismaSaati;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBoxCalismaAlanlari;
		private System.Windows.Forms.Label label7;
	}
}