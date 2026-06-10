using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoGargula
{
	public class Tiro : PictureBox
	{
		public Tiro()
		{
			// CONFIG TIRO
			this.Height = 50;
			this.Width = 75;
			this.Image = Image.FromFile("fireball2.gif");
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.BackColor = Color.Transparent;
			
			// CONFIG TIMER
			TiroMove.Enabled = true;
			TiroMove.Interval = 20;
			TiroMove.Tick += TiroMove_Tick;
		}
		
		public Timer TiroMove = new Timer();
		public static bool canShoot = true;

		void TiroMove_Tick(object sender, EventArgs e)
		{
			if (Left > 1500 || Left < 0) {
				Remove();
			}
		}
		public void Remove(){
			Image = null;
			Top = -2000;
			Left = -2000;
			Width = 0;
			Height = 0;
			TiroMove.Enabled = false;
			Controls.Remove(this);
			Dispose();
		}
	}
}
