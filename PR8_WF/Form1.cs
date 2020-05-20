using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PR8_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string date(string text)
		{
			string pattern = "[0-2][0-9]|[3][0,1].[0-1][0-9].[1,2][9,0][0-9][0-9]";
			Regex reg = new Regex(pattern);
			MatchCollection matches = reg.Matches(text);
			for (int i = 0; i < matches.Count; i++)
			{
				DateTime buf;
				try
				{
					if (DateTime.TryParse(matches[i].Value, out buf))
					{
						string updDate = DateTime.Parse(matches[i].Value).AddDays(1).ToShortDateString();
						text = text.Replace(matches[i].Value, updDate);
					}
					else
					{
						throw new Exception();
					}
				}
				catch
				{
					Console.WriteLine("Некорректная дата");
				}
			}
			return text;
		}
		private void text_box_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string text = Convert.ToString(text_box.Text);
				if (text == "") result_box.Text = "Введена пустая строка";
				result_box.Text = date(text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
