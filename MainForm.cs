using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoGargula
{
	public partial class MainForm : Form
	{

		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Hide();
			
			Fase fase1 = new Fase("cenario0.gif");
			fase1.ShowDialog();
			
			if (Fase.PassouFase) {
				MessageBox.Show("Indo pra segunda fase...");
				Fase.PassouFase = false;
							
				Fase fase2 = new Fase("cenario1.gif");
				fase2.ShowDialog();
			
				if (Fase.PassouFase) {
					MessageBox.Show("Indo pra terceira fase...");
					Fase.PassouFase = false;
					
					Fase fase3 = new Fase("cenario2.gif");
					fase3.ShowDialog();
					
					if (Fase.PassouFase) {
						MessageBox.Show("Parbéns!");
						Show();
					} else Application.Exit();
				} else Application.Exit();
			} else Application.Exit();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Hide();
			
			Opcoes opt = new Opcoes();
			opt.ShowDialog();
			
			Show();
		}
	}
}
