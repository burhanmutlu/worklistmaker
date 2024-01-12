namespace WorkListMaker.view
{
	partial class AddPolyclinicAreaForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxAlandaCalisanSayisi = new System.Windows.Forms.TextBox();
			this.textBoxAlanAdi = new System.Windows.Forms.TextBox();
			this.buttonRenkSecme = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 183);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 27;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "Alanda Çalışan Sayısı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "Alan Temsil Rengi";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Alan Adı";
			// 
			// textBoxAlandaCalisanSayisi
			// 
			this.textBoxAlandaCalisanSayisi.Location = new System.Drawing.Point(12, 72);
			this.textBoxAlandaCalisanSayisi.Name = "textBoxAlandaCalisanSayisi";
			this.textBoxAlandaCalisanSayisi.Size = new System.Drawing.Size(215, 20);
			this.textBoxAlandaCalisanSayisi.TabIndex = 16;
			// 
			// textBoxAlanAdi
			// 
			this.textBoxAlanAdi.Location = new System.Drawing.Point(12, 33);
			this.textBoxAlanAdi.Name = "textBoxAlanAdi";
			this.textBoxAlanAdi.Size = new System.Drawing.Size(215, 20);
			this.textBoxAlanAdi.TabIndex = 15;
			// 
			// buttonRenkSecme
			// 
			this.buttonRenkSecme.Location = new System.Drawing.Point(12, 118);
			this.buttonRenkSecme.Name = "buttonRenkSecme";
			this.buttonRenkSecme.Size = new System.Drawing.Size(215, 28);
			this.buttonRenkSecme.TabIndex = 28;
			this.buttonRenkSecme.Text = "Renk Seç";
			this.buttonRenkSecme.UseVisualStyleBackColor = true;
			this.buttonRenkSecme.Click += new System.EventHandler(this.buttonRenkSecme_Click);
			// 
			// AddPolyclinicAreaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 276);
			this.Controls.Add(this.buttonRenkSecme);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxAlandaCalisanSayisi);
			this.Controls.Add(this.textBoxAlanAdi);
			this.Name = "AddPolyclinicAreaForm";
			this.Text = "AddPolyclinicAreaForm";
			this.Load += new System.EventHandler(this.AddPolyclinicAreaForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAlandaCalisanSayisi;
		private System.Windows.Forms.TextBox textBoxAlanAdi;
		private System.Windows.Forms.Button buttonRenkSecme;
	}
}