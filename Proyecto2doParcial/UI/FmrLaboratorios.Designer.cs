namespace APPreservaLabUI.UI
{
    partial class FmrLaboratorios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrLaboratorios));
            dgvGestionLab = new DataGridView();
            nomLab = new DataGridViewTextBoxColumn();
            capacidadLab = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            estadoLab = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            txtNombreLab = new TextBox();
            txtCapacidadLab = new TextBox();
            label2 = new Label();
            chkActivo = new CheckBox();
            panelFmrLab = new Panel();
            btnEliminarLab = new Button();
            btnNuevoLab = new Button();
            panelTabla = new Panel();
            label11 = new Label();
            btnGrabarLab = new Button();
            panelBuscarLab = new Panel();
            txtBuscarLab = new TextBox();
            label4 = new Label();
            panelConten = new Panel();
            panel3 = new Panel();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panelCapLab = new Panel();
            panelNameLab = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            btnBuscarLab = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGestionLab).BeginInit();
            panelFmrLab.SuspendLayout();
            panelTabla.SuspendLayout();
            panelBuscarLab.SuspendLayout();
            panelConten.SuspendLayout();
            panel3.SuspendLayout();
            panelCapLab.SuspendLayout();
            panelNameLab.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvGestionLab
            // 
            dgvGestionLab.AllowUserToAddRows = false;
            dgvGestionLab.AllowUserToDeleteRows = false;
            dgvGestionLab.AllowUserToResizeColumns = false;
            dgvGestionLab.AllowUserToResizeRows = false;
            dgvGestionLab.Anchor = AnchorStyles.Top;
            dgvGestionLab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionLab.BackgroundColor = Color.FromArgb(242, 248, 255);
            dgvGestionLab.BorderStyle = BorderStyle.None;
            dgvGestionLab.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvGestionLab.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGestionLab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionLab.ColumnHeadersHeight = 43;
            dgvGestionLab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGestionLab.Columns.AddRange(new DataGridViewColumn[] { nomLab, capacidadLab, dgvID, estadoLab });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 248, 255);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvGestionLab.DefaultCellStyle = dataGridViewCellStyle4;
            dgvGestionLab.EnableHeadersVisualStyles = false;
            dgvGestionLab.GridColor = Color.FromArgb(0, 57, 108);
            dgvGestionLab.Location = new Point(14, 38);
            dgvGestionLab.Name = "dgvGestionLab";
            dgvGestionLab.ReadOnly = true;
            dgvGestionLab.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGestionLab.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(242, 248, 255);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvGestionLab.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvGestionLab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionLab.ShowCellToolTips = false;
            dgvGestionLab.ShowEditingIcon = false;
            dgvGestionLab.Size = new Size(602, 282);
            dgvGestionLab.TabIndex = 0;
            dgvGestionLab.CellClick += dgvGestionLab_CellClick;
            // 
            // nomLab
            // 
            nomLab.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nomLab.DefaultCellStyle = dataGridViewCellStyle2;
            nomLab.FillWeight = 200F;
            nomLab.HeaderText = "Nombre";
            nomLab.MinimumWidth = 20;
            nomLab.Name = "nomLab";
            nomLab.ReadOnly = true;
            // 
            // capacidadLab
            // 
            capacidadLab.DataPropertyName = "capacidad";
            capacidadLab.FillWeight = 200F;
            capacidadLab.HeaderText = "Capacidad";
            capacidadLab.MinimumWidth = 20;
            capacidadLab.Name = "capacidadLab";
            capacidadLab.ReadOnly = true;
            // 
            // dgvID
            // 
            dgvID.DataPropertyName = "id";
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvID.DefaultCellStyle = dataGridViewCellStyle3;
            dgvID.HeaderText = "ID";
            dgvID.Name = "dgvID";
            dgvID.ReadOnly = true;
            // 
            // estadoLab
            // 
            estadoLab.DataPropertyName = "activo";
            estadoLab.FillWeight = 200F;
            estadoLab.HeaderText = "Estado";
            estadoLab.MinimumWidth = 20;
            estadoLab.Name = "estadoLab";
            estadoLab.ReadOnly = true;
            estadoLab.Resizable = DataGridViewTriState.True;
            estadoLab.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 248, 255);
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(195, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre del laboratorio:";
            // 
            // txtNombreLab
            // 
            txtNombreLab.BackColor = Color.FromArgb(213, 232, 255);
            txtNombreLab.BorderStyle = BorderStyle.None;
            txtNombreLab.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreLab.ForeColor = Color.Black;
            txtNombreLab.Location = new Point(15, 8);
            txtNombreLab.Name = "txtNombreLab";
            txtNombreLab.Size = new Size(299, 20);
            txtNombreLab.TabIndex = 2;
            txtNombreLab.TextChanged += txtNombreLab_TextChanged;
            txtNombreLab.KeyPress += txtNombreLab_KeyPress;
            // 
            // txtCapacidadLab
            // 
            txtCapacidadLab.BackColor = Color.FromArgb(213, 232, 255);
            txtCapacidadLab.BorderStyle = BorderStyle.None;
            txtCapacidadLab.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapacidadLab.Location = new Point(17, 9);
            txtCapacidadLab.Name = "txtCapacidadLab";
            txtCapacidadLab.Size = new Size(39, 20);
            txtCapacidadLab.TabIndex = 4;
            txtCapacidadLab.TextChanged += txtCapacidadLab_TextChanged;
            txtCapacidadLab.KeyPress += txtCapacidadLab_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 248, 255);
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 114);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 3;
            label2.Text = "Capacidad:";
            // 
            // chkActivo
            // 
            chkActivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Century Gothic", 14.25F);
            chkActivo.Location = new Point(17, 218);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(278, 26);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "¿El laboratorio está activo?";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.CheckedChanged += chkActivo_CheckedChanged;
            // 
            // panelFmrLab
            // 
            panelFmrLab.Anchor = AnchorStyles.None;
            panelFmrLab.BackColor = Color.White;
            panelFmrLab.Controls.Add(btnEliminarLab);
            panelFmrLab.Controls.Add(btnNuevoLab);
            panelFmrLab.Controls.Add(panelTabla);
            panelFmrLab.Controls.Add(btnGrabarLab);
            panelFmrLab.Controls.Add(panelBuscarLab);
            panelFmrLab.Controls.Add(label4);
            panelFmrLab.Controls.Add(panelConten);
            panelFmrLab.Controls.Add(panel2);
            panelFmrLab.Controls.Add(panel1);
            panelFmrLab.Controls.Add(btnBuscarLab);
            panelFmrLab.Controls.Add(pictureBox1);
            panelFmrLab.Controls.Add(label3);
            panelFmrLab.Location = new Point(-3, 0);
            panelFmrLab.Name = "panelFmrLab";
            panelFmrLab.Size = new Size(1103, 598);
            panelFmrLab.TabIndex = 7;
            // 
            // btnEliminarLab
            // 
            btnEliminarLab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarLab.BackColor = Color.FromArgb(0, 57, 108);
            btnEliminarLab.Cursor = Cursors.Hand;
            btnEliminarLab.FlatAppearance.BorderSize = 0;
            btnEliminarLab.FlatStyle = FlatStyle.Flat;
            btnEliminarLab.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarLab.ForeColor = Color.White;
            btnEliminarLab.Location = new Point(283, 504);
            btnEliminarLab.Name = "btnEliminarLab";
            btnEliminarLab.Size = new Size(114, 33);
            btnEliminarLab.TabIndex = 23;
            btnEliminarLab.Text = "Eliminar";
            btnEliminarLab.UseVisualStyleBackColor = false;
            btnEliminarLab.Click += btnEliminarLab_Click;
            // 
            // btnNuevoLab
            // 
            btnNuevoLab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevoLab.BackColor = Color.FromArgb(0, 57, 108);
            btnNuevoLab.Cursor = Cursors.Hand;
            btnNuevoLab.FlatAppearance.BorderSize = 0;
            btnNuevoLab.FlatStyle = FlatStyle.Flat;
            btnNuevoLab.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoLab.ForeColor = Color.White;
            btnNuevoLab.Location = new Point(26, 504);
            btnNuevoLab.Name = "btnNuevoLab";
            btnNuevoLab.Size = new Size(114, 33);
            btnNuevoLab.TabIndex = 21;
            btnNuevoLab.Text = "Nuevo";
            btnNuevoLab.UseVisualStyleBackColor = false;
            btnNuevoLab.Click += btnNuevoLab_Click;
            // 
            // panelTabla
            // 
            panelTabla.AccessibleRole = AccessibleRole.None;
            panelTabla.BackColor = Color.FromArgb(242, 248, 255);
            panelTabla.Controls.Add(label11);
            panelTabla.Controls.Add(dgvGestionLab);
            panelTabla.Location = new Point(449, 199);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(630, 338);
            panelTabla.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(242, 248, 255);
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 57, 108);
            label11.Location = new Point(246, 12);
            label11.Name = "label11";
            label11.Size = new Size(164, 19);
            label11.TabIndex = 35;
            label11.Text = "Lista de Laboratorios";
            // 
            // btnGrabarLab
            // 
            btnGrabarLab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGrabarLab.BackColor = Color.FromArgb(0, 57, 108);
            btnGrabarLab.Cursor = Cursors.Hand;
            btnGrabarLab.FlatAppearance.BorderSize = 0;
            btnGrabarLab.FlatStyle = FlatStyle.Flat;
            btnGrabarLab.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrabarLab.ForeColor = Color.White;
            btnGrabarLab.Location = new Point(157, 504);
            btnGrabarLab.Name = "btnGrabarLab";
            btnGrabarLab.Size = new Size(114, 33);
            btnGrabarLab.TabIndex = 7;
            btnGrabarLab.Text = "Grabar";
            btnGrabarLab.UseVisualStyleBackColor = false;
            btnGrabarLab.Click += btnGrabarLab_Click;
            // 
            // panelBuscarLab
            // 
            panelBuscarLab.BackColor = Color.FromArgb(242, 248, 255);
            panelBuscarLab.Controls.Add(txtBuscarLab);
            panelBuscarLab.Location = new Point(580, 155);
            panelBuscarLab.Name = "panelBuscarLab";
            panelBuscarLab.Size = new Size(499, 33);
            panelBuscarLab.TabIndex = 18;
            // 
            // txtBuscarLab
            // 
            txtBuscarLab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarLab.BackColor = Color.FromArgb(242, 248, 255);
            txtBuscarLab.BorderStyle = BorderStyle.None;
            txtBuscarLab.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarLab.ForeColor = Color.Gray;
            txtBuscarLab.Location = new Point(12, 6);
            txtBuscarLab.Name = "txtBuscarLab";
            txtBuscarLab.Size = new Size(473, 20);
            txtBuscarLab.TabIndex = 13;
            txtBuscarLab.Text = "Buscar Laboratorio...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 57, 108);
            label4.Location = new Point(26, 154);
            label4.Name = "label4";
            label4.Size = new Size(218, 23);
            label4.TabIndex = 17;
            label4.Text = "Formulario Laboratorio";
            // 
            // panelConten
            // 
            panelConten.BackColor = Color.FromArgb(242, 248, 255);
            panelConten.Controls.Add(panel3);
            panelConten.Controls.Add(label6);
            panelConten.Controls.Add(label5);
            panelConten.Controls.Add(panelCapLab);
            panelConten.Controls.Add(panelNameLab);
            panelConten.Controls.Add(label1);
            panelConten.Controls.Add(label2);
            panelConten.Controls.Add(chkActivo);
            panelConten.Location = new Point(26, 199);
            panelConten.Name = "panelConten";
            panelConten.Size = new Size(371, 267);
            panelConten.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(213, 232, 255);
            panel3.Controls.Add(txtID);
            panel3.Location = new Point(209, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 36);
            panel3.TabIndex = 21;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(213, 232, 255);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Enabled = false;
            txtID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(17, 9);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(105, 20);
            txtID.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(242, 248, 255);
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(204, 114);
            label6.Name = "label6";
            label6.Size = new Size(31, 21);
            label6.TabIndex = 20;
            label6.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(95, 164);
            label5.Name = "label5";
            label5.Size = new Size(92, 22);
            label5.TabIndex = 19;
            label5.Text = "personas";
            // 
            // panelCapLab
            // 
            panelCapLab.BackColor = Color.FromArgb(213, 232, 255);
            panelCapLab.Controls.Add(txtCapacidadLab);
            panelCapLab.Location = new Point(17, 155);
            panelCapLab.Name = "panelCapLab";
            panelCapLab.Size = new Size(72, 36);
            panelCapLab.TabIndex = 18;
            // 
            // panelNameLab
            // 
            panelNameLab.BackColor = Color.FromArgb(213, 232, 255);
            panelNameLab.Controls.Add(txtNombreLab);
            panelNameLab.Location = new Point(17, 54);
            panelNameLab.Name = "panelNameLab";
            panelNameLab.Size = new Size(332, 36);
            panelNameLab.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Location = new Point(424, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 350);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(27, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 3);
            panel1.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Location = new Point(0, 544);
            panel4.Name = "panel4";
            panel4.Size = new Size(1050, 3);
            panel4.TabIndex = 15;
            // 
            // btnBuscarLab
            // 
            btnBuscarLab.BackColor = Color.FromArgb(0, 57, 108);
            btnBuscarLab.Cursor = Cursors.Hand;
            btnBuscarLab.FlatAppearance.BorderSize = 0;
            btnBuscarLab.FlatStyle = FlatStyle.Flat;
            btnBuscarLab.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarLab.ForeColor = Color.White;
            btnBuscarLab.Location = new Point(449, 154);
            btnBuscarLab.Name = "btnBuscarLab";
            btnBuscarLab.Size = new Size(114, 33);
            btnBuscarLab.TabIndex = 12;
            btnBuscarLab.Text = "Buscar";
            btnBuscarLab.UseVisualStyleBackColor = false;
            btnBuscarLab.Click += btnBuscarLab_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 57, 108);
            label3.Location = new Point(147, 39);
            label3.Name = "label3";
            label3.Size = new Size(569, 57);
            label3.TabIndex = 10;
            label3.Text = "Gestión de Laboratorios";
            // 
            // FmrLaboratorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 597);
            Controls.Add(panelFmrLab);
            Name = "FmrLaboratorios";
            Text = "FmrLaboratorios";
            ((System.ComponentModel.ISupportInitialize)dgvGestionLab).EndInit();
            panelFmrLab.ResumeLayout(false);
            panelFmrLab.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            panelBuscarLab.ResumeLayout(false);
            panelBuscarLab.PerformLayout();
            panelConten.ResumeLayout(false);
            panelConten.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelCapLab.ResumeLayout(false);
            panelCapLab.PerformLayout();
            panelNameLab.ResumeLayout(false);
            panelNameLab.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGestionLab;
        private Label label1;
        private TextBox txtNombreLab;
        private TextBox txtCapacidadLab;
        private Label label2;
        private CheckBox chkActivo;
        private Panel panelFmrLab;
        private Button btnGrabarLab;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtBuscarLab;
        private Button btnBuscarLab;
        private Panel panel1;
        private Panel panel2;
        private Panel panelConten;
        private Panel panelNameLab;
        private Panel panelCapLab;
        private Label label4;
        private Panel panelBuscarLab;
        private Label label5;
        private Panel panel3;
        private TextBox txtID;
        private Label label6;
        private Panel panel4;
        private Panel panelTabla;
        private Button btnEliminarLab;
        private Button btnNuevoLab;
        private Label label11;
        private DataGridViewTextBoxColumn nomLab;
        private DataGridViewTextBoxColumn capacidadLab;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewCheckBoxColumn estadoLab;
    }
}