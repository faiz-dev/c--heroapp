namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gvSuperHeroes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            superHeroBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnSave = new Button();
            txtBoxAutocomplete = new TextBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)gvSuperHeroes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)superHeroBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gvSuperHeroes
            // 
            gvSuperHeroes.AllowUserToAddRows = false;
            gvSuperHeroes.AllowUserToDeleteRows = false;
            gvSuperHeroes.AutoGenerateColumns = false;
            gvSuperHeroes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSuperHeroes.Columns.AddRange(new DataGridViewColumn[] { Column1, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            gvSuperHeroes.DataSource = superHeroBindingSource;
            gvSuperHeroes.Location = new Point(0, 0);
            gvSuperHeroes.Margin = new Padding(3, 2, 3, 2);
            gvSuperHeroes.Name = "gvSuperHeroes";
            gvSuperHeroes.ReadOnly = true;
            gvSuperHeroes.RowHeadersWidth = 51;
            gvSuperHeroes.RowTemplate.Height = 29;
            gvSuperHeroes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSuperHeroes.Size = new Size(423, 202);
            gvSuperHeroes.TabIndex = 0;
            gvSuperHeroes.CellClick += gvSuperHeroes_CellClick;
            gvSuperHeroes.SelectionChanged += gvSuperHeroes_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // superHeroBindingSource
            // 
            superHeroBindingSource.DataSource = typeof(Model.SuperHero);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 215);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 220);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(9, 237);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(187, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(219, 237);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(204, 23);
            txtLastName.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(9, 270);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 22);
            btnSave.TabIndex = 5;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxAutocomplete
            // 
            txtBoxAutocomplete.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBoxAutocomplete.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBoxAutocomplete.Location = new Point(523, 58);
            txtBoxAutocomplete.Margin = new Padding(3, 2, 3, 2);
            txtBoxAutocomplete.Name = "txtBoxAutocomplete";
            txtBoxAutocomplete.Size = new Size(162, 23);
            txtBoxAutocomplete.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(221, 269);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(202, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 305);
            Controls.Add(btnDelete);
            Controls.Add(txtBoxAutocomplete);
            Controls.Add(btnSave);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gvSuperHeroes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gvSuperHeroes).EndInit();
            ((System.ComponentModel.ISupportInitialize)superHeroBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvSuperHeroes;
        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSave;
        private BindingSource superHeroBindingSource;
        private TextBox txtBoxAutocomplete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private Button btnDelete;
    }
}