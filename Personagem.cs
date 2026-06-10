using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoGargula
{
	public class Personagem : PictureBox
	{
		public Personagem()
		{
			
		}
		public int hp = 1;
		public int atk;
		public int def;
		public int spd;
		
		public bool canMove = true;
		
		public static bool Collision(PictureBox ent1, PictureBox ent2){
			return ent1.Bounds.IntersectsWith(ent2.Bounds);
		}
		
		public static void Remove(PictureBox ent){
			ent.Image = null;
			ent.Top = -2000;
			ent.Left = -1000;
		}
	}
}
