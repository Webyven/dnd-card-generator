namespace SpellCardsDnDGenerator
{
	partial class GenericCardControl
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.lblSpellName = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.Transparent;
			this.topPanel.BackgroundImage = global::SpellCardsDnDGenerator.Properties.Resources.GenericLine;
			this.topPanel.Controls.Add(this.pictureBox1);
			this.topPanel.Controls.Add(this.lblSpellName);
			this.topPanel.Location = new System.Drawing.Point(72, 109);
			this.topPanel.Name = "topPanel";
			this.topPanel.ShadowDecoration.Parent = this.topPanel;
			this.topPanel.Size = new System.Drawing.Size(702, 90);
			this.topPanel.TabIndex = 1;
			// 
			// lblSpellName
			// 
			this.lblSpellName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSpellName.AutoEllipsis = true;
			this.lblSpellName.Font = new System.Drawing.Font("Ringbearer", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpellName.ForeColor = System.Drawing.Color.White;
			this.lblSpellName.Location = new System.Drawing.Point(95, 13);
			this.lblSpellName.Name = "lblSpellName";
			this.lblSpellName.Size = new System.Drawing.Size(596, 73);
			this.lblSpellName.TabIndex = 1;
			this.lblSpellName.Text = "Proyectil Guía";
			this.lblSpellName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SpellCardsDnDGenerator.Properties.Resources.Fighter_White;
			this.pictureBox1.Location = new System.Drawing.Point(28, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 60);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// ObjectCardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SpellCardsDnDGenerator.Properties.Resources.Borde_Carta;
			this.Controls.Add(this.topPanel);
			this.Name = "ObjectCardControl";
			this.Size = new System.Drawing.Size(822, 1122);
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel topPanel;
		private System.Windows.Forms.Label lblSpellName;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
