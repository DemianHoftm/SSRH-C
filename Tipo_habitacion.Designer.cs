namespace SRRH
{
    partial class Tipo_habitacion
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
            Cerrar = new Button();
            Eliminados = new FontAwesome.Sharp.IconButton();
            button1 = new FontAwesome.Sharp.IconButton();
            Eliminar = new FontAwesome.Sharp.IconButton();
            editar_btn = new FontAwesome.Sharp.IconButton();
            aregar_btn = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            Total_hab = new Label();
            label4 = new Label();
            capa = new TextBox();
            label2 = new Label();
            precio = new TextBox();
            Tabla = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Pres = new DataGridViewTextBoxColumn();
            Num_Per = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tipo = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(Eliminados);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Eliminar);
            panel1.Controls.Add(editar_btn);
            panel1.Controls.Add(aregar_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Total_hab);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(capa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(precio);
            panel1.Controls.Add(Tabla);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tipo);
            panel1.Controls.Add(label3);
            panel1.Cursor = Cursors.Hand;
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 529);
            panel1.TabIndex = 4;
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
            Cerrar.Location = new Point(879, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 10;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // Eliminados
            // 
            Eliminados.BackColor = Color.White;
            Eliminados.FlatStyle = FlatStyle.Flat;
            Eliminados.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Eliminados.ForeColor = Color.FromArgb(165, 25, 42);
            Eliminados.IconChar = FontAwesome.Sharp.IconChar.Eye;
            Eliminados.IconColor = Color.FromArgb(165, 25, 42);
            Eliminados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Eliminados.IconSize = 30;
            Eliminados.Location = new Point(25, 474);
            Eliminados.Name = "Eliminados";
            Eliminados.Size = new Size(205, 35);
            Eliminados.TabIndex = 8;
            Eliminados.Text = "VER DESACTIVADOS";
            Eliminados.TextImageRelation = TextImageRelation.ImageBeforeText;
            Eliminados.UseVisualStyleBackColor = false;
            Eliminados.Click += Eliminados_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(165, 25, 42);
            button1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            button1.IconColor = Color.FromArgb(165, 25, 42);
            button1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button1.IconSize = 30;
            button1.Location = new Point(236, 474);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 9;
            button1.Text = "LIMPIAR";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Startup;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.White;
            Eliminar.Cursor = Cursors.Hand;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Eliminar.ForeColor = Color.FromArgb(165, 25, 42);
            Eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            Eliminar.IconColor = Color.FromArgb(165, 25, 42);
            Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Eliminar.IconSize = 40;
            Eliminar.Location = new Point(636, 461);
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
            editar_btn.Location = new Point(724, 409);
            editar_btn.Name = "editar_btn";
            editar_btn.Size = new Size(172, 46);
            editar_btn.TabIndex = 6;
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
            aregar_btn.Location = new Point(546, 409);
            aregar_btn.Name = "aregar_btn";
            aregar_btn.Size = new Size(172, 46);
            aregar_btn.TabIndex = 5;
            aregar_btn.Text = "AGREGAR";
            aregar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            aregar_btn.UseVisualStyleBackColor = false;
            aregar_btn.Click += aregar_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(20, 10);
            label5.Name = "label5";
            label5.Size = new Size(674, 58);
            label5.TabIndex = 46;
            label5.Text = "GESTIÓN DE TIPO DE HAB.";
            // 
            // Total_hab
            // 
            Total_hab.AutoSize = true;
            Total_hab.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Total_hab.ForeColor = Color.FromArgb(165, 25, 42);
            Total_hab.Location = new Point(693, 92);
            Total_hab.Name = "Total_hab";
            Total_hab.Size = new Size(48, 27);
            Total_hab.TabIndex = 33;
            Total_hab.Text = "##";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(165, 25, 42);
            label4.Location = new Point(586, 306);
            label4.Name = "label4";
            label4.Size = new Size(135, 27);
            label4.TabIndex = 29;
            label4.Text = "Capacidad:";
            // 
            // capa
            // 
            capa.BorderStyle = BorderStyle.FixedSingle;
            capa.Cursor = Cursors.IBeam;
            capa.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            capa.ForeColor = Color.FromArgb(165, 25, 42);
            capa.Location = new Point(586, 336);
            capa.MaxLength = 3;
            capa.Name = "capa";
            capa.Size = new Size(249, 40);
            capa.TabIndex = 4;
            capa.TextAlign = HorizontalAlignment.Center;
            capa.KeyPress += Solo_Numeros_Allowed_ND;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(586, 222);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 26;
            label2.Text = "Precio";
            // 
            // precio
            // 
            precio.BorderStyle = BorderStyle.FixedSingle;
            precio.Cursor = Cursors.IBeam;
            precio.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            precio.ForeColor = Color.FromArgb(165, 25, 42);
            precio.Location = new Point(586, 252);
            precio.MaxLength = 13;
            precio.Name = "precio";
            precio.Size = new Size(249, 40);
            precio.TabIndex = 3;
            precio.TextAlign = HorizontalAlignment.Center;
            precio.KeyPress += Solo_Numeros_Allowed;
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
            Tabla.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Pres, Num_Per });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle3;
            Tabla.GridColor = Color.Gainsboro;
            Tabla.Location = new Point(25, 88);
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
            Tabla.Size = new Size(492, 380);
            Tabla.TabIndex = 99;
            Tabla.DoubleClick += Tabla_DoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 68;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 134;
            // 
            // Pres
            // 
            Pres.HeaderText = "Precio";
            Pres.Name = "Pres";
            Pres.ReadOnly = true;
            Pres.Width = 113;
            // 
            // Num_Per
            // 
            Num_Per.HeaderText = "Capacidad";
            Num_Per.Name = "Num_Per";
            Num_Per.ReadOnly = true;
            Num_Per.Width = 161;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(586, 143);
            label1.Name = "label1";
            label1.Size = new Size(101, 27);
            label1.TabIndex = 13;
            label1.Text = "Nombre";
            // 
            // tipo
            // 
            tipo.BorderStyle = BorderStyle.FixedSingle;
            tipo.Cursor = Cursors.IBeam;
            tipo.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tipo.ForeColor = Color.FromArgb(165, 25, 42);
            tipo.Location = new Point(586, 173);
            tipo.MaxLength = 20;
            tipo.Name = "tipo";
            tipo.Size = new Size(249, 40);
            tipo.TabIndex = 2;
            tipo.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(586, 92);
            label3.Name = "label3";
            label3.Size = new Size(101, 27);
            label3.TabIndex = 2;
            label3.Text = "Numero";
            // 
            // Tipo_habitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(948, 552);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tipo_habitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tipo_habitacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox precio;
        private DataGridView Tabla;
        private Label label1;
        private TextBox tipo;
        private Label label3;
        private Label label4;
        private TextBox capa;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pres;
        private DataGridViewTextBoxColumn Num_Per;
        private Label Total_hab;
        private Label label5;
        private FontAwesome.Sharp.IconButton Eliminar;
        private FontAwesome.Sharp.IconButton editar_btn;
        private FontAwesome.Sharp.IconButton aregar_btn;
        private FontAwesome.Sharp.IconButton button1;
        private FontAwesome.Sharp.IconButton Eliminados;
        private Button Cerrar;
    }
}