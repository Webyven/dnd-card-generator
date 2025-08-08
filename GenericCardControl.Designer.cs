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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblRarity = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.pctIcon = new System.Windows.Forms.PictureBox();
			this.lblName = new System.Windows.Forms.Label();
			this.flowDescriptionPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.lblBottomText = new System.Windows.Forms.Label();
			this.topPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.Transparent;
			this.topPanel.BackgroundImage = global::DnDCardGenerator.Properties.Resources.GenericLine;
			this.topPanel.Controls.Add(this.panel1);
			this.topPanel.Controls.Add(this.pctIcon);
			this.topPanel.Controls.Add(this.lblName);
			this.topPanel.Location = new System.Drawing.Point(72, 109);
			this.topPanel.Name = "topPanel";
			this.topPanel.ShadowDecoration.Parent = this.topPanel;
			this.topPanel.Size = new System.Drawing.Size(702, 120);
			this.topPanel.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblRarity);
			this.panel1.Controls.Add(this.lblType);
			this.panel1.Location = new System.Drawing.Point(121, 71);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(564, 37);
			this.panel1.TabIndex = 3;
			// 
			// lblRarity
			// 
			this.lblRarity.AutoEllipsis = true;
			this.lblRarity.AutoSize = true;
			this.lblRarity.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblRarity.Font = new System.Drawing.Font("Ringbearer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRarity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.lblRarity.Location = new System.Drawing.Point(457, 0);
			this.lblRarity.MaximumSize = new System.Drawing.Size(400, 0);
			this.lblRarity.Name = "lblRarity";
			this.lblRarity.Size = new System.Drawing.Size(107, 32);
			this.lblRarity.TabIndex = 4;
			this.lblRarity.Text = "Común";
			this.lblRarity.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblType
			// 
			this.lblType.AutoEllipsis = true;
			this.lblType.AutoSize = true;
			this.lblType.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblType.Font = new System.Drawing.Font("Ringbearer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.lblType.Location = new System.Drawing.Point(0, 0);
			this.lblType.MaximumSize = new System.Drawing.Size(400, 0);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(110, 32);
			this.lblType.TabIndex = 3;
			this.lblType.Text = "Acción";
			this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pctIcon
			// 
			this.pctIcon.Image = global::DnDCardGenerator.Properties.Resources.Fighter_White;
			this.pctIcon.Location = new System.Drawing.Point(28, 22);
			this.pctIcon.Name = "pctIcon";
			this.pctIcon.Size = new System.Drawing.Size(75, 75);
			this.pctIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctIcon.TabIndex = 2;
			this.pctIcon.TabStop = false;
			// 
			// lblName
			// 
			this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblName.AutoEllipsis = true;
			this.lblName.Font = new System.Drawing.Font("Ringbearer", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(112, 22);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(573, 45);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Agarrar (Grapple)";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// flowDescriptionPanel
			// 
			this.flowDescriptionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowDescriptionPanel.Location = new System.Drawing.Point(72, 247);
			this.flowDescriptionPanel.Name = "flowDescriptionPanel";
			this.flowDescriptionPanel.Size = new System.Drawing.Size(685, 774);
			this.flowDescriptionPanel.TabIndex = 21;
			// 
			// lblBottomText
			// 
			this.lblBottomText.Font = new System.Drawing.Font("Bookinsanity Remake", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBottomText.Location = new System.Drawing.Point(147, 1024);
			this.lblBottomText.Name = "lblBottomText";
			this.lblBottomText.Size = new System.Drawing.Size(543, 28);
			this.lblBottomText.TabIndex = 22;
			this.lblBottomText.Text = "OBJETO";
			this.lblBottomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GenericCardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DnDCardGenerator.Properties.Resources.Borde_Carta;
			this.Controls.Add(this.lblBottomText);
			this.Controls.Add(this.flowDescriptionPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "GenericCardControl";
			this.Size = new System.Drawing.Size(822, 1122);
			this.topPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel topPanel;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.PictureBox pctIcon;
		private System.Windows.Forms.FlowLayoutPanel flowDescriptionPanel;
		private System.Windows.Forms.Label lblBottomText;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblRarity;
		private System.Windows.Forms.Panel panel1;
	}
}
