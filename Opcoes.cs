 using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoGargula
{
	public partial class Opcoes : Form
	{
		public Opcoes()
		{
			InitializeComponent();
			richTextBox1.LoadFile("options.txt");
			
			string[] opcoes = richTextBox1.Lines;
			
			int gargHp = int.Parse((opcoes[0].Split(' '))[1]);
			int gargAtk = int.Parse((opcoes[2].Split(' '))[1]);
			int gargSpd = int.Parse((opcoes[4].Split(' '))[1]);
			int gargDef = int.Parse((opcoes[6].Split(' '))[1]);
			int dragHp = int.Parse((opcoes[1].Split(' '))[1]);
			int dragAtk = int.Parse((opcoes[3].Split(' '))[1]);
			int dragSpd = int.Parse((opcoes[5].Split(' '))[1]);
			int dragDef = int.Parse((opcoes[7].Split(' '))[1]);
			
			hpHero.Text = gargHp.ToString();
			hpVillain.Text = dragHp.ToString();
			atkHero.Text = gargAtk.ToString();
			atkVillain.Text = dragAtk.ToString();
			
			spdHero.Text = gargSpd.ToString();
			spdVillain.Text = dragSpd.ToString();
			defHero.Text = gargDef.ToString();
			defVillain.Text = dragDef.ToString();
		}
		void Button1Click(object sender, EventArgs e)
		{
			string opt1 = hpHero.Text;
			string opt2 = hpVillain.Text;

			richTextBox1.Text = 
				"Vida-Heroi: " + hpHero.Text + '\n' +
				"Vida-Vilao: " + hpVillain.Text + '\n' +
				"Ataque-Heroi: " + atkHero.Text + '\n' +
				"Ataque-Vilao: " + atkVillain.Text + '\n' +
				"Speed-Heroi: " + spdHero.Text + '\n' +
				"Speed-Vilao: " + spdVillain.Text + '\n' +
				"Defesa-Heroi: " + defHero.Text + '\n' +
				"Defesa-Vilao: " + defVillain.Text + '\n' +
				"Largura-Vilao " + optWidth.Text + '\n' +
				"Altura-Vilao " + optHeight.Text + '\n'
				;
			richTextBox1.SaveFile("options.txt");
			
			Dispose();
		}
	}
}