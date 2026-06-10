using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoGargula
{
	public class HitBox : PictureBox
	{
		public HitBox(int width, int height)
		{
			Width = width;
			Height = height;
		}
		public void Remove(){
			Top = -200;
			Left = -400;
		}
	}
}
