namespace SRRH
{
    partial class Modulo_Bitacora
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
            rango2 = new DateTimePicker();
            rango1 = new DateTimePicker();
            label9 = new Label();
            usuario_consul = new ComboBox();
            acce = new ComboBox();
            Cerrar = new Button();
            restart_btn = new FontAwesome.Sharp.IconButton();
            Consultar_btt = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label5 = new Label();
            modulo = new ComboBox();
            Tabla = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(rango2);
            panel1.Controls.Add(rango1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(usuario_consul);
            panel1.Controls.Add(acce);
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(restart_btn);
            panel1.Controls.Add(Consultar_btt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(modulo);
            panel1.Controls.Add(Tabla);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 517);
            panel1.TabIndex = 4;
            // 
            // rango2
            // 
            rango2.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rango2.CalendarForeColor = Color.Maroon;
            rango2.CalendarTitleBackColor = Color.DarkRed;
            rango2.Location = new Point(661, 388);
            rango2.Margin = new Padding(5);
            rango2.Name = "rango2";
            rango2.Size = new Size(252, 23);
            rango2.TabIndex = 4;
            rango2.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            // 
            // rango1
            // 
            rango1.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rango1.CalendarForeColor = Color.Maroon;
            rango1.CalendarTitleBackColor = Color.DarkRed;
            rango1.Location = new Point(661, 365);
            rango1.Margin = new Padding(5);
            rango1.Name = "rango1";
            rango1.Size = new Size(252, 23);
            rango1.TabIndex = 3;
            rango1.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            rango1.Leave += rango1_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(165, 25, 42);
            label9.Location = new Point(661, 333);
            label9.Name = "label9";
            label9.Size = new Size(187, 27);
            label9.TabIndex = 60;
            label9.Text = "Rango de Fecha";
            // 
            // usuario_consul
            // 
            usuario_consul.DropDownStyle = ComboBoxStyle.DropDownList;
            usuario_consul.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            usuario_consul.ForeColor = Color.FromArgb(165, 25, 42);
            usuario_consul.FormattingEnabled = true;
            usuario_consul.Items.AddRange(new object[] { "SELECCIONAR" });
            usuario_consul.Location = new Point(661, 104);
            usuario_consul.Name = "usuario_consul";
            usuario_consul.Size = new Size(248, 41);
            usuario_consul.TabIndex = 0;
            // 
            // acce
            // 
            acce.DropDownStyle = ComboBoxStyle.DropDownList;
            acce.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            acce.ForeColor = Color.FromArgb(165, 25, 42);
            acce.FormattingEnabled = true;
            acce.Items.AddRange(new object[] { "SELECCIONE", "Insertar", "Eliminar", "Editar" });
            acce.Location = new Point(661, 186);
            acce.Name = "acce";
            acce.Size = new Size(248, 41);
            acce.TabIndex = 1;
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
            Cerrar.Location = new Point(900, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 7;
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
            restart_btn.TabIndex = 6;
            restart_btn.Text = "LIMPIAR";
            restart_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            restart_btn.UseVisualStyleBackColor = false;
            restart_btn.Click += restart_btn_Click;
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
            Consultar_btt.Location = new Point(698, 436);
            Consultar_btt.Name = "Consultar_btt";
            Consultar_btt.Size = new Size(172, 46);
            Consultar_btt.TabIndex = 5;
            Consultar_btt.Text = "CONSULTAR";
            Consultar_btt.TextImageRelation = TextImageRelation.ImageBeforeText;
            Consultar_btt.UseVisualStyleBackColor = false;
            Consultar_btt.Click += Consultar_btt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(661, 237);
            label2.Name = "label2";
            label2.Size = new Size(95, 27);
            label2.TabIndex = 48;
            label2.Text = "Módulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(20, 15);
            label5.Name = "label5";
            label5.Size = new Size(280, 58);
            label5.TabIndex = 47;
            label5.Text = "BITÁCORA";
            // 
            // modulo
            // 
            modulo.DropDownStyle = ComboBoxStyle.DropDownList;
            modulo.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            modulo.ForeColor = Color.FromArgb(165, 25, 42);
            modulo.FormattingEnabled = true;
            modulo.Items.AddRange(new object[] { "SELECCIONE", "Reservacion", "Pago", "Transferencia" });
            modulo.Location = new Point(661, 267);
            modulo.Name = "modulo";
            modulo.Size = new Size(248, 41);
            modulo.TabIndex = 2;
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
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Usuario, Rol, Estado, Codigo, Fecha });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle3;
            Tabla.GridColor = Color.Gainsboro;
            Tabla.Location = new Point(20, 84);
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
            Tabla.Size = new Size(613, 380);
            Tabla.TabIndex = 23;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Accion";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 117;
            // 
            // Rol
            // 
            Rol.HeaderText = "Usuario";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 129;
            // 
            // Estado
            // 
            Estado.HeaderText = "Modulo";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 126;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 121;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(661, 156);
            label1.Name = "label1";
            label1.Size = new Size(86, 27);
            label1.TabIndex = 13;
            label1.Text = "Accion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(661, 74);
            label3.Name = "label3";
            label3.Size = new Size(97, 27);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // Modulo_Bitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(976, 541);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Modulo_Bitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo_Bitacora";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Cerrar;
        private FontAwesome.Sharp.IconButton restart_btn;
        private FontAwesome.Sharp.IconButton Consultar_btt;
        private Label label2;
        private Label label5;
        private ComboBox modulo;
        private DataGridView Tabla;
        private Label label1;
        private Label label3;
        private ComboBox usuario_consul;
        private ComboBox acce;
        private DateTimePicker rango2;
        private DateTimePicker rango1;
        private Label label9;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Fecha;
    }
}