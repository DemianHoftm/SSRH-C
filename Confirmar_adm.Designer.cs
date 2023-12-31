namespace SRRH
{
    partial class Confirmar_adm
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
            Cerrar = new Button();
            Agregar_habitacion_a_reservar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            pass = new TextBox();
            nom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(Agregar_habitacion_a_reservar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(nom);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 327);
            panel1.TabIndex = 6;
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
            Cerrar.Location = new Point(540, -1);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 4;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            // 
            // Agregar_habitacion_a_reservar
            // 
            Agregar_habitacion_a_reservar.BackColor = Color.White;
            Agregar_habitacion_a_reservar.FlatStyle = FlatStyle.Flat;
            Agregar_habitacion_a_reservar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Agregar_habitacion_a_reservar.ForeColor = Color.FromArgb(165, 25, 42);
            Agregar_habitacion_a_reservar.IconChar = FontAwesome.Sharp.IconChar.Check;
            Agregar_habitacion_a_reservar.IconColor = Color.FromArgb(165, 25, 42);
            Agregar_habitacion_a_reservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Agregar_habitacion_a_reservar.IconSize = 40;
            Agregar_habitacion_a_reservar.Location = new Point(223, 243);
            Agregar_habitacion_a_reservar.Name = "Agregar_habitacion_a_reservar";
            Agregar_habitacion_a_reservar.Size = new Size(156, 46);
            Agregar_habitacion_a_reservar.TabIndex = 3;
            Agregar_habitacion_a_reservar.Text = "CONFIRMAR";
            Agregar_habitacion_a_reservar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Agregar_habitacion_a_reservar.UseVisualStyleBackColor = false;
            Agregar_habitacion_a_reservar.Click += Agregar_habitacion_a_reservar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(3, 38);
            label3.Name = "label3";
            label3.Size = new Size(575, 36);
            label3.TabIndex = 5;
            label3.Text = "Ingrese los datos de un adminitrador";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pass
            // 
            pass.AcceptsTab = true;
            pass.BorderStyle = BorderStyle.FixedSingle;
            pass.Cursor = Cursors.IBeam;
            pass.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pass.ForeColor = Color.FromArgb(165, 25, 42);
            pass.Location = new Point(198, 192);
            pass.Margin = new Padding(5);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(208, 30);
            pass.TabIndex = 1;
            pass.TextAlign = HorizontalAlignment.Center;
            // 
            // nom
            // 
            nom.BorderStyle = BorderStyle.FixedSingle;
            nom.Cursor = Cursors.IBeam;
            nom.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nom.ForeColor = Color.FromArgb(165, 25, 42);
            nom.Location = new Point(199, 124);
            nom.Name = "nom";
            nom.Size = new Size(209, 30);
            nom.TabIndex = 0;
            nom.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(200, 102);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(198, 169);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 1;
            label1.Text = "Contraseña";
            // 
            // Confirmar_adm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(608, 351);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Confirmar_adm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar_adm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton Agregar_habitacion_a_reservar;
        private Label label3;
        private TextBox pass;
        private TextBox nom;
        private Label label2;
        private Label label1;
        private Button Cerrar;
    }
}