namespace SRRH
{
    partial class Inicio
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
            panel3 = new Panel();
            man_menu = new FontAwesome.Sharp.IconButton();
            hab_menu = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            Log_out = new Button();
            Cerrar = new Button();
            habitacio_btn = new Button();
            Cliente_btn = new Button();
            inicio_btn = new Button();
            bitacora_boton = new Button();
            reporte_boton = new Button();
            usuario_boton = new Button();
            tipo_btn = new Button();
            label1 = new Label();
            ID_cliente = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label8 = new Label();
            Agregar_habitacion_a_reservar = new FontAwesome.Sharp.IconButton();
            button4 = new FontAwesome.Sharp.IconButton();
            button2 = new FontAwesome.Sharp.IconButton();
            guardar_res = new FontAwesome.Sharp.IconButton();
            button3 = new FontAwesome.Sharp.IconButton();
            Nombre_Cliente = new Label();
            ID1 = new ComboBox();
            Cantidad_total = new Label();
            label14 = new Label();
            label13 = new Label();
            Descuento = new TextBox();
            label11 = new Label();
            Lista_Reservar = new ListBox();
            habitaciones = new ListBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            f_salida = new DateTimePicker();
            label6 = new Label();
            f_entrada = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(121, 19, 30);
            panel3.Controls.Add(man_menu);
            panel3.Controls.Add(hab_menu);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(Log_out);
            panel3.Controls.Add(Cerrar);
            panel3.Controls.Add(habitacio_btn);
            panel3.Controls.Add(Cliente_btn);
            panel3.Controls.Add(inicio_btn);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1608, 35);
            panel3.TabIndex = 1;
            // 
            // man_menu
            // 
            man_menu.Dock = DockStyle.Left;
            man_menu.FlatAppearance.BorderSize = 0;
            man_menu.FlatAppearance.MouseDownBackColor = Color.Red;
            man_menu.FlatAppearance.MouseOverBackColor = Color.Red;
            man_menu.FlatStyle = FlatStyle.Flat;
            man_menu.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            man_menu.ForeColor = Color.White;
            man_menu.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            man_menu.IconColor = Color.White;
            man_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            man_menu.IconSize = 25;
            man_menu.Location = new Point(513, 0);
            man_menu.Name = "man_menu";
            man_menu.Size = new Size(217, 35);
            man_menu.TabIndex = 18;
            man_menu.Text = "MANTENIMIENTO";
            man_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            man_menu.UseVisualStyleBackColor = true;
            man_menu.Click += man_menu_Click;
            // 
            // hab_menu
            // 
            hab_menu.FlatAppearance.BorderSize = 0;
            hab_menu.FlatAppearance.MouseDownBackColor = Color.Red;
            hab_menu.FlatAppearance.MouseOverBackColor = Color.Red;
            hab_menu.FlatStyle = FlatStyle.Flat;
            hab_menu.ForeColor = Color.White;
            hab_menu.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            hab_menu.IconColor = Color.White;
            hab_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            hab_menu.IconSize = 25;
            hab_menu.Location = new Point(273, 0);
            hab_menu.Name = "hab_menu";
            hab_menu.Size = new Size(24, 35);
            hab_menu.TabIndex = 14;
            hab_menu.UseVisualStyleBackColor = true;
            hab_menu.Click += hab_menu_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(429, 0);
            button1.Name = "button1";
            button1.Size = new Size(84, 35);
            button1.TabIndex = 17;
            button1.Text = "PAGO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Log_out
            // 
            Log_out.BackColor = Color.Transparent;
            Log_out.Cursor = Cursors.Hand;
            Log_out.Dock = DockStyle.Right;
            Log_out.FlatAppearance.BorderSize = 0;
            Log_out.FlatAppearance.MouseDownBackColor = Color.Red;
            Log_out.FlatAppearance.MouseOverBackColor = Color.Red;
            Log_out.FlatStyle = FlatStyle.Flat;
            Log_out.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Log_out.ForeColor = Color.White;
            Log_out.Location = new Point(1387, 0);
            Log_out.Name = "Log_out";
            Log_out.Size = new Size(178, 35);
            Log_out.TabIndex = 19;
            Log_out.Text = "CERRAR SESIÓN";
            Log_out.UseVisualStyleBackColor = false;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.FromArgb(220, 0, 0);
            Cerrar.Cursor = Cursors.Hand;
            Cerrar.Dock = DockStyle.Right;
            Cerrar.FlatAppearance.BorderSize = 0;
            Cerrar.FlatAppearance.MouseDownBackColor = Color.Red;
            Cerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cerrar.ForeColor = Color.White;
            Cerrar.Location = new Point(1565, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 20;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            // 
            // habitacio_btn
            // 
            habitacio_btn.BackColor = Color.Transparent;
            habitacio_btn.Cursor = Cursors.Hand;
            habitacio_btn.Dock = DockStyle.Left;
            habitacio_btn.FlatAppearance.BorderSize = 0;
            habitacio_btn.FlatAppearance.MouseDownBackColor = Color.Red;
            habitacio_btn.FlatAppearance.MouseOverBackColor = Color.Red;
            habitacio_btn.FlatStyle = FlatStyle.Flat;
            habitacio_btn.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            habitacio_btn.ForeColor = Color.White;
            habitacio_btn.Location = new Point(273, 0);
            habitacio_btn.Name = "habitacio_btn";
            habitacio_btn.Size = new Size(156, 35);
            habitacio_btn.TabIndex = 16;
            habitacio_btn.Text = " HABITACIÓN";
            habitacio_btn.UseVisualStyleBackColor = false;
            habitacio_btn.Click += habitacio_btn_Click;
            // 
            // Cliente_btn
            // 
            Cliente_btn.BackColor = Color.Transparent;
            Cliente_btn.Cursor = Cursors.Hand;
            Cliente_btn.Dock = DockStyle.Left;
            Cliente_btn.FlatAppearance.BorderSize = 0;
            Cliente_btn.FlatAppearance.MouseDownBackColor = Color.Red;
            Cliente_btn.FlatAppearance.MouseOverBackColor = Color.Red;
            Cliente_btn.FlatStyle = FlatStyle.Flat;
            Cliente_btn.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Cliente_btn.ForeColor = Color.White;
            Cliente_btn.Location = new Point(164, 0);
            Cliente_btn.Name = "Cliente_btn";
            Cliente_btn.Size = new Size(109, 35);
            Cliente_btn.TabIndex = 13;
            Cliente_btn.Text = "CLIENTE";
            Cliente_btn.UseVisualStyleBackColor = false;
            Cliente_btn.Click += Cliente_btn_Click;
            // 
            // inicio_btn
            // 
            inicio_btn.BackColor = Color.Transparent;
            inicio_btn.Cursor = Cursors.Hand;
            inicio_btn.Dock = DockStyle.Left;
            inicio_btn.FlatAppearance.BorderSize = 0;
            inicio_btn.FlatAppearance.MouseDownBackColor = Color.Red;
            inicio_btn.FlatAppearance.MouseOverBackColor = Color.Red;
            inicio_btn.FlatStyle = FlatStyle.Flat;
            inicio_btn.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            inicio_btn.ForeColor = Color.White;
            inicio_btn.Location = new Point(0, 0);
            inicio_btn.Name = "inicio_btn";
            inicio_btn.Size = new Size(164, 35);
            inicio_btn.TabIndex = 12;
            inicio_btn.Text = "RESERVACIÓN";
            inicio_btn.UseVisualStyleBackColor = false;
            inicio_btn.Click += inicio_btn_Click;
            // 
            // bitacora_boton
            // 
            bitacora_boton.BackColor = Color.FromArgb(121, 19, 30);
            bitacora_boton.Cursor = Cursors.Hand;
            bitacora_boton.FlatAppearance.BorderSize = 0;
            bitacora_boton.FlatAppearance.MouseDownBackColor = Color.Red;
            bitacora_boton.FlatAppearance.MouseOverBackColor = Color.Red;
            bitacora_boton.FlatStyle = FlatStyle.Flat;
            bitacora_boton.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bitacora_boton.ForeColor = Color.White;
            bitacora_boton.Location = new Point(513, 0);
            bitacora_boton.Name = "bitacora_boton";
            bitacora_boton.Size = new Size(217, 32);
            bitacora_boton.TabIndex = 34;
            bitacora_boton.Text = "BITÁCORA";
            bitacora_boton.UseVisualStyleBackColor = false;
            // 
            // reporte_boton
            // 
            reporte_boton.BackColor = Color.FromArgb(121, 19, 30);
            reporte_boton.Cursor = Cursors.Hand;
            reporte_boton.FlatAppearance.BorderSize = 0;
            reporte_boton.FlatAppearance.MouseDownBackColor = Color.Red;
            reporte_boton.FlatAppearance.MouseOverBackColor = Color.Red;
            reporte_boton.FlatStyle = FlatStyle.Flat;
            reporte_boton.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            reporte_boton.ForeColor = Color.White;
            reporte_boton.Location = new Point(514, 0);
            reporte_boton.Name = "reporte_boton";
            reporte_boton.Size = new Size(217, 32);
            reporte_boton.TabIndex = 33;
            reporte_boton.Text = "REPORTE";
            reporte_boton.UseVisualStyleBackColor = false;
            reporte_boton.Click += reporte_boton_Click;
            // 
            // usuario_boton
            // 
            usuario_boton.BackColor = Color.FromArgb(121, 19, 30);
            usuario_boton.Cursor = Cursors.Hand;
            usuario_boton.FlatAppearance.BorderSize = 0;
            usuario_boton.FlatAppearance.MouseDownBackColor = Color.Red;
            usuario_boton.FlatAppearance.MouseOverBackColor = Color.Red;
            usuario_boton.FlatStyle = FlatStyle.Flat;
            usuario_boton.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            usuario_boton.ForeColor = Color.White;
            usuario_boton.Location = new Point(514, 0);
            usuario_boton.Name = "usuario_boton";
            usuario_boton.Size = new Size(217, 32);
            usuario_boton.TabIndex = 32;
            usuario_boton.Text = "USUARIO";
            usuario_boton.UseVisualStyleBackColor = false;
            // 
            // tipo_btn
            // 
            tipo_btn.BackColor = Color.FromArgb(121, 19, 30);
            tipo_btn.Cursor = Cursors.Hand;
            tipo_btn.FlatAppearance.BorderSize = 0;
            tipo_btn.FlatAppearance.MouseDownBackColor = Color.Red;
            tipo_btn.FlatAppearance.MouseOverBackColor = Color.Red;
            tipo_btn.FlatStyle = FlatStyle.Flat;
            tipo_btn.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tipo_btn.ForeColor = Color.White;
            tipo_btn.Location = new Point(273, 0);
            tipo_btn.Name = "tipo_btn";
            tipo_btn.Size = new Size(156, 32);
            tipo_btn.TabIndex = 29;
            tipo_btn.Text = "TIPO";
            tipo_btn.UseVisualStyleBackColor = false;
            tipo_btn.Click += tipo_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(560, 58);
            label1.TabIndex = 0;
            label1.Text = "NUEVA RESERVACIÓN";
            // 
            // ID_cliente
            // 
            ID_cliente.BorderStyle = BorderStyle.FixedSingle;
            ID_cliente.Cursor = Cursors.IBeam;
            ID_cliente.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            ID_cliente.ForeColor = Color.Maroon;
            ID_cliente.Location = new Point(90, 148);
            ID_cliente.MaxLength = 14;
            ID_cliente.Name = "ID_cliente";
            ID_cliente.Size = new Size(200, 41);
            ID_cliente.TabIndex = 2;
            ID_cliente.TextAlign = HorizontalAlignment.Center;
            ID_cliente.KeyPress += ID_cliente_KeyPress;
            ID_cliente.Leave += ID_cliente_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(54, 118);
            label3.Name = "label3";
            label3.Size = new Size(167, 27);
            label3.TabIndex = 2;
            label3.Text = "Identificación";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Agregar_habitacion_a_reservar);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(guardar_res);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Nombre_Cliente);
            panel1.Controls.Add(ID1);
            panel1.Controls.Add(Cantidad_total);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(Descuento);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(Lista_Reservar);
            panel1.Controls.Add(habitaciones);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(f_salida);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(f_entrada);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ID_cliente);
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.Hand;
            panel1.ForeColor = Color.FromArgb(80, 22, 36);
            panel1.Location = new Point(185, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 738);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(552, 634);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 39;
            label2.Text = "##";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(165, 25, 42);
            label8.Location = new Point(405, 611);
            label8.Name = "label8";
            label8.Size = new Size(141, 46);
            label8.TabIndex = 38;
            label8.Text = "Nro. \r\nHabitaciones:";
            // 
            // Agregar_habitacion_a_reservar
            // 
            Agregar_habitacion_a_reservar.BackColor = Color.White;
            Agregar_habitacion_a_reservar.Cursor = Cursors.Hand;
            Agregar_habitacion_a_reservar.FlatStyle = FlatStyle.Flat;
            Agregar_habitacion_a_reservar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Agregar_habitacion_a_reservar.ForeColor = Color.FromArgb(165, 25, 42);
            Agregar_habitacion_a_reservar.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            Agregar_habitacion_a_reservar.IconColor = Color.FromArgb(165, 25, 42);
            Agregar_habitacion_a_reservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Agregar_habitacion_a_reservar.IconSize = 40;
            Agregar_habitacion_a_reservar.Location = new Point(409, 546);
            Agregar_habitacion_a_reservar.Name = "Agregar_habitacion_a_reservar";
            Agregar_habitacion_a_reservar.Size = new Size(161, 46);
            Agregar_habitacion_a_reservar.TabIndex = 7;
            Agregar_habitacion_a_reservar.Text = "SELECIONAR";
            Agregar_habitacion_a_reservar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Agregar_habitacion_a_reservar.UseVisualStyleBackColor = false;
            Agregar_habitacion_a_reservar.Click += Agregar_habitacion_a_reservar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(165, 25, 42);
            button4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            button4.IconColor = Color.FromArgb(165, 25, 42);
            button4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button4.IconSize = 40;
            button4.Location = new Point(987, 569);
            button4.Name = "button4";
            button4.Size = new Size(145, 46);
            button4.TabIndex = 10;
            button4.Text = "ELIMINAR";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(165, 25, 42);
            button2.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            button2.IconColor = Color.FromArgb(165, 25, 42);
            button2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button2.IconSize = 40;
            button2.Location = new Point(987, 449);
            button2.Name = "button2";
            button2.Size = new Size(145, 46);
            button2.TabIndex = 8;
            button2.Text = "CALCULAR";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // guardar_res
            // 
            guardar_res.BackColor = Color.White;
            guardar_res.FlatStyle = FlatStyle.Flat;
            guardar_res.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guardar_res.ForeColor = Color.FromArgb(165, 25, 42);
            guardar_res.IconChar = FontAwesome.Sharp.IconChar.Add;
            guardar_res.IconColor = Color.FromArgb(165, 25, 42);
            guardar_res.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guardar_res.IconSize = 40;
            guardar_res.Location = new Point(987, 629);
            guardar_res.Name = "guardar_res";
            guardar_res.Size = new Size(145, 46);
            guardar_res.TabIndex = 11;
            guardar_res.Text = "RESERVAR";
            guardar_res.TextImageRelation = TextImageRelation.ImageBeforeText;
            guardar_res.UseVisualStyleBackColor = false;
            guardar_res.Click += guardar_res_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(165, 25, 42);
            button3.IconChar = FontAwesome.Sharp.IconChar.Broom;
            button3.IconColor = Color.FromArgb(165, 25, 42);
            button3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button3.IconSize = 40;
            button3.Location = new Point(987, 509);
            button3.Name = "button3";
            button3.Size = new Size(145, 46);
            button3.TabIndex = 9;
            button3.Text = "LIMPIAR";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.AutoSize = true;
            Nombre_Cliente.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre_Cliente.ForeColor = Color.FromArgb(165, 25, 42);
            Nombre_Cliente.Location = new Point(308, 156);
            Nombre_Cliente.Name = "Nombre_Cliente";
            Nombre_Cliente.Size = new Size(406, 33);
            Nombre_Cliente.TabIndex = 32;
            Nombre_Cliente.Text = "_______________________";
            // 
            // ID1
            // 
            ID1.AllowDrop = true;
            ID1.DropDownStyle = ComboBoxStyle.DropDownList;
            ID1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ID1.FormattingEnabled = true;
            ID1.ItemHeight = 33;
            ID1.Items.AddRange(new object[] { "V-", "E-", "J-" });
            ID1.Location = new Point(54, 148);
            ID1.Name = "ID1";
            ID1.Size = new Size(50, 41);
            ID1.TabIndex = 1;
            // 
            // Cantidad_total
            // 
            Cantidad_total.AutoSize = true;
            Cantidad_total.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Cantidad_total.ForeColor = Color.FromArgb(165, 25, 42);
            Cantidad_total.Location = new Point(1066, 412);
            Cantidad_total.Name = "Cantidad_total";
            Cantidad_total.Size = new Size(48, 27);
            Cantidad_total.TabIndex = 21;
            Cantidad_total.Text = "##";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(165, 25, 42);
            label14.Location = new Point(989, 412);
            label14.Name = "label14";
            label14.Size = new Size(76, 27);
            label14.TabIndex = 20;
            label14.Text = "Total:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(165, 25, 42);
            label13.Location = new Point(329, 228);
            label13.Name = "label13";
            label13.Size = new Size(129, 27);
            label13.TabIndex = 19;
            label13.Text = "Descuento";
            // 
            // Descuento
            // 
            Descuento.BorderStyle = BorderStyle.FixedSingle;
            Descuento.Cursor = Cursors.IBeam;
            Descuento.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Descuento.ForeColor = Color.Maroon;
            Descuento.Location = new Point(329, 258);
            Descuento.MaxLength = 6;
            Descuento.Name = "Descuento";
            Descuento.Size = new Size(249, 40);
            Descuento.TabIndex = 4;
            Descuento.TextAlign = HorizontalAlignment.Center;
            Descuento.KeyPress += Descuento_KeyPress;
            Descuento.Leave += Descuento_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(165, 25, 42);
            label11.Location = new Point(608, 372);
            label11.Name = "label11";
            label11.Size = new Size(280, 27);
            label11.TabIndex = 15;
            label11.Text = "Habitaciones a Reservar";
            // 
            // Lista_Reservar
            // 
            Lista_Reservar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lista_Reservar.FormattingEnabled = true;
            Lista_Reservar.ItemHeight = 19;
            Lista_Reservar.Items.AddRange(new object[] { "Fetching data from server..." });
            Lista_Reservar.Location = new Point(608, 407);
            Lista_Reservar.Name = "Lista_Reservar";
            Lista_Reservar.SelectionMode = SelectionMode.MultiSimple;
            Lista_Reservar.Size = new Size(319, 308);
            Lista_Reservar.TabIndex = 14;
            // 
            // habitaciones
            // 
            habitaciones.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            habitaciones.FormattingEnabled = true;
            habitaciones.ItemHeight = 19;
            habitaciones.Items.AddRange(new object[] { "Cargando..." });
            habitaciones.Location = new Point(47, 407);
            habitaciones.Name = "habitaciones";
            habitaciones.SelectionMode = SelectionMode.MultiSimple;
            habitaciones.Size = new Size(341, 308);
            habitaciones.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Maroon;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(54, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 41);
            comboBox1.TabIndex = 3;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(165, 25, 42);
            label7.Location = new Point(54, 228);
            label7.Name = "label7";
            label7.Size = new Size(219, 27);
            label7.TabIndex = 9;
            label7.Text = "Tipo de Habitación";
            // 
            // f_salida
            // 
            f_salida.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            f_salida.CalendarForeColor = Color.Maroon;
            f_salida.CalendarTitleBackColor = Color.DarkRed;
            f_salida.Location = new Point(900, 276);
            f_salida.Margin = new Padding(5);
            f_salida.Name = "f_salida";
            f_salida.Size = new Size(252, 23);
            f_salida.TabIndex = 6;
            f_salida.Value = new DateTime(2023, 10, 15, 0, 0, 0, 0);
            f_salida.Leave += f_salida_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(165, 25, 42);
            label6.Location = new Point(911, 244);
            label6.Name = "label6";
            label6.Size = new Size(184, 27);
            label6.TabIndex = 7;
            label6.Text = "Fecha de Salida";
            // 
            // f_entrada
            // 
            f_entrada.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            f_entrada.CalendarForeColor = Color.Maroon;
            f_entrada.CalendarTitleBackColor = Color.DarkRed;
            f_entrada.Location = new Point(603, 276);
            f_entrada.Margin = new Padding(5);
            f_entrada.MinDate = new DateTime(2023, 10, 15, 0, 0, 0, 0);
            f_entrada.Name = "f_entrada";
            f_entrada.Size = new Size(252, 23);
            f_entrada.TabIndex = 5;
            f_entrada.Value = new DateTime(2023, 10, 15, 0, 0, 0, 0);
            f_entrada.Leave += f_entrada_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(629, 244);
            label5.Name = "label5";
            label5.Size = new Size(203, 27);
            label5.TabIndex = 5;
            label5.Text = "Fecha de Entrada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(165, 25, 42);
            label4.Location = new Point(47, 373);
            label4.Name = "label4";
            label4.Size = new Size(291, 27);
            label4.TabIndex = 3;
            label4.Text = "Habitaciónes Disponibles";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(138, 17, 31);
            ClientSize = new Size(1620, 861);
            Controls.Add(panel3);
            Controls.Add(tipo_btn);
            Controls.Add(reporte_boton);
            Controls.Add(bitacora_boton);
            Controls.Add(usuario_boton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicion";
            WindowState = FormWindowState.Maximized;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label1;
        private TextBox ID_cliente;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private DateTimePicker f_entrada;
        private Label label5;
        private DateTimePicker f_salida;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Button inicio_btn;
        private Button Cerrar;
        private Button habitacio_btn;
        private Button Cliente_btn;
        private Button Log_out;
        private Button tipo_btn;
        private ListBox habitaciones;
        private ListBox Lista_Reservar;
        private Label label11;
        private Label Cantidad_total;
        private Label label14;
        private Label label13;
        private TextBox Descuento;
        private ComboBox ID1;
        private Label Nombre_Cliente;
        private FontAwesome.Sharp.IconButton button3;
        private FontAwesome.Sharp.IconButton guardar_res;
        private FontAwesome.Sharp.IconButton button4;
        private FontAwesome.Sharp.IconButton button2;
        private FontAwesome.Sharp.IconButton Agregar_habitacion_a_reservar;
        private Label label2;
        private Label label8;
        private Button button1;
        private FontAwesome.Sharp.IconButton hab_menu;
        private FontAwesome.Sharp.IconButton man_menu;
        private Button usuario_boton;
        private Button reporte_boton;
        private Button bitacora_boton;
    }
}