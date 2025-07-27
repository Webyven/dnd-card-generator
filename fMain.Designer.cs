namespace SpellCardsDnDGenerator
{
	partial class fMain
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

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRange = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDuration = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCastingTime = new Guna.UI2.WinForms.Guna2TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbClass = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnExport = new Guna.UI2.WinForms.Guna2GradientButton();
			this.cbSchool = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbConcentration = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbMaterial = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbVerbal = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbSovietic = new Guna.UI2.WinForms.Guna2CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pctPreviewCard = new System.Windows.Forms.PictureBox();
			this.btnImport = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnExportJSON = new Guna.UI2.WinForms.Guna2GradientButton();
			this.cbRitual = new Guna.UI2.WinForms.Guna2CheckBox();
			this.txtMaterialCost = new Guna.UI2.WinForms.Guna2TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtLevel = new Guna.UI2.WinForms.Guna2TextBox();
			this.lblLevel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctPreviewCard)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// txtName
			// 
			this.txtName.Animated = true;
			this.txtName.BorderRadius = 5;
			this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtName.DefaultText = "Proyectil Guía";
			this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtName.DisabledState.Parent = this.txtName;
			this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtName.FocusedState.Parent = this.txtName;
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.txtName.HoverState.Parent = this.txtName;
			this.txtName.Location = new System.Drawing.Point(34, 47);
			this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = '\0';
			this.txtName.PlaceholderText = "";
			this.txtName.SelectedText = "";
			this.txtName.SelectionStart = 14;
			this.txtName.ShadowDecoration.Parent = this.txtName;
			this.txtName.Size = new System.Drawing.Size(283, 36);
			this.txtName.TabIndex = 1;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Clase";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(318, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Escuela";
			// 
			// txtRange
			// 
			this.txtRange.Animated = true;
			this.txtRange.BorderRadius = 5;
			this.txtRange.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRange.DefaultText = "120 pies";
			this.txtRange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtRange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtRange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtRange.DisabledState.Parent = this.txtRange;
			this.txtRange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtRange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtRange.FocusedState.Parent = this.txtRange;
			this.txtRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtRange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.txtRange.HoverState.Parent = this.txtRange;
			this.txtRange.Location = new System.Drawing.Point(34, 202);
			this.txtRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtRange.Name = "txtRange";
			this.txtRange.PasswordChar = '\0';
			this.txtRange.PlaceholderText = "";
			this.txtRange.SelectedText = "";
			this.txtRange.SelectionStart = 8;
			this.txtRange.ShadowDecoration.Parent = this.txtRange;
			this.txtRange.Size = new System.Drawing.Size(573, 36);
			this.txtRange.TabIndex = 6;
			this.txtRange.TextChanged += new System.EventHandler(this.txtRange_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Rango";
			// 
			// txtDuration
			// 
			this.txtDuration.Animated = true;
			this.txtDuration.BorderRadius = 5;
			this.txtDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDuration.DefaultText = "1 turno";
			this.txtDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtDuration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDuration.DisabledState.Parent = this.txtDuration;
			this.txtDuration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtDuration.FocusedState.Parent = this.txtDuration;
			this.txtDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtDuration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.txtDuration.HoverState.Parent = this.txtDuration;
			this.txtDuration.Location = new System.Drawing.Point(34, 284);
			this.txtDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.PasswordChar = '\0';
			this.txtDuration.PlaceholderText = "";
			this.txtDuration.SelectedText = "";
			this.txtDuration.SelectionStart = 7;
			this.txtDuration.ShadowDecoration.Parent = this.txtDuration;
			this.txtDuration.Size = new System.Drawing.Size(573, 36);
			this.txtDuration.TabIndex = 7;
			this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Duración";
			// 
			// txtCastingTime
			// 
			this.txtCastingTime.Animated = true;
			this.txtCastingTime.BorderRadius = 5;
			this.txtCastingTime.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCastingTime.DefaultText = "Acción";
			this.txtCastingTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtCastingTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtCastingTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCastingTime.DisabledState.Parent = this.txtCastingTime;
			this.txtCastingTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCastingTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtCastingTime.FocusedState.Parent = this.txtCastingTime;
			this.txtCastingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtCastingTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.txtCastingTime.HoverState.Parent = this.txtCastingTime;
			this.txtCastingTime.Location = new System.Drawing.Point(34, 367);
			this.txtCastingTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCastingTime.Name = "txtCastingTime";
			this.txtCastingTime.PasswordChar = '\0';
			this.txtCastingTime.PlaceholderText = "";
			this.txtCastingTime.SelectedText = "";
			this.txtCastingTime.SelectionStart = 6;
			this.txtCastingTime.ShadowDecoration.Parent = this.txtCastingTime;
			this.txtCastingTime.Size = new System.Drawing.Size(573, 36);
			this.txtCastingTime.TabIndex = 9;
			this.txtCastingTime.TextChanged += new System.EventHandler(this.txtCastingTime_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(31, 346);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Tiempo de casteo";
			// 
			// txtDescription
			// 
			this.txtDescription.AcceptsReturn = true;
			this.txtDescription.AcceptsTab = true;
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtDescription.Animated = true;
			this.txtDescription.BorderRadius = 5;
			this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDescription.DefaultText = resources.GetString("txtDescription.DefaultText");
			this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDescription.DisabledState.Parent = this.txtDescription;
			this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtDescription.FocusedState.Parent = this.txtDescription;
			this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.txtDescription.HoverState.Parent = this.txtDescription;
			this.txtDescription.Location = new System.Drawing.Point(34, 531);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.PasswordChar = '\0';
			this.txtDescription.PlaceholderText = "";
			this.txtDescription.SelectedText = "";
			this.txtDescription.SelectionStart = 349;
			this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
			this.txtDescription.Size = new System.Drawing.Size(573, 49);
			this.txtDescription.TabIndex = 14;
			this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(31, 510);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Descripción";
			// 
			// cbClass
			// 
			this.cbClass.Animated = true;
			this.cbClass.BackColor = System.Drawing.Color.Transparent;
			this.cbClass.BorderRadius = 5;
			this.cbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbClass.FocusedColor = System.Drawing.Color.Empty;
			this.cbClass.FocusedState.Parent = this.cbClass;
			this.cbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbClass.FormattingEnabled = true;
			this.cbClass.HoverState.Parent = this.cbClass;
			this.cbClass.ItemHeight = 30;
			this.cbClass.Items.AddRange(new object[] {
            "Bardo",
            "Bárbaro",
            "Paladin",
            "Explorador",
            "Clérigo",
            "Pícaro",
            "Druida",
            "Hechicero",
            "Guerrero",
            "Brujo",
            "Monje",
            "Mago"});
			this.cbClass.ItemsAppearance.Parent = this.cbClass;
			this.cbClass.Location = new System.Drawing.Point(34, 124);
			this.cbClass.Name = "cbClass";
			this.cbClass.ShadowDecoration.Parent = this.cbClass;
			this.cbClass.Size = new System.Drawing.Size(283, 36);
			this.cbClass.StartIndex = 1;
			this.cbClass.TabIndex = 4;
			this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExport.Animated = true;
			this.btnExport.BorderRadius = 5;
			this.btnExport.CheckedState.Parent = this.btnExport;
			this.btnExport.CustomImages.Parent = this.btnExport;
			this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.btnExport.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExport.ForeColor = System.Drawing.Color.White;
			this.btnExport.HoverState.Parent = this.btnExport;
			this.btnExport.Location = new System.Drawing.Point(34, 597);
			this.btnExport.Name = "btnExport";
			this.btnExport.ShadowDecoration.Parent = this.btnExport;
			this.btnExport.Size = new System.Drawing.Size(180, 37);
			this.btnExport.TabIndex = 15;
			this.btnExport.Text = "Exportar como imagen";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// cbSchool
			// 
			this.cbSchool.Animated = true;
			this.cbSchool.BackColor = System.Drawing.Color.Transparent;
			this.cbSchool.BorderRadius = 5;
			this.cbSchool.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSchool.FocusedColor = System.Drawing.Color.Empty;
			this.cbSchool.FocusedState.Parent = this.cbSchool;
			this.cbSchool.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbSchool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbSchool.FormattingEnabled = true;
			this.cbSchool.HoverState.Parent = this.cbSchool;
			this.cbSchool.ItemHeight = 30;
			this.cbSchool.Items.AddRange(new object[] {
            "Ilusión",
            "Encantamiento",
            "Adivinación",
            "Necromancia",
            "Evocación",
            "Conjuración",
            "Transmutación",
            "Abjuración"});
			this.cbSchool.ItemsAppearance.Parent = this.cbSchool;
			this.cbSchool.Location = new System.Drawing.Point(324, 124);
			this.cbSchool.Name = "cbSchool";
			this.cbSchool.ShadowDecoration.Parent = this.cbSchool;
			this.cbSchool.Size = new System.Drawing.Size(283, 36);
			this.cbSchool.StartIndex = 4;
			this.cbSchool.TabIndex = 5;
			this.cbSchool.SelectedIndexChanged += new System.EventHandler(this.cbSchool_SelectedIndexChanged);
			// 
			// cbConcentration
			// 
			this.cbConcentration.Animated = true;
			this.cbConcentration.AutoSize = true;
			this.cbConcentration.Checked = true;
			this.cbConcentration.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbConcentration.CheckedState.BorderRadius = 2;
			this.cbConcentration.CheckedState.BorderThickness = 0;
			this.cbConcentration.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbConcentration.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbConcentration.Location = new System.Drawing.Point(516, 259);
			this.cbConcentration.Name = "cbConcentration";
			this.cbConcentration.Size = new System.Drawing.Size(95, 17);
			this.cbConcentration.TabIndex = 8;
			this.cbConcentration.Text = "Concentración";
			this.cbConcentration.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbConcentration.UncheckedState.BorderRadius = 2;
			this.cbConcentration.UncheckedState.BorderThickness = 0;
			this.cbConcentration.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbConcentration.UseVisualStyleBackColor = true;
			this.cbConcentration.CheckedChanged += new System.EventHandler(this.cbSovietic_CheckedChanged);
			// 
			// cbMaterial
			// 
			this.cbMaterial.Animated = true;
			this.cbMaterial.AutoSize = true;
			this.cbMaterial.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbMaterial.CheckedState.BorderRadius = 2;
			this.cbMaterial.CheckedState.BorderThickness = 0;
			this.cbMaterial.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbMaterial.Location = new System.Drawing.Point(217, 464);
			this.cbMaterial.Name = "cbMaterial";
			this.cbMaterial.Size = new System.Drawing.Size(63, 17);
			this.cbMaterial.TabIndex = 12;
			this.cbMaterial.Text = "Material";
			this.cbMaterial.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbMaterial.UncheckedState.BorderRadius = 2;
			this.cbMaterial.UncheckedState.BorderThickness = 0;
			this.cbMaterial.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbMaterial.UseVisualStyleBackColor = true;
			this.cbMaterial.CheckedChanged += new System.EventHandler(this.cbSovietic_CheckedChanged);
			// 
			// cbVerbal
			// 
			this.cbVerbal.Animated = true;
			this.cbVerbal.AutoSize = true;
			this.cbVerbal.Checked = true;
			this.cbVerbal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbVerbal.CheckedState.BorderRadius = 2;
			this.cbVerbal.CheckedState.BorderThickness = 0;
			this.cbVerbal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbVerbal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbVerbal.Location = new System.Drawing.Point(50, 464);
			this.cbVerbal.Name = "cbVerbal";
			this.cbVerbal.Size = new System.Drawing.Size(56, 17);
			this.cbVerbal.TabIndex = 10;
			this.cbVerbal.Text = "Verbal";
			this.cbVerbal.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbVerbal.UncheckedState.BorderRadius = 2;
			this.cbVerbal.UncheckedState.BorderThickness = 0;
			this.cbVerbal.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbVerbal.UseVisualStyleBackColor = true;
			this.cbVerbal.CheckedChanged += new System.EventHandler(this.cbSovietic_CheckedChanged);
			// 
			// cbSovietic
			// 
			this.cbSovietic.Animated = true;
			this.cbSovietic.AutoSize = true;
			this.cbSovietic.Checked = true;
			this.cbSovietic.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbSovietic.CheckedState.BorderRadius = 2;
			this.cbSovietic.CheckedState.BorderThickness = 0;
			this.cbSovietic.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbSovietic.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSovietic.Location = new System.Drawing.Point(127, 464);
			this.cbSovietic.Name = "cbSovietic";
			this.cbSovietic.Size = new System.Drawing.Size(70, 17);
			this.cbSovietic.TabIndex = 11;
			this.cbSovietic.Text = "Somatico";
			this.cbSovietic.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbSovietic.UncheckedState.BorderRadius = 2;
			this.cbSovietic.UncheckedState.BorderThickness = 0;
			this.cbSovietic.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbSovietic.UseVisualStyleBackColor = true;
			this.cbSovietic.CheckedChanged += new System.EventHandler(this.cbSovietic_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(31, 434);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "Componentes";
			// 
			// pctPreviewCard
			// 
			this.pctPreviewCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pctPreviewCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pctPreviewCard.Location = new System.Drawing.Point(642, 12);
			this.pctPreviewCard.Name = "pctPreviewCard";
			this.pctPreviewCard.Size = new System.Drawing.Size(489, 628);
			this.pctPreviewCard.TabIndex = 26;
			this.pctPreviewCard.TabStop = false;
			// 
			// btnImport
			// 
			this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnImport.Animated = true;
			this.btnImport.BorderRadius = 5;
			this.btnImport.CheckedState.Parent = this.btnImport;
			this.btnImport.CustomImages.Parent = this.btnImport;
			this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.btnImport.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImport.ForeColor = System.Drawing.Color.White;
			this.btnImport.HoverState.Parent = this.btnImport;
			this.btnImport.Location = new System.Drawing.Point(427, 597);
			this.btnImport.Name = "btnImport";
			this.btnImport.ShadowDecoration.Parent = this.btnImport;
			this.btnImport.Size = new System.Drawing.Size(180, 37);
			this.btnImport.TabIndex = 17;
			this.btnImport.Text = "Importar JSON";
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnExportJSON
			// 
			this.btnExportJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExportJSON.Animated = true;
			this.btnExportJSON.BorderRadius = 5;
			this.btnExportJSON.CheckedState.Parent = this.btnExportJSON;
			this.btnExportJSON.CustomImages.Parent = this.btnExportJSON;
			this.btnExportJSON.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.btnExportJSON.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnExportJSON.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportJSON.ForeColor = System.Drawing.Color.White;
			this.btnExportJSON.HoverState.Parent = this.btnExportJSON;
			this.btnExportJSON.Location = new System.Drawing.Point(231, 597);
			this.btnExportJSON.Name = "btnExportJSON";
			this.btnExportJSON.ShadowDecoration.Parent = this.btnExportJSON;
			this.btnExportJSON.Size = new System.Drawing.Size(180, 37);
			this.btnExportJSON.TabIndex = 16;
			this.btnExportJSON.Text = "Exportar a JSON";
			this.btnExportJSON.Click += new System.EventHandler(this.btnExportJSON_Click);
			// 
			// cbRitual
			// 
			this.cbRitual.Animated = true;
			this.cbRitual.AutoSize = true;
			this.cbRitual.Checked = true;
			this.cbRitual.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbRitual.CheckedState.BorderRadius = 2;
			this.cbRitual.CheckedState.BorderThickness = 0;
			this.cbRitual.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.cbRitual.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRitual.Location = new System.Drawing.Point(554, 22);
			this.cbRitual.Name = "cbRitual";
			this.cbRitual.Size = new System.Drawing.Size(53, 17);
			this.cbRitual.TabIndex = 3;
			this.cbRitual.Text = "Ritual";
			this.cbRitual.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbRitual.UncheckedState.BorderRadius = 2;
			this.cbRitual.UncheckedState.BorderThickness = 0;
			this.cbRitual.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbRitual.UseVisualStyleBackColor = true;
			this.cbRitual.CheckedChanged += new System.EventHandler(this.cbSovietic_CheckedChanged);
			// 
			// txtMaterialCost
			// 
			this.txtMaterialCost.Animated = true;
			this.txtMaterialCost.BorderRadius = 5;
			this.txtMaterialCost.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaterialCost.DefaultText = "000 PO*";
			this.txtMaterialCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaterialCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaterialCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaterialCost.DisabledState.Parent = this.txtMaterialCost;
			this.txtMaterialCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaterialCost.Enabled = false;
			this.txtMaterialCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtMaterialCost.FocusedState.Parent = this.txtMaterialCost;
			this.txtMaterialCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtMaterialCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.txtMaterialCost.HoverState.Parent = this.txtMaterialCost;
			this.txtMaterialCost.Location = new System.Drawing.Point(324, 455);
			this.txtMaterialCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaterialCost.Name = "txtMaterialCost";
			this.txtMaterialCost.PasswordChar = '\0';
			this.txtMaterialCost.PlaceholderText = "";
			this.txtMaterialCost.SelectedText = "";
			this.txtMaterialCost.SelectionStart = 7;
			this.txtMaterialCost.ShadowDecoration.Parent = this.txtMaterialCost;
			this.txtMaterialCost.Size = new System.Drawing.Size(283, 40);
			this.txtMaterialCost.TabIndex = 13;
			this.txtMaterialCost.TextChanged += new System.EventHandler(this.txtMaterialCost_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(321, 434);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 13);
			this.label9.TabIndex = 31;
			this.label9.Text = "Costo material";
			// 
			// txtLevel
			// 
			this.txtLevel.Animated = true;
			this.txtLevel.BorderRadius = 5;
			this.txtLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLevel.DefaultText = "Conjuro Nivel 1";
			this.txtLevel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtLevel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtLevel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLevel.DisabledState.Parent = this.txtLevel;
			this.txtLevel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtLevel.FocusedState.Parent = this.txtLevel;
			this.txtLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.txtLevel.HoverState.Parent = this.txtLevel;
			this.txtLevel.Location = new System.Drawing.Point(324, 47);
			this.txtLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtLevel.Name = "txtLevel";
			this.txtLevel.PasswordChar = '\0';
			this.txtLevel.PlaceholderText = "";
			this.txtLevel.SelectedText = "";
			this.txtLevel.SelectionStart = 15;
			this.txtLevel.ShadowDecoration.Parent = this.txtLevel;
			this.txtLevel.Size = new System.Drawing.Size(283, 36);
			this.txtLevel.TabIndex = 2;
			this.txtLevel.TextChanged += new System.EventHandler(this.txtLevel_TextChanged);
			// 
			// lblLevel
			// 
			this.lblLevel.AutoSize = true;
			this.lblLevel.Location = new System.Drawing.Point(321, 26);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(31, 13);
			this.lblLevel.TabIndex = 33;
			this.lblLevel.Text = "Nivel";
			// 
			// fMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 661);
			this.Controls.Add(this.txtLevel);
			this.Controls.Add(this.lblLevel);
			this.Controls.Add(this.txtMaterialCost);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cbRitual);
			this.Controls.Add(this.btnExportJSON);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.pctPreviewCard);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cbVerbal);
			this.Controls.Add(this.cbMaterial);
			this.Controls.Add(this.cbConcentration);
			this.Controls.Add(this.cbSchool);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.cbClass);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtCastingTime);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDuration);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtRange);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbSovietic);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1100, 700);
			this.Name = "fMain";
			this.Text = "D&D Card Generator";
			((System.ComponentModel.ISupportInitialize)(this.pctPreviewCard)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtRange;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox txtDuration;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2TextBox txtCastingTime;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2TextBox txtDescription;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2ComboBox cbClass;
		private Guna.UI2.WinForms.Guna2GradientButton btnExport;
		private Guna.UI2.WinForms.Guna2ComboBox cbSchool;
		private Guna.UI2.WinForms.Guna2CheckBox cbConcentration;
		private Guna.UI2.WinForms.Guna2CheckBox cbMaterial;
		private Guna.UI2.WinForms.Guna2CheckBox cbVerbal;
		private Guna.UI2.WinForms.Guna2CheckBox cbSovietic;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pctPreviewCard;
		private Guna.UI2.WinForms.Guna2GradientButton btnImport;
		private Guna.UI2.WinForms.Guna2GradientButton btnExportJSON;
		private Guna.UI2.WinForms.Guna2CheckBox cbRitual;
		private Guna.UI2.WinForms.Guna2TextBox txtMaterialCost;
		private System.Windows.Forms.Label label9;
		private Guna.UI2.WinForms.Guna2TextBox txtLevel;
		private System.Windows.Forms.Label lblLevel;
	}
}

