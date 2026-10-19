using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 0);
			SetVisibility(false);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		void SetVisibility(bool visible)
		{
			cbShowDate.Visible			= visible;
			cbShowWeekday.Visible		= visible;
			btnHideControls.Visible		= visible;
			this.ShowInTaskbar			= visible;
			this.FormBorderStyle		= visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.TransparencyKey		= visible ? Color.Empty:this.BackColor;
		}

		//			Event handlers (Обработчики событий)
		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
			if (cbShowDate.Checked) labelTime.Text += $"\n{DateTime.Now.ToString("yyy.MM.dd")}";
			if (cbShowWeekday.Checked) labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
		}

		private void btnHideControls_Click(object sender, EventArgs e)	=>	SetVisibility(false);
		private void labelTime_DoubleClick(object sender, EventArgs e)	=>	SetVisibility(true);
	}
}