namespace GlossaryForm
{
    partial class GlossaryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlossaryForm));
            this.tabControlNavigationMenu = new System.Windows.Forms.TabControl();
            this.tabPageGlossary = new System.Windows.Forms.TabPage();
            this.labelNumberOfTerms = new System.Windows.Forms.Label();
            this.labelDefinedTerms = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxSearchedDefinition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonFindTerm = new System.Windows.Forms.Button();
            this.textBoxTermToSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGlossary = new System.Windows.Forms.DataGridView();
            this.tabPageAddTerm = new System.Windows.Forms.TabPage();
            this.panelAddTerm = new System.Windows.Forms.Panel();
            this.textBoxNewTerm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewDefinition = new System.Windows.Forms.TextBox();
            this.buttonAddTerm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTermToUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUpdateDefinition = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlNavigationMenu.SuspendLayout();
            this.tabPageGlossary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGlossary)).BeginInit();
            this.tabPageAddTerm.SuspendLayout();
            this.panelAddTerm.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlNavigationMenu
            // 
            this.tabControlNavigationMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlNavigationMenu.Controls.Add(this.tabPageGlossary);
            this.tabControlNavigationMenu.Controls.Add(this.tabPageAddTerm);
            this.tabControlNavigationMenu.Controls.Add(this.tabPageUpdate);
            this.tabControlNavigationMenu.Location = new System.Drawing.Point(12, 12);
            this.tabControlNavigationMenu.Name = "tabControlNavigationMenu";
            this.tabControlNavigationMenu.SelectedIndex = 0;
            this.tabControlNavigationMenu.Size = new System.Drawing.Size(776, 422);
            this.tabControlNavigationMenu.TabIndex = 11;
            // 
            // tabPageGlossary
            // 
            this.tabPageGlossary.AccessibleName = "";
            this.tabPageGlossary.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPageGlossary.Controls.Add(this.labelNumberOfTerms);
            this.tabPageGlossary.Controls.Add(this.labelDefinedTerms);
            this.tabPageGlossary.Controls.Add(this.buttonDelete);
            this.tabPageGlossary.Controls.Add(this.textBoxSearchedDefinition);
            this.tabPageGlossary.Controls.Add(this.label7);
            this.tabPageGlossary.Controls.Add(this.buttonFindTerm);
            this.tabPageGlossary.Controls.Add(this.textBoxTermToSearch);
            this.tabPageGlossary.Controls.Add(this.label6);
            this.tabPageGlossary.Controls.Add(this.label5);
            this.tabPageGlossary.Controls.Add(this.label1);
            this.tabPageGlossary.Controls.Add(this.dataGridViewGlossary);
            this.tabPageGlossary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGlossary.ForeColor = System.Drawing.Color.Transparent;
            this.tabPageGlossary.Location = new System.Drawing.Point(4, 22);
            this.tabPageGlossary.Name = "tabPageGlossary";
            this.tabPageGlossary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGlossary.Size = new System.Drawing.Size(768, 396);
            this.tabPageGlossary.TabIndex = 0;
            this.tabPageGlossary.Text = "GlossaryForm";
            // 
            // labelNumberOfTerms
            // 
            this.labelNumberOfTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberOfTerms.AutoSize = true;
            this.labelNumberOfTerms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfTerms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumberOfTerms.Location = new System.Drawing.Point(363, 345);
            this.labelNumberOfTerms.Name = "labelNumberOfTerms";
            this.labelNumberOfTerms.Size = new System.Drawing.Size(15, 17);
            this.labelNumberOfTerms.TabIndex = 13;
            this.labelNumberOfTerms.Text = "0";
            this.labelNumberOfTerms.UseMnemonic = false;
            // 
            // labelDefinedTerms
            // 
            this.labelDefinedTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDefinedTerms.AutoSize = true;
            this.labelDefinedTerms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinedTerms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDefinedTerms.Location = new System.Drawing.Point(275, 345);
            this.labelDefinedTerms.Name = "labelDefinedTerms";
            this.labelDefinedTerms.Size = new System.Drawing.Size(92, 17);
            this.labelDefinedTerms.TabIndex = 12;
            this.labelDefinedTerms.Text = "defined terms:";
            this.labelDefinedTerms.UseMnemonic = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(657, 348);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 37);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // textBoxSearchedDefinition
            // 
            this.textBoxSearchedDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchedDefinition.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxSearchedDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchedDefinition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchedDefinition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSearchedDefinition.Location = new System.Drawing.Point(10, 299);
            this.textBoxSearchedDefinition.MaximumSize = new System.Drawing.Size(600, 200);
            this.textBoxSearchedDefinition.MinimumSize = new System.Drawing.Size(100, 28);
            this.textBoxSearchedDefinition.Multiline = true;
            this.textBoxSearchedDefinition.Name = "textBoxSearchedDefinition";
            this.textBoxSearchedDefinition.ReadOnly = true;
            this.textBoxSearchedDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSearchedDefinition.Size = new System.Drawing.Size(246, 60);
            this.textBoxSearchedDefinition.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(6, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Definition:";
            // 
            // buttonFindTerm
            // 
            this.buttonFindTerm.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.buttonFindTerm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonFindTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindTerm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindTerm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFindTerm.Location = new System.Drawing.Point(81, 210);
            this.buttonFindTerm.Name = "buttonFindTerm";
            this.buttonFindTerm.Size = new System.Drawing.Size(91, 37);
            this.buttonFindTerm.TabIndex = 8;
            this.buttonFindTerm.Text = "Find";
            this.buttonFindTerm.UseVisualStyleBackColor = true;
            this.buttonFindTerm.Click += new System.EventHandler(this.ButtonFindTerm_Click);
            // 
            // textBoxTermToSearch
            // 
            this.textBoxTermToSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTermToSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTermToSearch.Location = new System.Drawing.Point(68, 145);
            this.textBoxTermToSearch.MaximumSize = new System.Drawing.Size(600, 28);
            this.textBoxTermToSearch.MinimumSize = new System.Drawing.Size(100, 28);
            this.textBoxTermToSearch.Multiline = true;
            this.textBoxTermToSearch.Name = "textBoxTermToSearch";
            this.textBoxTermToSearch.Size = new System.Drawing.Size(162, 28);
            this.textBoxTermToSearch.TabIndex = 7;
            this.textBoxTermToSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTermToSearch_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(18, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Term";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(52, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Find definition";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(419, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "GlossaryForm";
            // 
            // dataGridViewGlossary
            // 
            this.dataGridViewGlossary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGlossary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGlossary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGlossary.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGlossary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGlossary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGlossary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGlossary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGlossary.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGlossary.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridViewGlossary.Location = new System.Drawing.Point(278, 63);
            this.dataGridViewGlossary.MultiSelect = false;
            this.dataGridViewGlossary.Name = "dataGridViewGlossary";
            this.dataGridViewGlossary.ReadOnly = true;
            this.dataGridViewGlossary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGlossary.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewGlossary.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGlossary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGlossary.Size = new System.Drawing.Size(470, 279);
            this.dataGridViewGlossary.TabIndex = 2;
            this.dataGridViewGlossary.DataSourceChanged += new System.EventHandler(this.DataGridViewGlossary_DataSourceChanged);
            // 
            // tabPageAddTerm
            // 
            this.tabPageAddTerm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPageAddTerm.Controls.Add(this.panelAddTerm);
            this.tabPageAddTerm.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddTerm.Name = "tabPageAddTerm";
            this.tabPageAddTerm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddTerm.Size = new System.Drawing.Size(768, 396);
            this.tabPageAddTerm.TabIndex = 1;
            this.tabPageAddTerm.Text = "Add term";
            // 
            // panelAddTerm
            // 
            this.panelAddTerm.Controls.Add(this.textBoxNewTerm);
            this.panelAddTerm.Controls.Add(this.label4);
            this.panelAddTerm.Controls.Add(this.textBoxNewDefinition);
            this.panelAddTerm.Controls.Add(this.buttonAddTerm);
            this.panelAddTerm.Controls.Add(this.label3);
            this.panelAddTerm.Controls.Add(this.label2);
            this.panelAddTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddTerm.Location = new System.Drawing.Point(3, 3);
            this.panelAddTerm.Name = "panelAddTerm";
            this.panelAddTerm.Size = new System.Drawing.Size(762, 390);
            this.panelAddTerm.TabIndex = 11;
            // 
            // textBoxNewTerm
            // 
            this.textBoxNewTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewTerm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewTerm.Location = new System.Drawing.Point(93, 132);
            this.textBoxNewTerm.MaximumSize = new System.Drawing.Size(600, 28);
            this.textBoxNewTerm.MinimumSize = new System.Drawing.Size(300, 28);
            this.textBoxNewTerm.Name = "textBoxNewTerm";
            this.textBoxNewTerm.Size = new System.Drawing.Size(345, 28);
            this.textBoxNewTerm.TabIndex = 5;
            this.textBoxNewTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNewTerm_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(9, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Definition";
            // 
            // textBoxNewDefinition
            // 
            this.textBoxNewDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewDefinition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewDefinition.Location = new System.Drawing.Point(93, 189);
            this.textBoxNewDefinition.Multiline = true;
            this.textBoxNewDefinition.Name = "textBoxNewDefinition";
            this.textBoxNewDefinition.Size = new System.Drawing.Size(638, 99);
            this.textBoxNewDefinition.TabIndex = 6;
            this.textBoxNewDefinition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNewDefinition_KeyDown);
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTerm.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.buttonAddTerm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonAddTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTerm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTerm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddTerm.Location = new System.Drawing.Point(640, 320);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.Size = new System.Drawing.Size(91, 37);
            this.buttonAddTerm.TabIndex = 7;
            this.buttonAddTerm.Text = "Add";
            this.buttonAddTerm.UseVisualStyleBackColor = true;
            this.buttonAddTerm.Click += new System.EventHandler(this.ButtonAddTerm_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(43, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Term";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(293, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add term";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.panel1);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(768, 396);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update term";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.textBoxTermToUpdate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxUpdateDefinition);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 396);
            this.panel1.TabIndex = 12;
            // 
            // textBoxTermToUpdate
            // 
            this.textBoxTermToUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTermToUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTermToUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTermToUpdate.Location = new System.Drawing.Point(93, 132);
            this.textBoxTermToUpdate.MaximumSize = new System.Drawing.Size(600, 28);
            this.textBoxTermToUpdate.MinimumSize = new System.Drawing.Size(300, 28);
            this.textBoxTermToUpdate.Name = "textBoxTermToUpdate";
            this.textBoxTermToUpdate.Size = new System.Drawing.Size(351, 28);
            this.textBoxTermToUpdate.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(9, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Definition";
            // 
            // textBoxUpdateDefinition
            // 
            this.textBoxUpdateDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUpdateDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUpdateDefinition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpdateDefinition.Location = new System.Drawing.Point(93, 189);
            this.textBoxUpdateDefinition.Multiline = true;
            this.textBoxUpdateDefinition.Name = "textBoxUpdateDefinition";
            this.textBoxUpdateDefinition.Size = new System.Drawing.Size(644, 99);
            this.textBoxUpdateDefinition.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUpdate.Location = new System.Drawing.Point(646, 320);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 37);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(43, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Term";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(282, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 40);
            this.label10.TabIndex = 2;
            this.label10.Text = "Update term";
            // 
            // GlossaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlNavigationMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlossaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlossaryForm App";
            this.tabControlNavigationMenu.ResumeLayout(false);
            this.tabPageGlossary.ResumeLayout(false);
            this.tabPageGlossary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGlossary)).EndInit();
            this.tabPageAddTerm.ResumeLayout(false);
            this.panelAddTerm.ResumeLayout(false);
            this.panelAddTerm.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNavigationMenu;
        private System.Windows.Forms.TabPage tabPageGlossary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGlossary;
        private System.Windows.Forms.TabPage tabPageAddTerm;
        private System.Windows.Forms.Panel panelAddTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewDefinition;
        private System.Windows.Forms.Button buttonAddTerm;
        private System.Windows.Forms.TextBox textBoxNewTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonFindTerm;
        private System.Windows.Forms.TextBox textBoxTermToSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearchedDefinition;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTermToUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUpdateDefinition;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelNumberOfTerms;
        private System.Windows.Forms.Label labelDefinedTerms;
    }
}

