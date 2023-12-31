namespace SRRH
{
    partial class Consultar_reser
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
            panel1 = new Panel();
            restart_btn = new FontAwesome.Sharp.IconButton();
            Eliminar_btn = new FontAwesome.Sharp.IconButton();
            editar_btn = new FontAwesome.Sharp.IconButton();
            PAGO_BTN = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            id_resv = new Label();
            button2 = new FontAwesome.Sharp.IconButton();
            ID_ciente_actu = new Label();
            label5 = new Label();
            Cantidad_total = new Label();
            label13 = new Label();
            Descuento = new TextBox();
            Tabla = new DataGridView();
            ID_colu = new DataGridViewTextBoxColumn();
            Nom_cli = new DataGridViewTextBoxColumn();
            Telf_nom = new DataGridViewTextBoxColumn();
            Corr_ta = new DataGridViewTextBoxColumn();
            sa = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel2 = new Panel();
            Cerrar = new Button();
            Condicion_deleted = new CheckBox();
            button1 = new FontAwesome.Sharp.IconButton();
            ID_consul = new ComboBox();
            f_reser_max = new DateTimePicker();
            fe_est_con = new RadioButton();
            Fecha_re_Con = new RadioButton();
            label8 = new Label();
            id_reser = new TextBox();
            f_reser_min = new DateTimePicker();
            f_est_min = new DateTimePicker();
            label9 = new Label();
            f_est_max = new DateTimePicker();
            label10 = new Label();
            label12 = new Label();
            id2_consul = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(restart_btn);
            panel1.Controls.Add(Eliminar_btn);
            panel1.Controls.Add(editar_btn);
            panel1.Controls.Add(PAGO_BTN);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(id_resv);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(ID_ciente_actu);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Cantidad_total);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(Descuento);
            panel1.Controls.Add(Tabla);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(165, 25, 42);
            panel1.Location = new Point(12, 273);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 579);
            panel1.TabIndex = 3;
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
            restart_btn.Location = new Point(58, 531);
            restart_btn.Name = "restart_btn";
            restart_btn.Size = new Size(117, 35);
            restart_btn.TabIndex = 16;
            restart_btn.Text = "LIMPIAR";
            restart_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            restart_btn.UseVisualStyleBackColor = false;
            // 
            // Eliminar_btn
            // 
            Eliminar_btn.BackColor = Color.White;
            Eliminar_btn.Cursor = Cursors.Hand;
            Eliminar_btn.FlatStyle = FlatStyle.Flat;
            Eliminar_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Eliminar_btn.ForeColor = Color.FromArgb(165, 25, 42);
            Eliminar_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            Eliminar_btn.IconColor = Color.FromArgb(165, 25, 42);
            Eliminar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Eliminar_btn.IconSize = 40;
            Eliminar_btn.Location = new Point(972, 454);
            Eliminar_btn.Name = "Eliminar_btn";
            Eliminar_btn.Size = new Size(172, 46);
            Eliminar_btn.TabIndex = 15;
            Eliminar_btn.Text = "ELIMINAR";
            Eliminar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Eliminar_btn.UseVisualStyleBackColor = false;
            Eliminar_btn.Click += Eliminar_btn_Click;
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
            editar_btn.Location = new Point(972, 402);
            editar_btn.Name = "editar_btn";
            editar_btn.Size = new Size(172, 46);
            editar_btn.TabIndex = 13;
            editar_btn.Text = "EDITAR";
            editar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            editar_btn.UseVisualStyleBackColor = false;
            editar_btn.Click += editar_btn_Click;
            // 
            // PAGO_BTN
            // 
            PAGO_BTN.BackColor = Color.White;
            PAGO_BTN.Cursor = Cursors.Hand;
            PAGO_BTN.FlatStyle = FlatStyle.Flat;
            PAGO_BTN.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PAGO_BTN.ForeColor = Color.FromArgb(165, 25, 42);
            PAGO_BTN.IconChar = FontAwesome.Sharp.IconChar.Donate;
            PAGO_BTN.IconColor = Color.FromArgb(165, 25, 42);
            PAGO_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PAGO_BTN.IconSize = 40;
            PAGO_BTN.Location = new Point(794, 454);
            PAGO_BTN.Name = "PAGO_BTN";
            PAGO_BTN.Size = new Size(172, 46);
            PAGO_BTN.TabIndex = 14;
            PAGO_BTN.Text = "PAGO";
            PAGO_BTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            PAGO_BTN.UseVisualStyleBackColor = false;
            PAGO_BTN.Click += PAGO_BTN_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(165, 25, 42);
            label7.Location = new Point(763, 74);
            label7.Name = "label7";
            label7.Size = new Size(284, 27);
            label7.TabIndex = 47;
            label7.Text = "Número de Reservación:";
            // 
            // id_resv
            // 
            id_resv.AutoSize = true;
            id_resv.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            id_resv.ForeColor = Color.FromArgb(165, 25, 42);
            id_resv.Location = new Point(1053, 74);
            id_resv.Name = "id_resv";
            id_resv.Size = new Size(84, 27);
            id_resv.TabIndex = 46;
            id_resv.Text = "####";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(165, 25, 42);
            button2.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            button2.IconColor = Color.FromArgb(165, 25, 42);
            button2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button2.IconSize = 40;
            button2.Location = new Point(794, 402);
            button2.Name = "button2";
            button2.Size = new Size(172, 46);
            button2.TabIndex = 12;
            button2.Text = "CALCULAR";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ID_ciente_actu
            // 
            ID_ciente_actu.AutoSize = true;
            ID_ciente_actu.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ID_ciente_actu.ForeColor = Color.FromArgb(165, 25, 42);
            ID_ciente_actu.Location = new Point(859, 116);
            ID_ciente_actu.Name = "ID_ciente_actu";
            ID_ciente_actu.Size = new Size(146, 27);
            ID_ciente_actu.TabIndex = 44;
            ID_ciente_actu.Text = "#### ____";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(763, 116);
            label5.Name = "label5";
            label5.Size = new Size(98, 27);
            label5.TabIndex = 43;
            label5.Text = "Cliente:";
            // 
            // Cantidad_total
            // 
            Cantidad_total.AutoSize = true;
            Cantidad_total.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Cantidad_total.ForeColor = Color.FromArgb(165, 25, 42);
            Cantidad_total.Location = new Point(918, 277);
            Cantidad_total.Name = "Cantidad_total";
            Cantidad_total.Size = new Size(48, 27);
            Cantidad_total.TabIndex = 37;
            Cantidad_total.Text = "##";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(165, 25, 42);
            label13.Location = new Point(767, 178);
            label13.Name = "label13";
            label13.Size = new Size(129, 27);
            label13.TabIndex = 36;
            label13.Text = "Descuento";
            // 
            // Descuento
            // 
            Descuento.BorderStyle = BorderStyle.FixedSingle;
            Descuento.Cursor = Cursors.IBeam;
            Descuento.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Descuento.ForeColor = Color.Maroon;
            Descuento.Location = new Point(767, 208);
            Descuento.MaxLength = 6;
            Descuento.Name = "Descuento";
            Descuento.Size = new Size(249, 40);
            Descuento.TabIndex = 11;
            Descuento.TextAlign = HorizontalAlignment.Center;
            Descuento.KeyPress += Descuento_KeyPress;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { ID_colu, Nom_cli, Telf_nom, Corr_ta, sa, Balance });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(165, 25, 42);
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle2;
            Tabla.GridColor = Color.Gainsboro;
            Tabla.Location = new Point(58, 15);
            Tabla.MultiSelect = false;
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersWidth = 5;
            Tabla.RowTemplate.Height = 25;
            Tabla.ScrollBars = ScrollBars.Vertical;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.Size = new Size(637, 510);
            Tabla.TabIndex = 22;
            Tabla.DoubleClick += Tabla_DoubleClick;
            // 
            // ID_colu
            // 
            ID_colu.HeaderText = "Num";
            ID_colu.Name = "ID_colu";
            ID_colu.ReadOnly = true;
            ID_colu.Width = 89;
            // 
            // Nom_cli
            // 
            Nom_cli.HeaderText = "Cliente";
            Nom_cli.Name = "Nom_cli";
            Nom_cli.ReadOnly = true;
            Nom_cli.Width = 115;
            // 
            // Telf_nom
            // 
            Telf_nom.HeaderText = "Habs";
            Telf_nom.Name = "Telf_nom";
            Telf_nom.ReadOnly = true;
            Telf_nom.Width = 92;
            // 
            // Corr_ta
            // 
            Corr_ta.HeaderText = "Entrada";
            Corr_ta.Name = "Corr_ta";
            Corr_ta.ReadOnly = true;
            Corr_ta.Width = 124;
            // 
            // sa
            // 
            sa.HeaderText = "Salida";
            sa.Name = "sa";
            sa.ReadOnly = true;
            sa.Width = 105;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            Balance.Width = 124;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(767, 277);
            label1.Name = "label1";
            label1.Size = new Size(153, 27);
            label1.TabIndex = 13;
            label1.Text = "Monto Total:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(Cerrar);
            panel2.Controls.Add(Condicion_deleted);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(ID_consul);
            panel2.Controls.Add(f_reser_max);
            panel2.Controls.Add(fe_est_con);
            panel2.Controls.Add(Fecha_re_Con);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(id_reser);
            panel2.Controls.Add(f_reser_min);
            panel2.Controls.Add(f_est_min);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(f_est_max);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(id2_consul);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 255);
            panel2.TabIndex = 4;
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
            Cerrar.Location = new Point(1164, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 21;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // Condicion_deleted
            // 
            Condicion_deleted.AutoSize = true;
            Condicion_deleted.Checked = true;
            Condicion_deleted.CheckState = CheckState.Checked;
            Condicion_deleted.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Condicion_deleted.ForeColor = Color.FromArgb(165, 25, 42);
            Condicion_deleted.Location = new Point(360, 120);
            Condicion_deleted.Name = "Condicion_deleted";
            Condicion_deleted.Size = new Size(106, 31);
            Condicion_deleted.TabIndex = 3;
            Condicion_deleted.Text = "Estado";
            Condicion_deleted.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(165, 25, 42);
            button1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            button1.IconColor = Color.FromArgb(165, 25, 42);
            button1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button1.IconSize = 40;
            button1.Location = new Point(1014, 195);
            button1.Name = "button1";
            button1.Size = new Size(172, 46);
            button1.TabIndex = 10;
            button1.Text = "CONSULTAR";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ID_consul
            // 
            ID_consul.DropDownStyle = ComboBoxStyle.DropDownList;
            ID_consul.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ID_consul.FormattingEnabled = true;
            ID_consul.Items.AddRange(new object[] { "V-", "E-", "J-" });
            ID_consul.Location = new Point(31, 113);
            ID_consul.Name = "ID_consul";
            ID_consul.Size = new Size(50, 41);
            ID_consul.TabIndex = 0;
            // 
            // f_reser_max
            // 
            f_reser_max.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            f_reser_max.CalendarForeColor = Color.Maroon;
            f_reser_max.CalendarTitleBackColor = Color.DarkRed;
            f_reser_max.Location = new Point(722, 216);
            f_reser_max.Margin = new Padding(5);
            f_reser_max.Name = "f_reser_max";
            f_reser_max.Size = new Size(252, 23);
            f_reser_max.TabIndex = 9;
            f_reser_max.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            // 
            // fe_est_con
            // 
            fe_est_con.AutoSize = true;
            fe_est_con.Location = new Point(336, 174);
            fe_est_con.Name = "fe_est_con";
            fe_est_con.Size = new Size(14, 13);
            fe_est_con.TabIndex = 4;
            fe_est_con.UseVisualStyleBackColor = true;
            // 
            // Fecha_re_Con
            // 
            Fecha_re_Con.AutoSize = true;
            Fecha_re_Con.Location = new Point(702, 176);
            Fecha_re_Con.Name = "Fecha_re_Con";
            Fecha_re_Con.Size = new Size(14, 13);
            Fecha_re_Con.TabIndex = 7;
            Fecha_re_Con.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(165, 25, 42);
            label8.Location = new Point(31, 169);
            label8.Name = "label8";
            label8.Size = new Size(148, 27);
            label8.TabIndex = 25;
            label8.Text = "Reservación";
            // 
            // id_reser
            // 
            id_reser.BorderStyle = BorderStyle.FixedSingle;
            id_reser.Cursor = Cursors.IBeam;
            id_reser.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            id_reser.ForeColor = Color.Maroon;
            id_reser.Location = new Point(31, 199);
            id_reser.Name = "id_reser";
            id_reser.Size = new Size(249, 40);
            id_reser.TabIndex = 2;
            id_reser.TextAlign = HorizontalAlignment.Center;
            id_reser.KeyPress += id_reser_KeyPress;
            // 
            // f_reser_min
            // 
            f_reser_min.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            f_reser_min.CalendarForeColor = Color.Maroon;
            f_reser_min.CalendarTitleBackColor = Color.DarkRed;
            f_reser_min.Location = new Point(722, 194);
            f_reser_min.Margin = new Padding(5);
            f_reser_min.Name = "f_reser_min";
            f_reser_min.Size = new Size(252, 23);
            f_reser_min.TabIndex = 8;
            f_reser_min.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            f_reser_min.Leave += f_reser_min_Leave;
            // 
            // f_est_min
            // 
            f_est_min.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            f_est_min.CalendarForeColor = Color.Maroon;
            f_est_min.CalendarTitleBackColor = Color.DarkRed;
            f_est_min.Location = new Point(360, 196);
            f_est_min.Margin = new Padding(5);
            f_est_min.Name = "f_est_min";
            f_est_min.Size = new Size(252, 23);
            f_est_min.TabIndex = 5;
            f_est_min.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            f_est_min.Leave += f_est_min_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(165, 25, 42);
            label9.Location = new Point(360, 164);
            label9.Name = "label9";
            label9.Size = new Size(306, 27);
            label9.TabIndex = 18;
            label9.Text = "Rango de Fecha de estadia";
            // 
            // f_est_max
            // 
            f_est_max.CalendarFont = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            f_est_max.CalendarForeColor = Color.Maroon;
            f_est_max.CalendarTitleBackColor = Color.DarkRed;
            f_est_max.Location = new Point(360, 218);
            f_est_max.Margin = new Padding(5);
            f_est_max.Name = "f_est_max";
            f_est_max.Size = new Size(252, 23);
            f_est_max.TabIndex = 6;
            f_est_max.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(165, 25, 42);
            label10.Location = new Point(722, 162);
            label10.Name = "label10";
            label10.Size = new Size(252, 27);
            label10.TabIndex = 16;
            label10.Text = "Fecha de Reservación";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(165, 25, 42);
            label12.Location = new Point(31, 83);
            label12.Name = "label12";
            label12.Size = new Size(160, 27);
            label12.TabIndex = 13;
            label12.Text = "Identificacón";
            // 
            // id2_consul
            // 
            id2_consul.BorderStyle = BorderStyle.FixedSingle;
            id2_consul.Cursor = Cursors.IBeam;
            id2_consul.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            id2_consul.ForeColor = Color.Maroon;
            id2_consul.Location = new Point(31, 113);
            id2_consul.Name = "id2_consul";
            id2_consul.Size = new Size(249, 41);
            id2_consul.TabIndex = 1;
            id2_consul.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(20, 15);
            label3.Name = "label3";
            label3.Size = new Size(695, 58);
            label3.TabIndex = 1;
            label3.Text = "GESTIÓN DE RESERVACIÓN";
            // 
            // Consultar_reser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(1234, 864);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Consultar_reser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar_reser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Consulta;
        private DataGridView Tabla;
        private Button aregar_btn;
        private TextBox telef;
        private Label label1;
        private TextBox nombre;
        private DateTimePicker F_salida;
        private Label label4;
        private DateTimePicker F_entrada;
        private TextBox Descuento;
        private Label label13;
        private Label Cantidad_total;
        private DataGridViewTextBoxColumn ID_colu;
        private DataGridViewTextBoxColumn Nom_cli;
        private DataGridViewTextBoxColumn Telf_nom;
        private DataGridViewTextBoxColumn Corr_ta;
        private DataGridViewTextBoxColumn sa;
        private DataGridViewTextBoxColumn Balance;
        private Panel panel2;
        private ComboBox ID_consul;
        private DateTimePicker f_reser_max;
        private RadioButton fe_est_con;
        private RadioButton Fecha_re_Con;
        private Label label8;
        private TextBox id_reser;
        private DateTimePicker f_reser_min;
        private DateTimePicker f_est_min;
        private Label label9;
        private DateTimePicker f_est_max;
        private Label label10;
        private Label label12;
        private TextBox id2_consul;
        private Label label3;
        private Label ID_ciente_actu;
        private Label label5;
        private FontAwesome.Sharp.IconButton button2;
        private Label label7;
        private Label id_resv;
        private FontAwesome.Sharp.IconButton PAGO_BTN;
        private FontAwesome.Sharp.IconButton button1;
        private CheckBox Condicion_deleted;
        private FontAwesome.Sharp.IconButton editar_btn;
        private FontAwesome.Sharp.IconButton Eliminar_btn;
        private FontAwesome.Sharp.IconButton restart_btn;
        private Button Cerrar;
    }
}