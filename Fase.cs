using System;
using System.Drawing;
using System.Windows.Forms;

using System.Threading.Tasks;
using System.Media;

namespace JogoGargula
{
	public partial class Fase: Form
	{
		public Fase(string cenarioName)
		{
			InitializeComponent();
			richTextBox1.LoadFile("options.txt");
			
			string[] opcoes = richTextBox1.Lines;			
			
			// CENÁRIO
			cenario.Parent = this;
			cenario.Dock = DockStyle.Fill;
			cenario.Image = Image.FromFile(cenarioName);
			cenario.SizeMode = PictureBoxSizeMode.StretchImage;
			
			// GARGULA
			gargula.Parent = cenario;
			int gargHp = int.Parse((opcoes[0].Split(' '))[1]);
			int gargAtk = int.Parse((opcoes[2].Split(' '))[1]);
			int gargSpd = int.Parse((opcoes[4].Split(' '))[1]);
			int gargDef = int.Parse((opcoes[6].Split(' '))[1]);
			gargula.hp = gargHp;
			gargula.atk = gargAtk;
			gargula.spd = gargSpd;
			gargula.def = gargDef;
			gargula.status.Text = gargHp.ToString();
			
			// DRAGAO
			dragao.Parent = cenario;
			dragao.canShoot = true;
			int dragHp = int.Parse((opcoes[1].Split(' '))[1]);
			int dragAtk = int.Parse((opcoes[3].Split(' '))[1]);
			int dragSpd = int.Parse((opcoes[5].Split(' '))[1]);
			int dragDef = int.Parse((opcoes[7].Split(' '))[1]);
			
			// 
			int dragWidth = int.Parse(opcoes[8].Split(' ')[1]);
			int dragHeigth = int.Parse(opcoes[9].Split(' ')[1]);
			//
			
			dragao.hp = dragHp;
			dragao.atk = dragAtk;
			dragao.spd = dragSpd;
			dragao.def = dragDef;
			dragao.status.Text = dragHp.ToString();
			dragao.Image = Image.FromFile("dragonEsq2.gif");
			
			// HITBOX DO DRAGAO
			drgnHitBox.Parent = cenario;
			drgnHitBox.Top = dragao.Top + 160;
			drgnHitBox.Left = dragao.Left;
			
			// EVENTOS DE TECLA
			KeyDown += gargula.MovementKeyDown;
			KeyUp += gargula.MovementKeyUp;
			
			Tiro.canShoot = true;
		}
		
		public static bool PassouFase;
		
		public static PictureBox cenario = new PictureBox();
		
		Heroi gargula = new Heroi();
		
						// WIDTH, HEIGHT
		Vilao dragao = new Vilao(200,200);
		HitBox drgnHitBox = new HitBox(150, 40);
		int yAxis = 1;
		
		void DrgnMovementTick(object sender, EventArgs e)
		{
			if ((drgnHitBox.Top < 0 || drgnHitBox.Top > Height - drgnHitBox.Height)) {
				yAxis *= -1;
			}
			
			if (dragao.canMove) {
				dragao.Top += dragao.spd * yAxis;
				drgnHitBox.Top += dragao.spd * yAxis;	
			}
		}
		
		async void PassouDeFaseTick(object sender, EventArgs e)
		{
			int drgnHp = int.Parse((richTextBox1.Lines[1].Split(' '))[1]);
			
			if (dragao.hp <= 0) {
				PassouDeFase.Enabled = false;
				
			 	SoundPlayer laugh = new SoundPlayer("laugh.wav");
				laugh.Play();
				
				dragao.Image = Image.FromFile("explosion.gif");
				dragao.status.Hide();
				
				Tiro.canShoot = false;
				gargula.canMove = false;
				
				dragao.canMove = false;
				
				await Task.Delay(4000);
				
				Personagem.Remove(drgnHitBox);
				Personagem.Remove(dragao);

				PassouFase = true;
				laugh.Stop();
				
				gargula.Image = Image.FromFile("Gargoyle.gif");
				while (gargula.Left < Width) {
					await Task.Delay(10);
					gargula.Left += 10;
				}
				foreach (Tiro tiro in gargula.Tiros) {
					Personagem.Remove(tiro);
					tiro.Dispose();
				}
				foreach (Tiro tiro in dragao.Tiros) {
					Personagem.Remove(tiro);
					tiro.Dispose();
				}
				dragao.canShoot = false;
				Personagem.Remove(dragao);
				Personagem.Remove(drgnHitBox);
				drgnHitBox.Dispose();
				dragao.Dispose();
				Hide();
			}
			
			if (dragao.hp < drgnHp / 2) {
				WindowState = FormWindowState.Maximized;
				
				dragao.Left = 1000;
				dragao.Width = 400;
				dragao.Height = 400;
				
				drgnHitBox.Left = 1000;
				drgnHitBox.Width= 300;
				drgnHitBox.Height = 80;
			}
			
			if (gargula.hp <= 0) {
				gargula.Left = 0;
				
				PassouDeFase.Enabled = false;
				dragao.enemyTiro.Enabled = false;
				Personagem.Remove(gargula);
				Personagem.Remove(drgnHitBox);
				Personagem.Remove(dragao);
				
				MessageBox.Show("Game over!");
				
				Hide();
			}
		}
		
		void CollisionTick(object sender, EventArgs e)
		{
			if (Personagem.Collision(gargula, drgnHitBox)) {
				if (dragao.atk > gargula.def) {
					gargula.Left -= dragao.Width;
					gargula.hp -= dragao.atk - gargula.def;
					gargula.status.Text = gargula.hp.ToString();
				}
			}
			foreach (Tiro shot in gargula.Tiros) {
				if (Personagem.Collision(drgnHitBox, shot)) {
					shot.Remove();
					if (gargula.atk > dragao.def) {
						dragao.hp -= gargula.atk - dragao.def;
						dragao.status.Text = dragao.hp.ToString();
					}
				}
				if (shot.Left > Width + shot.Width) {
					shot.Remove();
				}
			}
			foreach (Tiro drgnTiro in dragao.Tiros) {
				if (Personagem.Collision(gargula, drgnTiro)) {
					drgnTiro.Remove();
					gargula.hp -= dragao.atk - gargula.def;
					gargula.status.Text = gargula.hp.ToString();
				}
			}
			
		}
		
		void FaseFormClosing(object sender, FormClosingEventArgs e)
		{
			Controls.Clear();
		}
		

	}
}
