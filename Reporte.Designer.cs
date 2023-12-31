namespace SRRH
{
    partial class Reporte
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
            panel1 = new Panel();
            fecha = new ComboBox();
            label2 = new Label();
            generar_btn = new FontAwesome.Sharp.IconButton();
            condicion = new ComboBox();
            label1 = new Label();
            Cerrar = new Button();
            parametro = new ComboBox();
            label12 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(fecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(generar_btn);
            panel1.Controls.Add(condicion);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(parametro);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label5);
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 351);
            panel1.TabIndex = 57;
            // 
            // fecha
            // 
            fecha.DropDownStyle = ComboBoxStyle.DropDownList;
            fecha.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            fecha.FormattingEnabled = true;
            fecha.Items.AddRange(new object[] { "Seleccione", "2022", "2023" });
            fecha.Location = new Point(196, 230);
            fecha.Name = "fecha";
            fecha.Size = new Size(249, 41);
            fecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(197, 201);
            label2.Name = "label2";
            label2.Size = new Size(55, 27);
            label2.TabIndex = 61;
            label2.Text = "Año";
            // 
            // generar_btn
            // 
            generar_btn.BackColor = Color.White;
            generar_btn.Cursor = Cursors.Hand;
            generar_btn.FlatStyle = FlatStyle.Flat;
            generar_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generar_btn.ForeColor = Color.FromArgb(165, 25, 42);
            generar_btn.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            generar_btn.IconColor = Color.FromArgb(165, 25, 42);
            generar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            generar_btn.IconSize = 40;
            generar_btn.Location = new Point(234, 293);
            generar_btn.Name = "generar_btn";
            generar_btn.Size = new Size(172, 46);
            generar_btn.TabIndex = 4;
            generar_btn.Text = "GENERAR";
            generar_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            generar_btn.UseVisualStyleBackColor = false;
            generar_btn.Click += generar_btn_Click;
            // 
            // condicion
            // 
            condicion.DropDownStyle = ComboBoxStyle.DropDownList;
            condicion.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            condicion.FormattingEnabled = true;
            condicion.Items.AddRange(new object[] { "Seleccione", "Ingreso", "Cantidad", "Promedio de estadia", "Promedio de Huespedes" });
            condicion.Location = new Point(49, 142);
            condicion.Name = "condicion";
            condicion.Size = new Size(249, 41);
            condicion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(50, 113);
            label1.Name = "label1";
            label1.Size = new Size(123, 27);
            label1.TabIndex = 58;
            label1.Text = "Condición";
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
            Cerrar.Location = new Point(634, 0);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 6;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // parametro
            // 
            parametro.DropDownStyle = ComboBoxStyle.DropDownList;
            parametro.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            parametro.FormattingEnabled = true;
            parametro.Items.AddRange(new object[] { "Seleccione", "Habitacion", "Cliente", "Reservacion" });
            parametro.Location = new Point(351, 142);
            parametro.Name = "parametro";
            parametro.Size = new Size(249, 41);
            parametro.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(165, 25, 42);
            label12.Location = new Point(352, 113);
            label12.Name = "label12";
            label12.Size = new Size(129, 27);
            label12.TabIndex = 53;
            label12.Text = "Parámetro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 25, 42);
            label5.Location = new Point(20, 15);
            label5.Name = "label5";
            label5.Size = new Size(253, 58);
            label5.TabIndex = 47;
            label5.Text = "REPORTE";
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(702, 376);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reporte";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Reporte_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox condicion;
        private Label label1;
        private Button Cerrar;
        private ComboBox parametro;
        private Label label12;
        private Label label5;
        private FontAwesome.Sharp.IconButton generar_btn;
        private ComboBox fecha;
        private Label label2;
    }
}