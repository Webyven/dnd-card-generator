namespace SpellCardsDnDGenerator
{
	partial class SpellCardControl
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
			this.lblRitual = new System.Windows.Forms.Label();
			this.lblLevel = new System.Windows.Forms.Label();
			this.lblSpellName = new System.Windows.Forms.Label();
			this.panelRandom = new System.Windows.Forms.Panel();
			this.lblSchool = new System.Windows.Forms.Label();
			this.panelSchool = new Guna.UI2.WinForms.Guna2Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRange = new System.Windows.Forms.Label();
			this.lblCastTime = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblVerbal = new System.Windows.Forms.Label();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblSovietic = new System.Windows.Forms.Label();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblMaterial = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblDuration = new System.Windows.Forms.Label();
			this.pctConcentration = new System.Windows.Forms.PictureBox();
			this.lblClass = new System.Windows.Forms.Label();
			this.lblMaterialGold = new System.Windows.Forms.Label();
			this.flowDescriptionPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.topPanel.SuspendLayout();
			this.panelRandom.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctConcentration)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.Transparent;
			this.topPanel.BackgroundImage = global::SpellCardsDnDGenerator.Properties.Resources.BarbarianLine;
			this.topPanel.Controls.Add(this.lblRitual);
			this.topPanel.Controls.Add(this.lblLevel);
			this.topPanel.Controls.Add(this.lblSpellName);
			this.topPanel.Location = new System.Drawing.Point(72, 109);
			this.topPanel.Name = "topPanel";
			this.topPanel.ShadowDecoration.Parent = this.topPanel;
			this.topPanel.Size = new System.Drawing.Size(702, 120);
			this.topPanel.TabIndex = 0;
			// 
			// lblRitual
			// 
			this.lblRitual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRitual.AutoEllipsis = true;
			this.lblRitual.Font = new System.Drawing.Font("Ringbearer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRitual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.lblRitual.Location = new System.Drawing.Point(577, 70);
			this.lblRitual.Name = "lblRitual";
			this.lblRitual.Size = new System.Drawing.Size(104, 33);
			this.lblRitual.TabIndex = 3;
			this.lblRitual.Text = "Ritual";
			this.lblRitual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLevel
			// 
			this.lblLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLevel.AutoEllipsis = true;
			this.lblLevel.Font = new System.Drawing.Font("Ringbearer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.lblLevel.Location = new System.Drawing.Point(133, 72);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(442, 30);
			this.lblLevel.TabIndex = 2;
			this.lblLevel.Text = "Conjuro Nivel 1";
			this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSpellName
			// 
			this.lblSpellName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSpellName.AutoEllipsis = true;
			this.lblSpellName.Font = new System.Drawing.Font("Ringbearer", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpellName.Location = new System.Drawing.Point(125, 18);
			this.lblSpellName.Name = "lblSpellName";
			this.lblSpellName.Size = new System.Drawing.Size(566, 50);
			this.lblSpellName.TabIndex = 1;
			this.lblSpellName.Text = "Proyectil Guía";
			this.lblSpellName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// panelRandom
			// 
			this.panelRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(98)))), ((int)(((byte)(62)))));
			this.panelRandom.Controls.Add(this.lblSchool);
			this.panelRandom.Controls.Add(this.panelSchool);
			this.panelRandom.Location = new System.Drawing.Point(51, 480);
			this.panelRandom.Name = "panelRandom";
			this.panelRandom.Size = new System.Drawing.Size(723, 90);
			this.panelRandom.TabIndex = 1;
			// 
			// lblSchool
			// 
			this.lblSchool.Font = new System.Drawing.Font("Mr Eaves SC Remake Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSchool.Location = new System.Drawing.Point(139, 19);
			this.lblSchool.Name = "lblSchool";
			this.lblSchool.Size = new System.Drawing.Size(419, 52);
			this.lblSchool.TabIndex = 12;
			this.lblSchool.Text = "Evocación";
			this.lblSchool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelSchool
			// 
			this.panelSchool.BackColor = System.Drawing.Color.Transparent;
			this.panelSchool.BackgroundImage = global::SpellCardsDnDGenerator.Properties.Resources.Evocation;
			this.panelSchool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelSchool.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelSchool.FillColor = System.Drawing.Color.Transparent;
			this.panelSchool.ForeColor = System.Drawing.Color.Transparent;
			this.panelSchool.Location = new System.Drawing.Point(54, 13);
			this.panelSchool.Name = "panelSchool";
			this.panelSchool.ShadowDecoration.Parent = this.panelSchool;
			this.panelSchool.Size = new System.Drawing.Size(64, 64);
			this.panelSchool.TabIndex = 5;
			this.panelSchool.UseTransparentBackground = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MPlantin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(92, 260);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 41);
			this.label1.TabIndex = 3;
			this.label1.Text = "Rango:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MPlantin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(92, 329);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 41);
			this.label3.TabIndex = 4;
			this.label3.Text = "Duración:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MPlantin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(92, 398);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(299, 41);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tiempo de casteo:";
			// 
			// lblRange
			// 
			this.lblRange.Font = new System.Drawing.Font("MPlantin-Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRange.Location = new System.Drawing.Point(215, 260);
			this.lblRange.Name = "lblRange";
			this.lblRange.Size = new System.Drawing.Size(434, 42);
			this.lblRange.TabIndex = 6;
			this.lblRange.Text = "120 pies";
			this.lblRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCastTime
			// 
			this.lblCastTime.Font = new System.Drawing.Font("MPlantin-Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCastTime.Location = new System.Drawing.Point(387, 398);
			this.lblCastTime.Name = "lblCastTime";
			this.lblCastTime.Size = new System.Drawing.Size(262, 42);
			this.lblCastTime.TabIndex = 8;
			this.lblCastTime.Text = "Acción";
			this.lblCastTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.guna2Panel1.BorderThickness = 1;
			this.guna2Panel1.Controls.Add(this.lblVerbal);
			this.guna2Panel1.Location = new System.Drawing.Point(669, 249);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Padding = new System.Windows.Forms.Padding(2);
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(64, 64);
			this.guna2Panel1.TabIndex = 14;
			// 
			// lblVerbal
			// 
			this.lblVerbal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblVerbal.Font = new System.Drawing.Font("MPlantin-Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVerbal.ForeColor = System.Drawing.Color.Black;
			this.lblVerbal.Location = new System.Drawing.Point(2, 2);
			this.lblVerbal.Name = "lblVerbal";
			this.lblVerbal.Size = new System.Drawing.Size(60, 60);
			this.lblVerbal.TabIndex = 0;
			this.lblVerbal.Text = "V";
			this.lblVerbal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.guna2Panel2.BorderThickness = 1;
			this.guna2Panel2.Controls.Add(this.lblSovietic);
			this.guna2Panel2.Location = new System.Drawing.Point(669, 319);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Padding = new System.Windows.Forms.Padding(2);
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(64, 64);
			this.guna2Panel2.TabIndex = 15;
			// 
			// lblSovietic
			// 
			this.lblSovietic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSovietic.Font = new System.Drawing.Font("MPlantin-Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSovietic.ForeColor = System.Drawing.Color.Black;
			this.lblSovietic.Location = new System.Drawing.Point(2, 2);
			this.lblSovietic.Name = "lblSovietic";
			this.lblSovietic.Size = new System.Drawing.Size(60, 60);
			this.lblSovietic.TabIndex = 1;
			this.lblSovietic.Text = "S";
			this.lblSovietic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.guna2Panel3.BorderThickness = 1;
			this.guna2Panel3.Controls.Add(this.lblMaterial);
			this.guna2Panel3.Location = new System.Drawing.Point(669, 388);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Padding = new System.Windows.Forms.Padding(2);
			this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
			this.guna2Panel3.Size = new System.Drawing.Size(64, 64);
			this.guna2Panel3.TabIndex = 15;
			// 
			// lblMaterial
			// 
			this.lblMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMaterial.Font = new System.Drawing.Font("MPlantin-Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaterial.ForeColor = System.Drawing.Color.Silver;
			this.lblMaterial.Location = new System.Drawing.Point(2, 2);
			this.lblMaterial.Name = "lblMaterial";
			this.lblMaterial.Size = new System.Drawing.Size(60, 60);
			this.lblMaterial.TabIndex = 1;
			this.lblMaterial.Text = "M";
			this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.lblDuration);
			this.flowLayoutPanel1.Controls.Add(this.pctConcentration);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(261, 329);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 41);
			this.flowLayoutPanel1.TabIndex = 17;
			// 
			// lblDuration
			// 
			this.lblDuration.AutoSize = true;
			this.lblDuration.Font = new System.Drawing.Font("MPlantin-Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDuration.Location = new System.Drawing.Point(3, 0);
			this.lblDuration.Name = "lblDuration";
			this.lblDuration.Size = new System.Drawing.Size(140, 42);
			this.lblDuration.TabIndex = 7;
			this.lblDuration.Text = "1 turno";
			this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pctConcentration
			// 
			this.pctConcentration.Image = global::SpellCardsDnDGenerator.Properties.Resources.Concentration;
			this.pctConcentration.Location = new System.Drawing.Point(149, 3);
			this.pctConcentration.Name = "pctConcentration";
			this.pctConcentration.Size = new System.Drawing.Size(85, 39);
			this.pctConcentration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctConcentration.TabIndex = 8;
			this.pctConcentration.TabStop = false;
			// 
			// lblClass
			// 
			this.lblClass.Font = new System.Drawing.Font("Bookinsanity Remake", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClass.Location = new System.Drawing.Point(72, 1024);
			this.lblClass.Name = "lblClass";
			this.lblClass.Size = new System.Drawing.Size(691, 28);
			this.lblClass.TabIndex = 18;
			this.lblClass.Text = "MAGO";
			this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMaterialGold
			// 
			this.lblMaterialGold.Font = new System.Drawing.Font("MPlantin-Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaterialGold.Location = new System.Drawing.Point(669, 453);
			this.lblMaterialGold.Name = "lblMaterialGold";
			this.lblMaterialGold.Size = new System.Drawing.Size(64, 18);
			this.lblMaterialGold.TabIndex = 19;
			this.lblMaterialGold.Text = "000 PO*";
			this.lblMaterialGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMaterialGold.Visible = false;
			// 
			// flowDescriptionPanel
			// 
			this.flowDescriptionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowDescriptionPanel.Location = new System.Drawing.Point(99, 603);
			this.flowDescriptionPanel.Name = "flowDescriptionPanel";
			this.flowDescriptionPanel.Size = new System.Drawing.Size(634, 413);
			this.flowDescriptionPanel.TabIndex = 20;
			// 
			// SpellCardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SpellCardsDnDGenerator.Properties.Resources.Borde_Carta;
			this.Controls.Add(this.flowDescriptionPanel);
			this.Controls.Add(this.lblMaterialGold);
			this.Controls.Add(this.lblClass);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.lblCastTime);
			this.Controls.Add(this.lblRange);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelRandom);
			this.Controls.Add(this.topPanel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "SpellCardControl";
			this.Size = new System.Drawing.Size(822, 1122);
			this.topPanel.ResumeLayout(false);
			this.panelRandom.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel3.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctConcentration)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel topPanel;
		private System.Windows.Forms.Panel panelRandom;
		private System.Windows.Forms.Label lblSpellName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRange;
		private System.Windows.Forms.Label lblCastTime;
		private System.Windows.Forms.Label lblSchool;
		private System.Windows.Forms.Label lblLevel;
		private Guna.UI2.WinForms.Guna2Panel panelSchool;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Label lblVerbal;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private System.Windows.Forms.Label lblSovietic;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private System.Windows.Forms.Label lblMaterial;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.PictureBox pctConcentration;
		private System.Windows.Forms.Label lblRitual;
		private System.Windows.Forms.Label lblDuration;
		private System.Windows.Forms.Label lblClass;
		private System.Windows.Forms.Label lblMaterialGold;
		private System.Windows.Forms.FlowLayoutPanel flowDescriptionPanel;
	}
}
