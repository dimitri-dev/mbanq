namespace PersonManagement
{
    public partial class PersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Person", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OIB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Name");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Surname");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Place");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Address");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Phone");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Mail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DateCreated");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DateUpdated");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DeleteButton", 0);
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EditButton", 1);
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.btn_Exit = new Infragistics.Win.Misc.UltraButton();
            this.btn_CreatePerson = new Infragistics.Win.Misc.UltraButton();
            this.input_searchPhrase = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_searchPhrase)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGrid1.CausesValidation = false;
            this.ultraGrid1.DataSource = this.personBindingSource;
            appearance1.BackColor = System.Drawing.Color.SlateBlue;
            appearance1.BackColor2 = System.Drawing.Color.SlateBlue;
            appearance1.FontData.BoldAsString = "True";
            appearance1.ForeColor = System.Drawing.Color.Black;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextTrimming = Infragistics.Win.TextTrimming.WordWithLineLimit;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            this.ultraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 446;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 153;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 252;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 240;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 256;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 243;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Width = 244;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Width = 250;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn9.Width = 226;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn10.Width = 261;
            ultraGridColumn11.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            ultraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            appearance2.BackColor = System.Drawing.Color.MediumSlateBlue;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            ultraGridColumn11.CellButtonAppearance = appearance2;
            ultraGridColumn11.DefaultCellValue = "Delete";
            ultraGridColumn11.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.True;
            ultraGridColumn11.Header.AllowEditing = Infragistics.Win.UltraWinGrid.AllowHeaderEditing.None;
            appearance3.BackColor = System.Drawing.Color.Transparent;
            appearance3.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance3.BorderColor = System.Drawing.Color.Transparent;
            appearance3.ForeColor = System.Drawing.Color.Transparent;
            ultraGridColumn11.Header.Appearance = appearance3;
            ultraGridColumn11.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None;
            ultraGridColumn11.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Never;
            ultraGridColumn11.Header.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            ultraGridColumn11.Header.VisiblePosition = 11;
            ultraGridColumn11.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled;
            ultraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn11.Width = 132;
            ultraGridColumn12.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            ultraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            appearance4.BackColor = System.Drawing.Color.MediumSlateBlue;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance4.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            ultraGridColumn12.CellButtonAppearance = appearance4;
            ultraGridColumn12.DefaultCellValue = "Edit";
            ultraGridColumn12.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.True;
            appearance5.BackColor = System.Drawing.Color.Transparent;
            appearance5.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ForeColor = System.Drawing.Color.Transparent;
            ultraGridColumn12.Header.Appearance = appearance5;
            ultraGridColumn12.Header.VisiblePosition = 10;
            ultraGridColumn12.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled;
            ultraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn12.Width = 132;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            appearance6.BackColor = System.Drawing.Color.SlateBlue;
            appearance6.FontData.BoldAsString = "True";
            ultraGridBand1.Header.Appearance = appearance6;
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Purple;
            appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance7.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance7;
            appearance8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance8;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.GroupByBox.Hidden = true;
            appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance9.BackColor2 = System.Drawing.SystemColors.Control;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance9;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            appearance10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance10;
            appearance11.BackColor = System.Drawing.Color.MediumSlateBlue;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance11;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.Color.PowderBlue;
            this.ultraGrid1.DisplayLayout.Override.AddRowAppearance = appearance13;
            appearance14.BackColor = System.Drawing.Color.PowderBlue;
            this.ultraGrid1.DisplayLayout.Override.AddRowCellAppearance = appearance14;
            this.ultraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            this.ultraGrid1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.ultraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.RaisedSoft;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dashed;
            appearance15.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance15;
            appearance16.BackColor = System.Drawing.Color.MediumSlateBlue;
            appearance16.FontData.BoldAsString = "True";
            appearance16.ForeColor = System.Drawing.Color.Black;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance16;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.ultraGrid1.DisplayLayout.Override.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.PlainText;
            this.ultraGrid1.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            this.ultraGrid1.DisplayLayout.Override.CellSpacing = 3;
            appearance17.BackColor = System.Drawing.SystemColors.Control;
            appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance17.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance17.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance17;
            appearance18.BackColor = System.Drawing.Color.SlateBlue;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance18.FontData.BoldAsString = "True";
            appearance18.FontData.Name = "Trebuchet MS";
            appearance18.FontData.SizeInPoints = 9F;
            appearance18.ForeColor = System.Drawing.Color.Black;
            appearance18.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance18;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance19.BackColor = System.Drawing.Color.SlateBlue;
            this.ultraGrid1.DisplayLayout.Override.RowAlternateAppearance = appearance19;
            appearance20.BackColor = System.Drawing.Color.SlateBlue;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance20;
            appearance21.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorAppearance = appearance21;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFixed;
            this.ultraGrid1.DisplayLayout.Override.RowSpacingAfter = 2;
            this.ultraGrid1.DisplayLayout.Override.RowSpacingBefore = 0;
            appearance22.BackColor = System.Drawing.Color.CornflowerBlue;
            appearance22.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            this.ultraGrid1.DisplayLayout.Override.SelectedRowAppearance = appearance22;
            this.ultraGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.ultraGrid1.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.None;
            appearance23.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance23;
            this.ultraGrid1.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.RowConnectorColor = System.Drawing.Color.SlateBlue;
            this.ultraGrid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Dotted;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid1.Location = new System.Drawing.Point(0, 78);
            this.ultraGrid1.Margin = new System.Windows.Forms.Padding(0);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(1904, 1187);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.Text = "ultraGrid1";
            this.ultraGrid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ultraGrid1_InitializeRow);
            this.ultraGrid1.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ultraGrid1_ClickCellButton);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(PersonManagement.Models.Person);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.input_searchPhrase);
            this.panel1.Controls.Add(this.ultraLabel3);
            this.panel1.Controls.Add(this.ultraLabel2);
            this.panel1.Controls.Add(this.ultraLabel1);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_CreatePerson);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 78);
            this.panel1.TabIndex = 1;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance24.TextHAlignAsString = "Center";
            this.ultraLabel3.Appearance = appearance24;
            this.ultraLabel3.Font = new System.Drawing.Font("OMEGA CT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel3.Location = new System.Drawing.Point(809, 12);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(281, 37);
            this.ultraLabel3.TabIndex = 4;
            this.ultraLabel3.Text = "Person Management";
            this.ultraLabel3.WrapText = false;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Font = new System.Drawing.Font("OMEGA CT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel2.Location = new System.Drawing.Point(12, 43);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(281, 23);
            this.ultraLabel2.TabIndex = 3;
            this.ultraLabel2.Text = "Neven Marić";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Font = new System.Drawing.Font("OMEGA CT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(12, 11);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(281, 23);
            this.ultraLabel1.TabIndex = 2;
            this.ultraLabel1.Text = "MBANQ";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance25.BackColor = System.Drawing.Color.MediumSlateBlue;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance25.BackHatchStyle = Infragistics.Win.BackHatchStyle.None;
            appearance25.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance25.TextHAlignAsString = "Center";
            appearance25.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.btn_Exit.Appearance = appearance25;
            this.btn_Exit.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft;
            this.btn_Exit.Font = new System.Drawing.Font("OMEGA CT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(1715, 43);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(177, 32);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // btn_CreatePerson
            // 
            this.btn_CreatePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance26.BackColor = System.Drawing.Color.MediumSlateBlue;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance26.BackHatchStyle = Infragistics.Win.BackHatchStyle.None;
            appearance26.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance26.TextHAlignAsString = "Center";
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.btn_CreatePerson.Appearance = appearance26;
            this.btn_CreatePerson.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft;
            this.btn_CreatePerson.Font = new System.Drawing.Font("OMEGA CT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreatePerson.Location = new System.Drawing.Point(1715, 3);
            this.btn_CreatePerson.Name = "btn_CreatePerson";
            this.btn_CreatePerson.Size = new System.Drawing.Size(177, 34);
            this.btn_CreatePerson.TabIndex = 0;
            this.btn_CreatePerson.Text = "New Person";
            this.btn_CreatePerson.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // input_searchPhrase
            // 
            this.input_searchPhrase.Font = new System.Drawing.Font("OMEGA CT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_searchPhrase.Location = new System.Drawing.Point(705, 44);
            this.input_searchPhrase.Name = "input_searchPhrase";
            this.input_searchPhrase.Size = new System.Drawing.Size(499, 29);
            this.input_searchPhrase.TabIndex = 5;
            this.input_searchPhrase.ValueChanged += new System.EventHandler(this.input_searchPhrase_ValueChanged);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ultraGrid1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Management by Neven Marić - mbanq";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_searchPhrase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private System.Windows.Forms.BindingSource mbanqDataSetBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Panel panel1;
        private Infragistics.Win.Misc.UltraButton btn_Exit;
        private Infragistics.Win.Misc.UltraButton btn_CreatePerson;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor input_searchPhrase;
    }
}

