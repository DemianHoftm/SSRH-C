namespace SRRH
{
    partial class Modulo_Pago
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            ID_cliente = new TextBox();
            id_reser = new TextBox();
            f_reser_max = new DateTimePicker();
            f_reser_min = new DateTimePicker();
            textBox1 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            reserva_codi = new Label();
            nombreycodigoclient = new Label();
            pagoid = new Label();
            panel1 = new Panel();
            Tabla = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ID_colu = new DataGridViewTextBoxColumn();
            Nom_cli = new DataGridViewTextBoxColumn();
            Telf_nom = new DataGridViewTextBoxColumn();
            Corr_ta = new DataGridViewTextBoxColumn();
            ID1 = new ComboBox();
            comboBox1 = new ComboBox();
            Consultar_btt = new FontAwesome.Sharp.IconButton();
            Cerrar = new Button();
            button1 = new FontAwesome.Sharp.IconButton();
            Eliminar = new FontAwesome.Sharp.IconButton();
            editar_btn = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(970, 80);
            label3.Name = "label3";
            label3.Size = new Size(90, 27);
            label3.TabIndex = 98;
            label3.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(671, 80);
            label1.Name = "label1";
            label1.Size = new Size(265, 27);
            label1.TabIndex = 92;
            label1.Text = "Código de Reservación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(671, 188);
            label2.Name = "label2";
            label2.Size = new Size(191, 27);
            label2.TabIndex = 96;
            label2.Text = "Fecha Realizada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(165, 25, 42);
            label4.Location = new Point(970, 188);
            label4.Name = "label4";
            label4.Size = new Size(177, 27);
            label4.TabIndex = 99;
            label4.Text = "Forma de Pago";
            // 
            // ID_cliente
            // 
            ID_cliente.BorderStyle = BorderStyle.FixedSingle;
            ID_cliente.Cursor = Cursors.IBeam;
            ID_cliente.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ID_cliente.ForeColor = Color.FromArgb(165, 25, 42);
            ID_cliente.Location = new Point(1009, 119);
            ID_cliente.MaxLength = 14;
            ID_cliente.Name = "ID_cliente";
            ID_cliente.Size = new Size(201, 40);
            ID_cliente.TabIndex = 3;
            ID_cliente.TextAlign = HorizontalAlignment.Center;
            ID_cliente.KeyPress += ID_cliente_KeyPress;
            // 
            // id_reser
            // 
            id_reser.BorderStyle = BorderStyle.FixedSingle;
            id_reser.Cursor = Cursors.IBeam;
            id_reser.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            id_reser.ForeColor = Color.FromArgb(165, 25, 42);
            id_reser.Location = new Point(671, 119);
            id_reser.MaxLength = 6;
            id_reser.Name = "id_reser";
            id_reser.Size = new Size(240, 40);
            id_reser.TabIndex = 1;
            id_reser.TextAlign = HorizontalAlignment.Center;
            id_reser.KeyPress += id_reser_KeyPress;
            // 
            // f_reser_max
            // 
            f_reser_max.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            f_reser_max.CalendarForeColor = Color.Maroon;
            f_reser_max.CalendarTitleBackColor = Color.DarkRed;
            f_reser_max.Location = new Point(671, 242);
            f_reser_max.Margin = new Padding(5);
            f_reser_max.Name = "f_reser_max";
            f_reser_max.Size = new Size(243, 23);
            f_reser_max.TabIndex = 5;
            f_reser_max.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            // 
            // f_reser_min
            // 
            f_reser_min.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            f_reser_min.CalendarForeColor = Color.Maroon;
            f_reser_min.CalendarTitleBackColor = Color.DarkRed;
            f_reser_min.Location = new Point(671, 219);
            f_reser_min.Margin = new Padding(5);
            f_reser_min.Name = "f_reser_min";
            f_reser_min.Size = new Size(243, 23);
            f_reser_min.TabIndex = 4;
            f_reser_min.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            f_reser_min.Leave += f_reser_min_Leave;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(671, 444);
            textBox1.MaxLength = 9;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 40);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += ID_cliente_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(671, 414);
            label5.Name = "label5";
            label5.Size = new Size(104, 27);
            label5.TabIndex = 34;
            label5.Text = "Importe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(165, 25, 42);
            label7.Location = new Point(959, 428);
            label7.Name = "label7";
            label7.Size = new Size(75, 27);
            label7.TabIndex = 38;
            label7.Text = "Pago:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(165, 25, 42);
            label8.Location = new Point(959, 457);
            label8.Name = "label8";
            label8.Size = new Size(156, 27);
            label8.TabIndex = 39;
            label8.Text = "Reservacion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(165, 25, 42);
            label9.Location = new Point(960, 367);
            label9.Name = "label9";
            label9.Size = new Size(98, 27);
            label9.TabIndex = 40;
            label9.Text = "Cliente:";
            // 
            // reserva_codi
            // 
            reserva_codi.AutoSize = true;
            reserva_codi.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            reserva_codi.ForeColor = Color.FromArgb(165, 25, 42);
            reserva_codi.Location = new Point(1118, 457);
            reserva_codi.Name = "reserva_codi";
            reserva_codi.Size = new Size(84, 27);
            reserva_codi.TabIndex = 41;
            reserva_codi.Text = "####";
            // 
            // nombreycodigoclient
            // 
            nombreycodigoclient.AutoSize = true;
            nombreycodigoclient.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            nombreycodigoclient.ForeColor = Color.FromArgb(165, 25, 42);
            nombreycodigoclient.Location = new Point(960, 398);
            nombreycodigoclient.Name = "nombreycodigoclient";
            nombreycodigoclient.Size = new Size(146, 27);
            nombreycodigoclient.TabIndex = 42;
            nombreycodigoclient.Text = "#### ____";
            // 
            // pagoid
            // 
            pagoid.AutoSize = true;
            pagoid.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            pagoid.ForeColor = Color.FromArgb(165, 25, 42);
            pagoid.Location = new Point(1040, 428);
            pagoid.Name = "pagoid";
            pagoid.Size = new Size(84, 27);
            pagoid.TabIndex = 43;
            pagoid.Text = "####";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(Tabla);
            panel1.Controls.Add(ID1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(Consultar_btt);
            panel1.Controls.Add(pagoid);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(nombreycodigoclient);
            panel1.Controls.Add(reserva_codi);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(Eliminar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(editar_btn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(ID_cliente);
            panel1.Controls.Add(id_reser);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(f_reser_max);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(f_reser_min);
            panel1.Cursor = Cursors.Hand;
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 591);
            panel1.TabIndex = 45;
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.AllowUserToResizeColumns = false;
            Tabla.AllowUserToResizeRows = false;
            Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Tabla.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { ID, ID_colu, Nom_cli, Telf_nom, Corr_ta });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle4;
            Tabla.GridColor = Color.Gainsboro;
            Tabla.Location = new Point(19, 80);
            Tabla.MultiSelect = false;
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersWidth = 5;
            Tabla.RowTemplate.Height = 25;
            Tabla.ScrollBars = ScrollBars.Vertical;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.Size = new Size(628, 438);
            Tabla.TabIndex = 46;
            Tabla.DoubleClick += Tabla_DoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 65;
            // 
            // ID_colu
            // 
            ID_colu.HeaderText = "Reservacion";
            ID_colu.Name = "ID_colu";
            ID_colu.ReadOnly = true;
            ID_colu.Width = 173;
            // 
            // Nom_cli
            // 
            Nom_cli.HeaderText = "Importe";
            Nom_cli.Name = "Nom_cli";
            Nom_cli.ReadOnly = true;
            Nom_cli.Width = 129;
            // 
            // Telf_nom
            // 
            Telf_nom.HeaderText = "Referencia";
            Telf_nom.Name = "Telf_nom";
            Telf_nom.ReadOnly = true;
            Telf_nom.Width = 156;
            // 
            // Corr_ta
            // 
            Corr_ta.HeaderText = "Fecha";
            Corr_ta.Name = "Corr_ta";
            Corr_ta.ReadOnly = true;
            Corr_ta.Width = 102;
            // 
            // ID1
            // 
            ID1.AllowDrop = true;
            ID1.DropDownStyle = ComboBoxStyle.DropDownList;
            ID1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ID1.FormattingEnabled = true;
            ID1.ItemHeight = 33;
            ID1.Items.AddRange(new object[] { "V-", "E-", "J-" });
            ID1.Location = new Point(970, 119);
            ID1.Name = "ID1";
            ID1.Size = new Size(41, 41);
            ID1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(165, 25, 42);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 33;
            comboBox1.Items.AddRange(new object[] { "Seleccionar", "Efectivo", "Tarjeta", "Transferencia" });
            comboBox1.Location = new Point(970, 219);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 41);
            comboBox1.TabIndex = 6;
            // 
            // Consultar_btt
            // 
            Consultar_btt.BackColor = Color.White;
            Consultar_btt.FlatStyle = FlatStyle.Flat;
            Consultar_btt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Consultar_btt.ForeColor = Color.FromArgb(165, 25, 42);
            Consultar_btt.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            Consultar_btt.IconColor = Color.FromArgb(165, 25, 42);
            Consultar_btt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Consultar_btt.IconSize = 40;
            Consultar_btt.Location = new Point(866, 298);
            Consultar_btt.Name = "Consultar_btt";
            Consultar_btt.Size = new Size(163, 46);
            Consultar_btt.TabIndex = 7;
            Consultar_btt.Text = "CONSULTAR";
            Consultar_btt.TextImageRelation = TextImageRelation.ImageBeforeText;
            Consultar_btt.UseVisualStyleBackColor = false;
            Consultar_btt.Click += Consultar_btt_Click;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.FromArgb(220, 0, 0);
            Cerrar.FlatAppearance.BorderSize = 0;
            Cerrar.FlatAppearance.MouseDownBackColor = Color.Red;
            Cerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cerrar.ForeColor = Color.White;
            Cerrar.Location = new Point(1187, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 13;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
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
            button1.Location = new Point(25, 532);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 12;
            button1.Text = "LIMPIAR";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.White;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Eliminar.ForeColor = Color.FromArgb(165, 25, 42);
            Eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            Eliminar.IconColor = Color.FromArgb(165, 25, 42);
            Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Eliminar.IconSize = 40;
            Eliminar.Location = new Point(751, 522);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(163, 46);
            Eliminar.TabIndex = 10;
            Eliminar.Text = "DESACTIVAR";
            Eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // editar_btn
            // 
            editar_btn.BackColor = Color.White;
            editar_btn.FlatStyle = FlatStyle.Flat;
            editar_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editar_btn.ForeColor = Color.FromArgb(165, 25, 42);
            editar_btn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            editar_btn.IconColor = Color.FromArgb(165, 25, 42);
            editar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editar_btn.IconSize = 40;
            editar_btn.Location = new Point(959, 522);
            editar_btn.Name = "editar_btn";
            editar_btn.Size = new Size(163, 46);
            editar_btn.TabIndex = 11;
            editar_btn.Text = "EDITAR";
            editar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            editar_btn.UseVisualStyleBackColor = false;
            editar_btn.Click += editar_btn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(165, 25, 42);
            label13.Location = new Point(20, 10);
            label13.Name = "label13";
            label13.Size = new Size(509, 58);
            label13.TabIndex = 46;
            label13.Text = "GESTIÓN DE PAGOS";
            // 
            // Modulo_Pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(1254, 618);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Modulo_Pago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo_Clase";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Tabla;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox ID_cliente;
        private TextBox id_reser;
        private DateTimePicker f_reser_max;
        private DateTimePicker f_reser_min;
        private TextBox textBox1;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label reserva_codi;
        private Label nombreycodigoclient;
        private Label pagoid;
        private Panel panel1;
        private Button Cerrar;
        private FontAwesome.Sharp.IconButton Eliminados;
        private FontAwesome.Sharp.IconButton Eliminar;
        private FontAwesome.Sharp.IconButton button1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton editar_btn;
        private FontAwesome.Sharp.IconButton aregar_btn;
        private Label label13;
        private FontAwesome.Sharp.IconButton Consultar_btt;
        private ComboBox comboBox1;
        private Label Total_hab;
        private Label label14;
        private TextBox capa;
        private Label label15;
        private TextBox precio;
        private Label label16;
        private TextBox tipo;
        private Label label17;
        private ComboBox ID1;
        private DataGridViewTextBoxColumn Reservacion;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn Referencia;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ID_colu;
        private DataGridViewTextBoxColumn Nom_cli;
        private DataGridViewTextBoxColumn Telf_nom;
        private DataGridViewTextBoxColumn Corr_ta;
    }
}