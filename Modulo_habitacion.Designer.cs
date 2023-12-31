namespace SRRH
{
    partial class Modulo_habitacion
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new FontAwesome.Sharp.IconButton();
            Cerrar = new Button();
            label4 = new Label();
            Consultar_btt = new FontAwesome.Sharp.IconButton();
            Eliminar = new FontAwesome.Sharp.IconButton();
            editar_btn = new FontAwesome.Sharp.IconButton();
            aregar_btn = new FontAwesome.Sharp.IconButton();
            checkBox1 = new CheckBox();
            ID1 = new ComboBox();
            Cantidad_contador = new Label();
            Tabla = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            T_n = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label3 = new Label();
            No_Hosp = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Consultar_btt);
            panel1.Controls.Add(Eliminar);
            panel1.Controls.Add(editar_btn);
            panel1.Controls.Add(aregar_btn);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(ID1);
            panel1.Controls.Add(Cantidad_contador);
            panel1.Controls.Add(Tabla);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(No_Hosp);
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 519);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(165, 25, 42);
            button1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            button1.IconColor = Color.FromArgb(165, 25, 42);
            button1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button1.IconSize = 30;
            button1.Location = new Point(35, 476);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 8;
            button1.Text = "LIMPIAR";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.FromArgb(220, 0, 0);
            Cerrar.Cursor = Cursors.Hand;
            Cerrar.FlatAppearance.BorderSize = 0;
            Cerrar.FlatAppearance.MouseDownBackColor = Color.Red;
            Cerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cerrar.ForeColor = Color.White;
            Cerrar.Location = new Point(883, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 9;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(165, 25, 42);
            label4.Location = new Point(20, 10);
            label4.Name = "label4";
            label4.Size = new Size(658, 58);
            label4.TabIndex = 45;
            label4.Text = "GESTIÓN DE HABITACIÓN";
            // 
            // Consultar_btt
            // 
            Consultar_btt.BackColor = Color.White;
            Consultar_btt.Cursor = Cursors.Hand;
            Consultar_btt.FlatStyle = FlatStyle.Flat;
            Consultar_btt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Consultar_btt.ForeColor = Color.FromArgb(165, 25, 42);
            Consultar_btt.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            Consultar_btt.IconColor = Color.FromArgb(165, 25, 42);
            Consultar_btt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Consultar_btt.IconSize = 40;
            Consultar_btt.Location = new Point(544, 424);
            Consultar_btt.Name = "Consultar_btt";
            Consultar_btt.Size = new Size(172, 46);
            Consultar_btt.TabIndex = 6;
            Consultar_btt.Text = "CONSULTAR";
            Consultar_btt.TextImageRelation = TextImageRelation.ImageBeforeText;
            Consultar_btt.UseVisualStyleBackColor = false;
            Consultar_btt.Click += Consultar_btt_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.White;
            Eliminar.Cursor = Cursors.Hand;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Eliminar.ForeColor = Color.FromArgb(165, 25, 42);
            Eliminar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            Eliminar.IconColor = Color.FromArgb(165, 25, 42);
            Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Eliminar.IconSize = 40;
            Eliminar.Location = new Point(722, 424);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(172, 46);
            Eliminar.TabIndex = 7;
            Eliminar.Text = "DESACTIVAR";
            Eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // editar_btn
            // 
            editar_btn.BackColor = Color.White;
            editar_btn.Cursor = Cursors.Hand;
            editar_btn.FlatStyle = FlatStyle.Flat;
            editar_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editar_btn.ForeColor = Color.FromArgb(165, 25, 42);
            editar_btn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            editar_btn.IconColor = Color.FromArgb(165, 25, 42);
            editar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editar_btn.IconSize = 40;
            editar_btn.Location = new Point(722, 372);
            editar_btn.Name = "editar_btn";
            editar_btn.Size = new Size(172, 46);
            editar_btn.TabIndex = 5;
            editar_btn.Text = "EDITAR";
            editar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            editar_btn.UseVisualStyleBackColor = false;
            editar_btn.Click += editar_btn_Click;
            // 
            // aregar_btn
            // 
            aregar_btn.BackColor = Color.White;
            aregar_btn.Cursor = Cursors.Hand;
            aregar_btn.FlatStyle = FlatStyle.Flat;
            aregar_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aregar_btn.ForeColor = Color.FromArgb(165, 25, 42);
            aregar_btn.IconChar = FontAwesome.Sharp.IconChar.Add;
            aregar_btn.IconColor = Color.FromArgb(165, 25, 42);
            aregar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            aregar_btn.IconSize = 40;
            aregar_btn.Location = new Point(544, 372);
            aregar_btn.Name = "aregar_btn";
            aregar_btn.Size = new Size(172, 46);
            aregar_btn.TabIndex = 4;
            aregar_btn.Text = "AGREGAR";
            aregar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            aregar_btn.UseVisualStyleBackColor = false;
            aregar_btn.Click += aregar_btn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(165, 25, 42);
            checkBox1.Location = new Point(639, 332);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(160, 31);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Disponibles";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ID1
            // 
            ID1.DropDownStyle = ComboBoxStyle.DropDownList;
            ID1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ID1.ForeColor = Color.FromArgb(165, 25, 42);
            ID1.FormattingEnabled = true;
            ID1.Items.AddRange(new object[] { "V-", "E-", "J-" });
            ID1.Location = new Point(592, 279);
            ID1.Name = "ID1";
            ID1.Size = new Size(249, 41);
            ID1.TabIndex = 2;
            // 
            // Cantidad_contador
            // 
            Cantidad_contador.AutoSize = true;
            Cantidad_contador.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Cantidad_contador.ForeColor = Color.FromArgb(165, 25, 42);
            Cantidad_contador.Location = new Point(570, 122);
            Cantidad_contador.Name = "Cantidad_contador";
            Cantidad_contador.Size = new Size(298, 27);
            Cantidad_contador.TabIndex = 39;
            Cantidad_contador.Text = "Total de habitaciones: ##";
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.AllowUserToResizeColumns = false;
            Tabla.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            Tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Tabla.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Numero, T_n, Estado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle3;
            Tabla.GridColor = Color.Gainsboro;
            Tabla.Location = new Point(35, 90);
            Tabla.MultiSelect = false;
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            Tabla.RowHeadersWidth = 10;
            Tabla.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Tabla.RowTemplate.Height = 25;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.Size = new Size(456, 380);
            Tabla.TabIndex = 99;
            Tabla.DoubleClick += Tabla_DoubleClick;
            // 
            // Numero
            // 
            Numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Numero.HeaderText = "Numero";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            Numero.Width = 134;
            // 
            // T_n
            // 
            T_n.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            T_n.HeaderText = "Tipo";
            T_n.Name = "T_n";
            T_n.ReadOnly = true;
            T_n.Width = 90;
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 119;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(592, 249);
            label1.Name = "label1";
            label1.Size = new Size(60, 27);
            label1.TabIndex = 13;
            label1.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(592, 170);
            label3.Name = "label3";
            label3.Size = new Size(173, 27);
            label3.TabIndex = 2;
            label3.Text = "No. Hospadaje";
            // 
            // No_Hosp
            // 
            No_Hosp.BorderStyle = BorderStyle.FixedSingle;
            No_Hosp.Cursor = Cursors.IBeam;
            No_Hosp.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            No_Hosp.ForeColor = Color.FromArgb(165, 25, 42);
            No_Hosp.Location = new Point(592, 200);
            No_Hosp.MaxLength = 3;
            No_Hosp.Name = "No_Hosp";
            No_Hosp.Size = new Size(249, 40);
            No_Hosp.TabIndex = 1;
            No_Hosp.TextAlign = HorizontalAlignment.Center;
            No_Hosp.KeyPress += No_Hosp_KeyPress;
            // 
            // Modulo_habitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(950, 543);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Modulo_habitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo_habitacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView Tabla;
        private Label label1;
        private Label label3;
        private TextBox No_Hosp;
        private ComboBox ID1;
        private CheckBox checkBox1;
        private Label Cantidad_contador;
        private FontAwesome.Sharp.IconButton editar_btn;
        private FontAwesome.Sharp.IconButton Consultar_btt;
        private FontAwesome.Sharp.IconButton Eliminar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton aregar_btn;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn T_n;
        private DataGridViewTextBoxColumn Estado;
        private Label label4;
        private Button Cerrar;
        private FontAwesome.Sharp.IconButton button1;
    }
}