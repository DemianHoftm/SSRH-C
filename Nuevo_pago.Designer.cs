namespace SRRH
{
    partial class Nuevo_pago
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
            panel2 = new Panel();
            button4 = new Button();
            ID_consul = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            Descuento = new TextBox();
            label1 = new Label();
            id_resv = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            guardar = new FontAwesome.Sharp.IconButton();
            tabPage2 = new TabPage();
            guaradar_trans = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            Banco_trans = new ComboBox();
            label6 = new Label();
            referencia_num = new TextBox();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(ID_consul);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(Descuento);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(id_resv);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.Maroon;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 276);
            panel2.TabIndex = 62;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(220, 0, 0);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Red;
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(636, 0);
            button4.Name = "button4";
            button4.Size = new Size(43, 35);
            button4.TabIndex = 8;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ID_consul
            // 
            ID_consul.DropDownStyle = ComboBoxStyle.DropDownList;
            ID_consul.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ID_consul.FormattingEnabled = true;
            ID_consul.Items.AddRange(new object[] { "Seleccionar", "Efectivo", "Tarjeta", "Transferencia" });
            ID_consul.Location = new Point(358, 206);
            ID_consul.Name = "ID_consul";
            ID_consul.Size = new Size(249, 41);
            ID_consul.TabIndex = 2;
            ID_consul.SelectionChangeCommitted += ID_consul_SelectionChangeCommitted;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(165, 25, 42);
            label12.Location = new Point(359, 177);
            label12.Name = "label12";
            label12.Size = new Size(190, 27);
            label12.TabIndex = 99;
            label12.Text = "Método de Pago";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(165, 25, 42);
            label13.Location = new Point(87, 177);
            label13.Name = "label13";
            label13.Size = new Size(104, 27);
            label13.TabIndex = 99;
            label13.Text = "Importe";
            // 
            // Descuento
            // 
            Descuento.BorderStyle = BorderStyle.FixedSingle;
            Descuento.Cursor = Cursors.IBeam;
            Descuento.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Descuento.ForeColor = Color.Maroon;
            Descuento.Location = new Point(87, 207);
            Descuento.MaxLength = 6;
            Descuento.Name = "Descuento";
            Descuento.Size = new Size(249, 40);
            Descuento.TabIndex = 1;
            Descuento.TextAlign = HorizontalAlignment.Center;
            Descuento.KeyPress += Descuento_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(146, 118);
            label1.Name = "label1";
            label1.Size = new Size(284, 27);
            label1.TabIndex = 99;
            label1.Text = "Número de Reservación:";
            // 
            // id_resv
            // 
            id_resv.AutoSize = true;
            id_resv.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            id_resv.ForeColor = Color.FromArgb(165, 25, 42);
            id_resv.Location = new Point(436, 118);
            id_resv.Name = "id_resv";
            id_resv.Size = new Size(120, 27);
            id_resv.TabIndex = 99;
            id_resv.Text = "######";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(348, 58);
            label2.TabIndex = 99;
            label2.Text = "NUEVO PAGO";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-12, 244);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(703, 213);
            tabControl1.TabIndex = 63;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(guardar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(695, 185);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // guardar
            // 
            guardar.BackColor = Color.White;
            guardar.Cursor = Cursors.Hand;
            guardar.FlatStyle = FlatStyle.Flat;
            guardar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guardar.ForeColor = Color.FromArgb(165, 25, 42);
            guardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            guardar.IconColor = Color.FromArgb(165, 25, 42);
            guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guardar.IconSize = 40;
            guardar.Location = new Point(264, 53);
            guardar.Name = "guardar";
            guardar.Size = new Size(172, 46);
            guardar.TabIndex = 4;
            guardar.Text = "AGREGAR";
            guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            guardar.UseVisualStyleBackColor = false;
            guardar.Click += guardar_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(guaradar_trans);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(Banco_trans);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(referencia_num);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(695, 185);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // guaradar_trans
            // 
            guaradar_trans.BackColor = Color.White;
            guaradar_trans.Cursor = Cursors.Hand;
            guaradar_trans.FlatStyle = FlatStyle.Flat;
            guaradar_trans.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guaradar_trans.ForeColor = Color.FromArgb(165, 25, 42);
            guaradar_trans.IconChar = FontAwesome.Sharp.IconChar.Add;
            guaradar_trans.IconColor = Color.FromArgb(165, 25, 42);
            guaradar_trans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guaradar_trans.IconSize = 40;
            guaradar_trans.Location = new Point(267, 93);
            guaradar_trans.Name = "guaradar_trans";
            guaradar_trans.Size = new Size(172, 46);
            guaradar_trans.TabIndex = 6;
            guaradar_trans.Text = "AGREGAR";
            guaradar_trans.TextImageRelation = TextImageRelation.ImageBeforeText;
            guaradar_trans.UseVisualStyleBackColor = false;
            guaradar_trans.Click += guaradar_trans_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(370, 11);
            label3.Name = "label3";
            label3.Size = new Size(259, 27);
            label3.TabIndex = 39;
            label3.Text = "Número de Referencia";
            // 
            // Banco_trans
            // 
            Banco_trans.DropDownStyle = ComboBoxStyle.DropDownList;
            Banco_trans.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Banco_trans.ForeColor = Color.FromArgb(165, 25, 42);
            Banco_trans.FormattingEnabled = true;
            Banco_trans.Items.AddRange(new object[] { "Seleccionar", "Banco Central de Venezuela", "Banco de Venezuela S.A. Banco Universal", "Venezolano de Crédito S.A. Banco Universal", "Banco Mercantil, C.A Banco Universal", "Banco Provincial, S.A. Banco Universal", "Bancaribe C.A. Banco Universal", "Banco Exterior C.A. Banco Universal", "Banco Occidental de Descuento, C.A. BOD Banco Universal", "Banco Caroní C.A. Banco Universal", "Banesco S.A.C.A. Banco Universal", "Banco Sofitasa C.A. Banco Universal", "Banco Plaza C.A. Banco Universal", "Banco de la Gente Emprendedora C.A. Bangente Banco Microfinanciero", "Banco del Pueblo Soberano, C.A. Banco de Desarrollo", "BFC Banco Fondo Común C.A. Banco Universal", "100% Banco, C.A. Banco Universal", "DelSur, C.A. Banco Universal", "Banco del Tesoro, C.A. Banco Universal", "Banco Agrícola de Venezuela, C.A Banco Universal", "Bancrecer, S.A. Banco Microfinanciero", "Mi Banco C.A. Banco Microfinanciero", "Banco Activo, C.A. Banco Universal", "Bancamiga, C.A. Banco Microfinanciero", "Banco Internacional de Desarrollo, C.A. Banco Universal", "Banplus, C.A. Banco Universal", "Banco Bicentenario C.A. Banco Universal", "Banco de la Fuerza Armada Nacional Bolivariana BANFANB Banco Universal", "Citibank N.A. Banco Universal", "Banco Nacional de Crédito, C.A. Banco Universal", "Instituto Municipal de Crédito Popular Institución Financiera" });
            Banco_trans.Location = new Point(92, 38);
            Banco_trans.Name = "Banco_trans";
            Banco_trans.Size = new Size(249, 41);
            Banco_trans.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(165, 25, 42);
            label6.Location = new Point(97, 11);
            label6.Name = "label6";
            label6.Size = new Size(80, 27);
            label6.TabIndex = 37;
            label6.Text = "Banco";
            // 
            // referencia_num
            // 
            referencia_num.BorderStyle = BorderStyle.FixedSingle;
            referencia_num.Cursor = Cursors.IBeam;
            referencia_num.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            referencia_num.ForeColor = Color.Maroon;
            referencia_num.Location = new Point(363, 38);
            referencia_num.MaxLength = 16;
            referencia_num.Name = "referencia_num";
            referencia_num.Size = new Size(249, 40);
            referencia_num.TabIndex = 5;
            referencia_num.TextAlign = HorizontalAlignment.Center;
            referencia_num.KeyPress += Descuento_KeyPress;
            // 
            // Nuevo_pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 19, 30);
            ClientSize = new Size(678, 424);
            Controls.Add(panel2);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Nuevo_pago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo_pago";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button4;
        private ComboBox ID_consul;
        private Label label12;
        private Label label13;
        private TextBox Descuento;
        private Label label1;
        private Label id_resv;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private FontAwesome.Sharp.IconButton guardar;
        private TabPage tabPage2;
        private FontAwesome.Sharp.IconButton guaradar_trans;
        private Label label3;
        private ComboBox Banco_trans;
        private Label label6;
        private TextBox referencia_num;
    }
}