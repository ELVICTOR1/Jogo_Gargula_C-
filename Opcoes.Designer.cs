/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 10/10/2025
 * Hora: 21:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace JogoGargula
{
	partial class Opcoes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox hpHero;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox hpVillain;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox atkHero;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox atkVillain;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox spdVillain;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox spdHero;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox defVillain;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox defHero;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox optHeight;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox optWidth;
		private System.Windows.Forms.Label label10;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.hpHero = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.hpVillain = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.atkHero = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.atkVillain = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.spdVillain = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.spdHero = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.defVillain = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.defHero = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.optHeight = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.optWidth = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(26, 444);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(199, 228);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "HP Herói:";
			// 
			// hpHero
			// 
			this.hpHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hpHero.Location = new System.Drawing.Point(53, 97);
			this.hpHero.Name = "hpHero";
			this.hpHero.Size = new System.Drawing.Size(122, 36);
			this.hpHero.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(254, 541);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// hpVillain
			// 
			this.hpVillain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hpVillain.Location = new System.Drawing.Point(270, 97);
			this.hpVillain.Name = "hpVillain";
			this.hpVillain.Size = new System.Drawing.Size(122, 36);
			this.hpVillain.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(270, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "HP Vilão:";
			// 
			// atkHero
			// 
			this.atkHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.atkHero.Location = new System.Drawing.Point(53, 189);
			this.atkHero.Name = "atkHero";
			this.atkHero.Size = new System.Drawing.Size(122, 36);
			this.atkHero.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(53, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "ATK Herói:";
			// 
			// atkVillain
			// 
			this.atkVillain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.atkVillain.Location = new System.Drawing.Point(270, 189);
			this.atkVillain.Name = "atkVillain";
			this.atkVillain.Size = new System.Drawing.Size(122, 36);
			this.atkVillain.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(270, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 29);
			this.label4.TabIndex = 8;
			this.label4.Text = "ATK Vilão:";
			// 
			// spdVillain
			// 
			this.spdVillain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spdVillain.Location = new System.Drawing.Point(270, 376);
			this.spdVillain.Name = "spdVillain";
			this.spdVillain.Size = new System.Drawing.Size(122, 36);
			this.spdVillain.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(270, 344);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 29);
			this.label5.TabIndex = 16;
			this.label5.Text = "SPD Vilão:";
			// 
			// spdHero
			// 
			this.spdHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spdHero.Location = new System.Drawing.Point(53, 376);
			this.spdHero.Name = "spdHero";
			this.spdHero.Size = new System.Drawing.Size(122, 36);
			this.spdHero.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(53, 344);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 29);
			this.label6.TabIndex = 14;
			this.label6.Text = "SPD Herói:";
			// 
			// defVillain
			// 
			this.defVillain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.defVillain.Location = new System.Drawing.Point(270, 278);
			this.defVillain.Name = "defVillain";
			this.defVillain.Size = new System.Drawing.Size(122, 36);
			this.defVillain.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(270, 246);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(134, 29);
			this.label7.TabIndex = 12;
			this.label7.Text = "DEF Vilão:";
			// 
			// defHero
			// 
			this.defHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.defHero.Location = new System.Drawing.Point(53, 278);
			this.defHero.Name = "defHero";
			this.defHero.Size = new System.Drawing.Size(122, 36);
			this.defHero.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(53, 246);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(137, 29);
			this.label8.TabIndex = 10;
			this.label8.Text = "DEF Herói:";
			// 
			// optHeight
			// 
			this.optHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optHeight.Location = new System.Drawing.Point(419, 189);
			this.optHeight.Name = "optHeight";
			this.optHeight.Size = new System.Drawing.Size(122, 36);
			this.optHeight.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(419, 157);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(157, 29);
			this.label9.TabIndex = 20;
			this.label9.Text = "Height Vilão:";
			// 
			// optWidth
			// 
			this.optWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optWidth.Location = new System.Drawing.Point(419, 97);
			this.optWidth.Name = "optWidth";
			this.optWidth.Size = new System.Drawing.Size(122, 36);
			this.optWidth.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(419, 65);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(149, 29);
			this.label10.TabIndex = 18;
			this.label10.Text = "Width Vilão:";
			// 
			// Opcoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 650);
			this.Controls.Add(this.optHeight);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.optWidth);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.spdVillain);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.spdHero);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.defVillain);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.defHero);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.atkVillain);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.atkHero);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.hpVillain);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hpHero);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Opcoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Opcoes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
