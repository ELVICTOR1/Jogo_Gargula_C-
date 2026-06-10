using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace JogoGargula
{
	public class Heroi : Personagem
	{
		public Heroi()
		{		
			// CONFIGS DO PERSONAGEM
			Image = Image.FromFile("Gargoyle.gif");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Top = 100;
			Width = 100;
			Height = 100;
			
			// MOVER PRA CIMA
			MovCima.Tick += MovCima_Tick;
			MovCima.Interval = 20;
			
			// MOVER PRA BAIXO
			MovBaixo.Tick += MovBaixo_Tick;
			MovBaixo.Interval = 20;
			
			// MOVER PRA DIREITA
			MovDireita.Tick += MovDireita_Tick;
			MovDireita.Interval = 20;
			
			// MOVER PRA ESQUERDA
			MovEsquerda.Tick += MovEsquerda_Tick;
			MovEsquerda.Interval = 20;
			
			// BARRA DE VIDA
			status.Parent = this;
			status.Top = 0;
			status.ForeColor = Color.White;
			status.Font = new Font("Microsoft Tai Lee", 20F);
			status.AutoSize = true;
			status.Text = hp.ToString();
			
			// BARRA DE TIRO
			tirosRestantes.Width = Width;
			tirosRestantes.Parent = this;
			tirosRestantes.Top = Height - tirosRestantes.Height;
			tirosRestantes.Maximum = 6;
			tirosRestantes.Value = 6;
			
			// MOVIMENTO DO TIRO
			tiroMov.Enabled = true;
			tiroMov.Interval = 20;
			tiroMov.Tick += tiroMov_Tick;
			
			// COOLDOWN DO TIRO
			tiroCooldown.Interval = 300;
			tiroCooldown.Tick += tiroCooldown_Tick;
			
			// RECARGA DO TIRO
			recoverTiro.Interval = 1000;
			recoverTiro.Enabled = true;
			recoverTiro.Tick += recoverTiro_Tick;
		}
		
		public Timer MovCima = new Timer();
		public Timer MovBaixo = new Timer();
		public Timer MovDireita = new Timer();
		public Timer MovEsquerda = new Timer();
		
		public Label status = new Label();
		public ProgressBar tirosRestantes = new ProgressBar();
		
		public Timer tiroMov = new Timer();
		public Timer tiroCooldown = new Timer();
		// ADICIONAR TICK E INTERVAL
		public Timer recoverTiro = new Timer();
		
		public int ladoX = 1;
		public bool canShoot;
		
		public List<Tiro> Tiros = new List<Tiro>();
		
		public void MovementKeyDown(object s, KeyEventArgs e){
			string tecla = e.KeyCode.ToString();
			
			if (canMove) {
				switch (tecla) {
				case "W": {
					MovCima.Enabled = true;
					MovBaixo.Enabled = false;
				}break;
				case "A": {
					MovEsquerda.Enabled = true;
					MovDireita.Enabled = false;
					if (ladoX == 1) {
						ladoX = -1;
						Image = Image.FromFile("GargoyleEsq.gif");
					}
				}break;
				case "S": {
					MovBaixo.Enabled = true;
					MovCima.Enabled = false;
				}break;
				case "D": {
					MovDireita.Enabled = true;
					MovEsquerda.Enabled = false;
					if (ladoX == -1) {
						ladoX = 1;
						Image = Image.FromFile("Gargoyle.gif");
					}
				}break;
				case "Space":{
					Image = Image.FromFile("Gargoyle.gif");
					if (tirosRestantes.Value != 0) {
						tirosRestantes.Value -= 1; 
					
						if (!tiroCooldown.Enabled && Tiro.canShoot) {
							Tiro tiro = new Tiro();
						
							Tiros.Add(tiro);
							tiro.Parent = Parent;
							tiro.Left = Left;
							tiro.Top = Top;
						}
							tiroCooldown.Enabled = true;
						}break;
					}
				}
			}
		}
		public void MovementKeyUp(object s, KeyEventArgs e){
			string tecla = e.KeyCode.ToString();
			
			if (canMove) {
				switch (tecla) {
					case "W": MovCima.Enabled = false;break;
					case "A": MovEsquerda.Enabled = false;break;
					case "S": MovBaixo.Enabled = false;break;
					case "D": MovDireita.Enabled = false;break;
				}
			}
		}
		
		void MovCima_Tick(object s, EventArgs e){
			if(canMove) Top -= spd;
		}
		void MovBaixo_Tick(object s, EventArgs e){
			if(canMove) Top += spd;
		}
		void MovDireita_Tick(object s, EventArgs e){
			if(canMove) Left += spd;
		}
		void MovEsquerda_Tick(object s, EventArgs e){
			if(canMove) Left -= spd;
		}
		
		void tiroMov_Tick(object sender, EventArgs e)
		{
			foreach (Tiro tiro in Tiros) {
				if (tiro.Left > -150) {
					tiro.Left += 3 * spd;
				} else tiro.Dispose();
			}
		}

		void tiroCooldown_Tick(object sender, EventArgs e)
		{
			tiroCooldown.Enabled = false;
		}

		void recoverTiro_Tick(object sender, EventArgs e)
		{
			if (tirosRestantes.Value < 6) {
				tirosRestantes.Value += 1;
			}
			
		}
	}
}
