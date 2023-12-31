namespace SRRH
{
    partial class Agregar_Cliente
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
            label1 = new Label();
            iD2 = new TextBox();
            panel1 = new Panel();
            aregar_btn = new FontAwesome.Sharp.IconButton();
            ID1 = new ComboBox();
            Cerrar = new Button();
            corr = new TextBox();
            label5 = new Label();
            telf = new TextBox();
            label4 = new Label();
            NOMBRE = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(299, 32);
            label1.Name = "label1";
            label1.Size = new Size(167, 27);
            label1.TabIndex = 15;
            label1.Text = "Identificacion";
            // 
            // iD2
            // 
            iD2.BorderStyle = BorderStyle.FixedSingle;
            iD2.Cursor = Cursors.IBeam;
            iD2.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            iD2.ForeColor = Color.FromArgb(165, 25, 42);
            iD2.Location = new Point(322, 69);
            iD2.MaxLength = 30;
            iD2.Name = "iD2";
            iD2.Size = new Size(211, 40);
            iD2.TabIndex = 2;
            iD2.TextAlign = HorizontalAlignment.Center;
            iD2.KeyPress += iD2_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(aregar_btn);
            panel1.Controls.Add(ID1);
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(corr);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(telf);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(NOMBRE);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iD2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1554, 121);
            panel1.TabIndex = 16;
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
            aregar_btn.Location = new Point(1438, 36);
            aregar_btn.Name = "aregar_btn";
            aregar_btn.Size = new Size(51, 46);
            aregar_btn.TabIndex = 6;
            aregar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            aregar_btn.UseVisualStyleBackColor = false;
            aregar_btn.Click += aregar_btn_Click_1;
            // 
            // ID1
            // 
            ID1.DropDownStyle = ComboBoxStyle.DropDownList;
            ID1.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ID1.FormattingEnabled = true;
            ID1.Items.AddRange(new object[] { "V-", "E-", "J-" });
            ID1.Location = new Point(277, 68);
            ID1.Name = "ID1";
            ID1.Size = new Size(50, 41);
            ID1.TabIndex = 1;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.FromArgb(220, 0, 0);
            Cerrar.Dock = DockStyle.Right;
            Cerrar.FlatAppearance.BorderSize = 0;
            Cerrar.FlatAppearance.MouseDownBackColor = Color.Red;
            Cerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cerrar.ForeColor = Color.White;
            Cerrar.Location = new Point(1517, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(37, 121);
            Cerrar.TabIndex = 7;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // corr
            // 
            corr.BorderStyle = BorderStyle.FixedSingle;
            corr.Cursor = Cursors.IBeam;
            corr.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            corr.ForeColor = Color.FromArgb(165, 25, 42);
            corr.Location = new Point(1099, 69);
            corr.MaxLength = 45;
            corr.Name = "corr";
            corr.Size = new Size(249, 40);
            corr.TabIndex = 5;
            corr.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(1114, 32);
            label5.Name = "label5";
            label5.Size = new Size(88, 27);
            label5.TabIndex = 22;
            label5.Text = "Correo";
            // 
            // telf
            // 
            telf.BorderStyle = BorderStyle.FixedSingle;
            telf.Cursor = Cursors.IBeam;
            telf.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            telf.ForeColor = Color.FromArgb(165, 25, 42);
            telf.Location = new Point(827, 69);
            telf.MaxLength = 30;
            telf.Name = "telf";
            telf.Size = new Size(249, 40);
            telf.TabIndex = 4;
            telf.TextAlign = HorizontalAlignment.Center;
            telf.KeyPress += iD2_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(165, 25, 42);
            label4.Location = new Point(842, 32);
            label4.Name = "label4";
            label4.Size = new Size(108, 27);
            label4.TabIndex = 20;
            label4.Text = "Telefono";
            // 
            // NOMBRE
            // 
            NOMBRE.BorderStyle = BorderStyle.FixedSingle;
            NOMBRE.Cursor = Cursors.IBeam;
            NOMBRE.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NOMBRE.ForeColor = Color.FromArgb(165, 25, 42);
            NOMBRE.Location = new Point(555, 69);
            NOMBRE.MaxLength = 30;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(249, 40);
            NOMBRE.TabIndex = 3;
            NOMBRE.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(570, 32);
            label3.Name = "label3";
            label3.Size = new Size(101, 27);
            label3.TabIndex = 18;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(45, 3);
            label2.Name = "label2";
            label2.Size = new Size(194, 116);
            label2.TabIndex = 16;
            label2.Text = "Nuevo \r\nCliente";
            // 
            // Agregar_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(1592, 145);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agregar_Cliente";
            StartPosition = FormStartPosition.Manual;
            Text = "Agregar_Cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox iD2;
        private Panel panel1;
        private Label label2;
        private TextBox NOMBRE;
        private Label label3;
        private TextBox corr;
        private Label label5;
        private TextBox telf;
        private Label label4;
        private Button Cerrar;
        private ComboBox ID1;
        private FontAwesome.Sharp.IconButton aregar_btn;
    }
}