namespace SRRH
{
    partial class Modulo_cliente
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
            button1 = new FontAwesome.Sharp.IconButton();
            Consulta = new FontAwesome.Sharp.IconButton();
            eliminar_btn = new FontAwesome.Sharp.IconButton();
            editar_btn = new FontAwesome.Sharp.IconButton();
            aregar_btn = new FontAwesome.Sharp.IconButton();
            Cerrar = new Button();
            label4 = new Label();
            checkBox1 = new CheckBox();
            ID1 = new ComboBox();
            label2 = new Label();
            correo = new TextBox();
            Tabla = new DataGridView();
            ID_colu = new DataGridViewTextBoxColumn();
            Nom_cli = new DataGridViewTextBoxColumn();
            Telf_nom = new DataGridViewTextBoxColumn();
            Corr_ta = new DataGridViewTextBoxColumn();
            label5 = new Label();
            telef = new TextBox();
            label1 = new Label();
            nombre = new TextBox();
            label3 = new Label();
            ID = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Consulta);
            panel1.Controls.Add(eliminar_btn);
            panel1.Controls.Add(editar_btn);
            panel1.Controls.Add(aregar_btn);
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(ID1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(correo);
            panel1.Controls.Add(Tabla);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(telef);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ID);
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 760);
            panel1.TabIndex = 2;
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
            button1.Location = new Point(15, 711);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 10;
            button1.Text = "LIMPIAR";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // Consulta
            // 
            Consulta.BackColor = Color.White;
            Consulta.Cursor = Cursors.Hand;
            Consulta.FlatStyle = FlatStyle.Flat;
            Consulta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Consulta.ForeColor = Color.FromArgb(165, 25, 42);
            Consulta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            Consulta.IconColor = Color.FromArgb(165, 25, 42);
            Consulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Consulta.IconSize = 40;
            Consulta.Location = new Point(671, 640);
            Consulta.Name = "Consulta";
            Consulta.Size = new Size(172, 46);
            Consulta.TabIndex = 8;
            Consulta.Text = "CONSULTAR";
            Consulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            Consulta.UseVisualStyleBackColor = false;
            Consulta.Click += button1_Click;
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
            eliminar_btn.Location = new Point(849, 640);
            eliminar_btn.Name = "eliminar_btn";
            eliminar_btn.Size = new Size(172, 46);
            eliminar_btn.TabIndex = 9;
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
            editar_btn.Location = new Point(849, 588);
            editar_btn.Name = "editar_btn";
            editar_btn.Size = new Size(172, 46);
            editar_btn.TabIndex = 7;
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
            aregar_btn.Location = new Point(671, 588);
            aregar_btn.Name = "aregar_btn";
            aregar_btn.Size = new Size(172, 46);
            aregar_btn.TabIndex = 6;
            aregar_btn.Text = "AGREGAR";
            aregar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            aregar_btn.UseVisualStyleBackColor = false;
            aregar_btn.Click += aregar_btn_Click;
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
            Cerrar.Location = new Point(998, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 21;
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
            label4.Size = new Size(549, 58);
            label4.TabIndex = 30;
            label4.Text = "GESTIÓN DE CLIENTE";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(165, 25, 42);
            checkBox1.Location = new Point(784, 519);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 31);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Estado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ID1
            // 
            ID1.DropDownStyle = ComboBoxStyle.DropDownList;
            ID1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ID1.FormattingEnabled = true;
            ID1.Items.AddRange(new object[] { "V-", "E-", "J-" });
            ID1.Location = new Point(708, 185);
            ID1.Name = "ID1";
            ID1.Size = new Size(50, 41);
            ID1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(723, 414);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 25;
            label2.Text = "Correo";
            // 
            // correo
            // 
            correo.BorderStyle = BorderStyle.FixedSingle;
            correo.Cursor = Cursors.IBeam;
            correo.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            correo.ForeColor = Color.FromArgb(165, 25, 42);
            correo.Location = new Point(708, 451);
            correo.MaxLength = 45;
            correo.Name = "correo";
            correo.Size = new Size(249, 40);
            correo.TabIndex = 4;
            correo.TextAlign = HorizontalAlignment.Center;
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
            Tabla.Columns.AddRange(new DataGridViewColumn[] { ID_colu, Nom_cli, Telf_nom, Corr_ta });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle2;
            Tabla.GridColor = Color.Gainsboro;
            Tabla.Location = new Point(15, 76);
            Tabla.MultiSelect = false;
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersWidth = 5;
            Tabla.RowTemplate.Height = 25;
            Tabla.ScrollBars = ScrollBars.Vertical;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.Size = new Size(637, 629);
            Tabla.TabIndex = 23;
            Tabla.Click += Tabla_Click;
            Tabla.DoubleClick += Tabla_DoubleClick;
            // 
            // ID_colu
            // 
            ID_colu.HeaderText = "ID";
            ID_colu.Name = "ID_colu";
            ID_colu.ReadOnly = true;
            ID_colu.Width = 65;
            // 
            // Nom_cli
            // 
            Nom_cli.HeaderText = "Nombre";
            Nom_cli.Name = "Nom_cli";
            Nom_cli.ReadOnly = true;
            Nom_cli.Width = 126;
            // 
            // Telf_nom
            // 
            Telf_nom.HeaderText = "Telefono";
            Telf_nom.Name = "Telf_nom";
            Telf_nom.ReadOnly = true;
            Telf_nom.Width = 133;
            // 
            // Corr_ta
            // 
            Corr_ta.HeaderText = "Correo";
            Corr_ta.Name = "Corr_ta";
            Corr_ta.ReadOnly = true;
            Corr_ta.Width = 113;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(723, 324);
            label5.Name = "label5";
            label5.Size = new Size(108, 27);
            label5.TabIndex = 17;
            label5.Text = "Teléfono";
            // 
            // telef
            // 
            telef.BorderStyle = BorderStyle.FixedSingle;
            telef.Cursor = Cursors.IBeam;
            telef.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            telef.ForeColor = Color.FromArgb(165, 25, 42);
            telef.Location = new Point(708, 361);
            telef.MaxLength = 14;
            telef.Name = "telef";
            telef.Size = new Size(249, 40);
            telef.TabIndex = 3;
            telef.TextAlign = HorizontalAlignment.Center;
            telef.KeyPress += ID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(723, 236);
            label1.Name = "label1";
            label1.Size = new Size(101, 27);
            label1.TabIndex = 13;
            label1.Text = "Nombre";
            // 
            // nombre
            // 
            nombre.BorderStyle = BorderStyle.FixedSingle;
            nombre.Cursor = Cursors.IBeam;
            nombre.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.ForeColor = Color.FromArgb(165, 25, 42);
            nombre.Location = new Point(708, 273);
            nombre.MaxLength = 30;
            nombre.Name = "nombre";
            nombre.Size = new Size(249, 40);
            nombre.TabIndex = 2;
            nombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(723, 149);
            label3.Name = "label3";
            label3.Size = new Size(167, 27);
            label3.TabIndex = 2;
            label3.Text = "Identificación";
            // 
            // ID
            // 
            ID.BorderStyle = BorderStyle.FixedSingle;
            ID.Cursor = Cursors.IBeam;
            ID.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            ID.ForeColor = Color.FromArgb(165, 25, 42);
            ID.Location = new Point(751, 185);
            ID.MaxLength = 14;
            ID.Name = "ID";
            ID.Size = new Size(206, 41);
            ID.TabIndex = 1;
            ID.TextAlign = HorizontalAlignment.Center;
            ID.KeyPress += ID_KeyPress;
            // 
            // Modulo_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(1068, 783);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Modulo_cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo_cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private TextBox ID;
        private Label label5;
        private TextBox telef;
        private Label label1;
        private TextBox nombre;
        private DataGridView Tabla;
        private Label label2;
        private TextBox correo;
        private DataGridViewTextBoxColumn ID_colu;
        private DataGridViewTextBoxColumn Nom_cli;
        private DataGridViewTextBoxColumn Telf_nom;
        private DataGridViewTextBoxColumn Corr_ta;
        private ComboBox ID1;
        private CheckBox checkBox1;
        private Label label4;
        private Button Cerrar;
        private FontAwesome.Sharp.IconButton aregar_btn;
        private FontAwesome.Sharp.IconButton editar_btn;
        private FontAwesome.Sharp.IconButton eliminar_btn;
        private FontAwesome.Sharp.IconButton Consulta;
        private FontAwesome.Sharp.IconButton button1;
    }
}