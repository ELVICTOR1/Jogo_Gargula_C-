using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;

namespace JogoGargula
{
	public class Vilao : Personagem
	{
		public Vilao(int width, int height)
		{
			// CONFIGS DO PERSONAGEM
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = width;
			Height = height;
			Left = 700;
			
			// BARRA DE VIDA
			status.Parent = this;
			status.Top = 0;
			status.ForeColor = Color.White;
			status.Font = new Font("Microsoft Tai Lee", 20F);
			status.AutoSize = true;
			
			// TIMER DE ATIRAR
			enemyTiro.Enabled = true;
			enemyTiro.Interval = 500;
			enemyTiro.Tick += enemyTiro_Tick;
			
			// MOVIMENTO DO TIRO
			tiroMov.Enabled = true;
			tiroMov.Interval = 20;
			tiroMov.Tick += tiroMov_Tick;
		}
		
		public Label status = new Label();
		
		public Timer enemyTiro = new Timer();
		public Timer tiroMov = new Timer();
		
		public bool canShoot;
		
		public List<Tiro> Tiros = new List<Tiro>();

		void enemyTiro_Tick(object sender, EventArgs e)
		{
			if (Tiro.canShoot && canShoot) {
				Tiro shot = new Tiro();
				shot.Parent = Fase.cenario;
				shot.Left = Left;
				shot.Image = Image.FromFile("fireballEsq.gif");
				shot.Top = Top + 160;
				
				Tiros.Add(shot);
			}
		}

		void tiroMov_Tick(object sender, EventArgs e)
		{
			foreach (Tiro tiro in Tiros) {
				if (tiro.Left > -150) {
					tiro.Left -= 3 * spd;
				} else tiro.Dispose();
			}
		}
	}
}
