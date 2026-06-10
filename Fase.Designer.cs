namespace JogoGargula
{
	partial class Fase
	{
		System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.PassouDeFase = new System.Windows.Forms.Timer(this.components);
			this.Collision = new System.Windows.Forms.Timer(this.components);
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.drgnMovement = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// PassouDeFase
			// 
			this.PassouDeFase.Enabled = true;
			this.PassouDeFase.Interval = 10;
			this.PassouDeFase.Tick += new System.EventHandler(this.PassouDeFaseTick);
			// 
			// Collision
			// 
			this.Collision.Enabled = true;
			this.Collision.Interval = 10;
			this.Collision.Tick += new System.EventHandler(this.CollisionTick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(997, 338);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(0, 0);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.TabStop = false;
			this.richTextBox1.Text = "";
			// 
			// drgnMovement
			// 
			this.drgnMovement.Enabled = true;
			this.drgnMovement.Interval = 20;
			this.drgnMovement.Tick += new System.EventHandler(this.DrgnMovementTick);
			// 
			// Fase
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Fase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fase1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaseFormClosing);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Timer PassouDeFase;
		private System.Windows.Forms.Timer Collision;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Timer drgnMovement;
	}
}
