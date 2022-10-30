using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultlbl.Text = String.Empty;
		}

		private void resultbtn_Click(object sender, EventArgs e)
		{
			string result = Greeting();
			MessageBox.Show(result);
			resultlbl.Text = result;

		}

		private string Greeting()
		{
			string result = String.Empty;
			string now = "現在時間是" + DateTime.Now.ToString($"yyyy/MM/dd\r\nHH:mm:ss");
			int hours = DateTime.Now.Hour;
			result = now;
			result += (hours >= 0 && hours <= 10) ? "早安" : (hours >= 11 && hours <= 16)
				                                  ? "午安" : "晚安";
			//if (hours >= 0 && hours <= 10)
			//{
			//	result += "早安";
			//}
			//else if (hours >= 11 && hours <= 16)
			//{
			//	result += "午安";
			//}
			//else
			//{
			//	result += "晚安";
			//}
			return result;
		}
	}
}
