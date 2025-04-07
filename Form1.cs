using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeldaaydProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent(); //Bu satır hep üste olmalı programın çalışması için //This line must always be at the top for the program to work
			if (!this.DesignMode)
			{
				//Here are the codes you said not to run in design mode
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnGetir_Click(object sender, EventArgs e)
		{
			Restoran newRestoran = new Restoran();

			newRestoran.restoranName = txtRestoranName.Text;
			newRestoran.chairNumber = int.Parse(txtChairNumber.Text);

			label3.Text = newRestoran.MessagePrint();
		}
	}
}
