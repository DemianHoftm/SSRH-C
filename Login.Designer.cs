namespace SRRH
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            nom = new TextBox();
            pass = new TextBox();
            panel1 = new Panel();
            Agregar_habitacion_a_reservar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 25, 42);
            label1.Location = new Point(158, 227);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 1;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 25, 42);
            label2.Location = new Point(160, 147);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // nom
            // 
            nom.BorderStyle = BorderStyle.FixedSingle;
            nom.Cursor = Cursors.IBeam;
            nom.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nom.ForeColor = Color.FromArgb(165, 25, 42);
            nom.Location = new Point(159, 169);
            nom.Name = "nom";
            nom.Size = new Size(209, 30);
            nom.TabIndex = 0;
            nom.TextAlign = HorizontalAlignment.Center;
            // 
            // pass
            // 
            pass.AcceptsTab = true;
            pass.BorderStyle = BorderStyle.FixedSingle;
            pass.Cursor = Cursors.IBeam;
            pass.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pass.ForeColor = Color.FromArgb(165, 25, 42);
            pass.Location = new Point(158, 250);
            pass.Margin = new Padding(5);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(208, 30);
            pass.TabIndex = 1;
            pass.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Agregar_habitacion_a_reservar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(nom);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(151, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 384);
            panel1.TabIndex = 5;
            // 
            // Agregar_habitacion_a_reservar
            // 
            Agregar_habitacion_a_reservar.BackColor = Color.White;
            Agregar_habitacion_a_reservar.FlatStyle = FlatStyle.Flat;
            Agregar_habitacion_a_reservar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Agregar_habitacion_a_reservar.ForeColor = Color.FromArgb(165, 25, 42);
            Agregar_habitacion_a_reservar.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            Agregar_habitacion_a_reservar.IconColor = Color.FromArgb(165, 25, 42);
            Agregar_habitacion_a_reservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Agregar_habitacion_a_reservar.IconSize = 40;
            Agregar_habitacion_a_reservar.Location = new Point(361, 318);
            Agregar_habitacion_a_reservar.Name = "Agregar_habitacion_a_reservar";
            Agregar_habitacion_a_reservar.Size = new Size(141, 46);
            Agregar_habitacion_a_reservar.TabIndex = 2;
            Agregar_habitacion_a_reservar.Text = "INGRESAR";
            Agregar_habitacion_a_reservar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Agregar_habitacion_a_reservar.UseVisualStyleBackColor = false;
            Agregar_habitacion_a_reservar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 25, 42);
            label3.Location = new Point(173, 39);
            label3.Name = "label3";
            label3.Size = new Size(183, 46);
            label3.TabIndex = 5;
            label3.Text = "S.R.R.H.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(800, 493);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión - SRRH";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox nom;
        private TextBox pass;
        private Panel panel1;
        private Label label3;
        private FontAwesome.Sharp.IconButton Agregar_habitacion_a_reservar;
    }
}