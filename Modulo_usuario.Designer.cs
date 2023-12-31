namespace SRRH
{
    partial class Modulo_usuario
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
            restart_btn = new FontAwesome.Sharp.IconButton();
            Consultar_btt = new FontAwesome.Sharp.IconButton();
            eliminar_btn = new FontAwesome.Sharp.IconButton();
            editar_btn = new FontAwesome.Sharp.IconButton();
            aregar_btn = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            Tabla = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            contra = new TextBox();
            label3 = new Label();
            Nombre = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(restart_btn);
            panel1.Controls.Add(Consultar_btt);
            panel1.Controls.Add(eliminar_btn);
            panel1.Controls.Add(editar_btn);
            panel1.Controls.Add(aregar_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(Tabla);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(contra);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Nombre);
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 520);
            panel1.TabIndex = 3;
            panel1.Click += Borrador_event;
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
            Cerrar.Location = new Point(827, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 10;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // restart_btn
            // 
            restart_btn.BackColor = Color.White;
            restart_btn.Cursor = Cursors.Hand;
            restart_btn.FlatStyle = FlatStyle.Flat;
            restart_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            restart_btn.ForeColor = Color.FromArgb(165, 25, 42);
            restart_btn.IconChar = FontAwesome.Sharp.IconChar.Broom;
            restart_btn.IconColor = Color.FromArgb(165, 25, 42);
            restart_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            restart_btn.IconSize = 30;
            restart_btn.Location = new Point(51, 470);
            restart_btn.Name = "restart_btn";
            restart_btn.Size = new Size(117, 35);
            restart_btn.TabIndex = 9;
            restart_btn.Text = "LIMPIAR";
            restart_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            restart_btn.UseVisualStyleBackColor = false;
            restart_btn.Click += Borrador_event;
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
            Consultar_btt.Location = new Point(498, 445);
            Consultar_btt.Name = "Consultar_btt";
            Consultar_btt.Size = new Size(172, 46);
            Consultar_btt.TabIndex = 7;
            Consultar_btt.Text = "CONSULTAR";
            Consultar_btt.TextImageRelation = TextImageRelation.ImageBeforeText;
            Consultar_btt.UseVisualStyleBackColor = false;
            Consultar_btt.Click += Consultar_btt_Click;
            // 
            // eliminar_btn
            // 
            eliminar_btn.BackColor = Color.White;
            eliminar_btn.Cursor = Cursors.Hand;
            eliminar_btn.FlatStyle = FlatStyle.Flat;
            eliminar_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            eliminar_btn.ForeColor = Color.FromArgb(165, 25, 42);
            eliminar_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            eliminar_btn.IconColor = Color.FromArgb(165, 25, 42);
            eliminar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminar_btn.IconSize = 40;
            eliminar_btn.Location = new Point(676, 445);
            eliminar_btn.Name = "eliminar_btn";
            eliminar_btn.Size = new Size(172, 46);
            eliminar_btn.TabIndex = 8;
            eliminar_btn.Text = "ELIMINAR";
            eliminar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminar_btn.UseVisualStyleBackColor = false;
            eliminar_btn.Click += eliminar_btn_Click;
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
            editar_btn.Location = new Point(676, 393);
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
            aregar_btn.Location = new Point(498, 393);
            aregar_btn.Name = "aregar_btn";
            aregar_btn.Size = new Size(172, 46);
            aregar_btn.TabIndex = 5;
            aregar_btn.Text = "AGREGAR";
            aregar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            aregar_btn.UseVisualStyleBackColor = false;
            aregar_btn.Click += aregar_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(543, 255);
            label2.Name = "label2";
            label2.Size = new Size(49, 27);
            label2.TabIndex = 48;
            label2.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(20, 15);
            label5.Name = "label5";
            label5.Size = new Size(569, 58);
            label5.TabIndex = 47;
            label5.Text = "GESTIÓN DE USUARIO\r\n";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(165, 25, 42);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CAJERO", "ADMINISTRADOR" });
            comboBox1.Location = new Point(543, 285);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 41);
            comboBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(165, 25, 42);
            checkBox1.Location = new Point(609, 342);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 31);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Estado";
            checkBox1.UseVisualStyleBackColor = true;
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
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Usuario, Rol, Estado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle3;
            Tabla.GridColor = Color.Gainsboro;
            Tabla.Location = new Point(51, 84);
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
            Tabla.Size = new Size(420, 380);
            Tabla.TabIndex = 23;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 129;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 77;
            // 
            // Estado
            // 
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
            label1.Location = new Point(543, 170);
            label1.Name = "label1";
            label1.Size = new Size(138, 27);
            label1.TabIndex = 13;
            label1.Text = "Contraseña";
            // 
            // contra
            // 
            contra.BorderStyle = BorderStyle.FixedSingle;
            contra.Cursor = Cursors.IBeam;
            contra.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            contra.ForeColor = Color.FromArgb(165, 25, 42);
            contra.Location = new Point(543, 200);
            contra.Name = "contra";
            contra.Size = new Size(249, 40);
            contra.TabIndex = 2;
            contra.TextAlign = HorizontalAlignment.Center;
            contra.UseSystemPasswordChar = true;
            contra.MouseEnter += contra_MouseEnter;
            contra.MouseLeave += contra_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(543, 79);
            label3.Name = "label3";
            label3.Size = new Size(101, 27);
            label3.TabIndex = 99;
            label3.Text = "Nombre";
            // 
            // Nombre
            // 
            Nombre.BorderStyle = BorderStyle.FixedSingle;
            Nombre.Cursor = Cursors.IBeam;
            Nombre.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.FromArgb(165, 25, 42);
            Nombre.Location = new Point(543, 109);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(249, 40);
            Nombre.TabIndex = 1;
            Nombre.TextAlign = HorizontalAlignment.Center;
            // 
            // Modulo_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(894, 544);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Modulo_usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo_usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox1;
        private DataGridView Tabla;
        private Label label1;
        private TextBox contra;
        private Label label3;
        private TextBox Nombre;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
        private ComboBox comboBox1;
        private Label label5;
        private Label label2;
        private FontAwesome.Sharp.IconButton restart_btn;
        private FontAwesome.Sharp.IconButton Consultar_btt;
        private FontAwesome.Sharp.IconButton eliminar_btn;
        private FontAwesome.Sharp.IconButton editar_btn;
        private FontAwesome.Sharp.IconButton aregar_btn;
        private Button Cerrar;
    }
}