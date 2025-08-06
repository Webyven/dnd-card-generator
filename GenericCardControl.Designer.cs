namespace DnDCardGenerator
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
			this.pctIcon = new System.Windows.Forms.PictureBox();
			this.lblName = new System.Windows.Forms.Label();
			this.flowDescriptionPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.lblClass = new System.Windows.Forms.Label();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.Transparent;
			this.topPanel.BackgroundImage = global::DnDCardGenerator.Properties.Resources.GenericLine;
			this.topPanel.Controls.Add(this.pctIcon);
			this.topPanel.Controls.Add(this.lblName);
			this.topPanel.Location = new System.Drawing.Point(72, 109);
			this.topPanel.Name = "topPanel";
			this.topPanel.ShadowDecoration.Parent = this.topPanel;
			this.topPanel.Size = new System.Drawing.Size(702, 90);
			this.topPanel.TabIndex = 1;
			// 
			// pctIcon
			// 
			this.pctIcon.Image = global::DnDCardGenerator.Properties.Resources.Fighter_White;
			this.pctIcon.Location = new System.Drawing.Point(28, 15);
			this.pctIcon.Name = "pctIcon";
			this.pctIcon.Size = new System.Drawing.Size(60, 60);
			this.pctIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctIcon.TabIndex = 2;
			this.pctIcon.TabStop = false;
			// 
			// lblName
			// 
			this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblName.AutoEllipsis = true;
			this.lblName.Font = new System.Drawing.Font("Ringbearer", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(95, 13);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(596, 73);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Agarrar (Grapple)";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowDescriptionPanel
			// 
			this.flowDescriptionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowDescriptionPanel.Location = new System.Drawing.Point(72, 225);
			this.flowDescriptionPanel.Name = "flowDescriptionPanel";
			this.flowDescriptionPanel.Size = new System.Drawing.Size(685, 796);
			this.flowDescriptionPanel.TabIndex = 21;
			// 
			// lblClass
			// 
			this.lblClass.Font = new System.Drawing.Font("Bookinsanity Remake", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClass.Location = new System.Drawing.Point(147, 1033);
			this.lblClass.Name = "lblClass";
			this.lblClass.Size = new System.Drawing.Size(543, 28);
			this.lblClass.TabIndex = 22;
			this.lblClass.Text = "OBJETO";
			this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GenericCardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DnDCardGenerator.Properties.Resources.Borde_Carta;
			this.Controls.Add(this.lblClass);
			this.Controls.Add(this.flowDescriptionPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "GenericCardControl";
			this.Size = new System.Drawing.Size(822, 1122);
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel topPanel;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.PictureBox pctIcon;
		private System.Windows.Forms.FlowLayoutPanel flowDescriptionPanel;
		private System.Windows.Forms.Label lblClass;
	}
}
