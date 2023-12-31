namespace SRRH
{
    partial class BoxMessage
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
            panel = new Panel();
            Cuerpo_men = new Label();
            Cerrar = new Button();
            Aviso_arriba = new Label();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            no = new Button();
            si = new Button();
            tabPage4 = new TabPage();
            button1 = new Button();
            panel.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(165, 25, 42);
            panel.Controls.Add(Cuerpo_men);
            panel.ForeColor = Color.Maroon;
            panel.Location = new Point(-1, 39);
            panel.Name = "panel";
            panel.Size = new Size(716, 184);
            panel.TabIndex = 63;
            // 
            // Cuerpo_men
            // 
            Cuerpo_men.AutoSize = true;
            Cuerpo_men.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Cuerpo_men.ForeColor = Color.White;
            Cuerpo_men.Location = new Point(57, 86);
            Cuerpo_men.Name = "Cuerpo_men";
            Cuerpo_men.Size = new Size(64, 27);
            Cuerpo_men.TabIndex = 49;
            Cuerpo_men.Text = "Label";
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
            Cerrar.Location = new Point(659, 1);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(43, 35);
            Cerrar.TabIndex = 5;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += no_Click;
            // 
            // Aviso_arriba
            // 
            Aviso_arriba.AutoSize = true;
            Aviso_arriba.Font = new Font("Tahoma", 22F, FontStyle.Bold, GraphicsUnit.Point);
            Aviso_arriba.ForeColor = Color.White;
            Aviso_arriba.Location = new Point(3, 0);
            Aviso_arriba.Name = "Aviso_arriba";
            Aviso_arriba.Size = new Size(96, 36);
            Aviso_arriba.TabIndex = 64;
            Aviso_arriba.Text = "Aviso";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(-63, 158);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(768, 220);
            tabControl2.TabIndex = 66;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(165, 25, 42);
            tabPage3.Controls.Add(no);
            tabPage3.Controls.Add(si);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(760, 192);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "tabPage3";
            // 
            // no
            // 
            no.FlatStyle = FlatStyle.Flat;
            no.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            no.ForeColor = Color.White;
            no.Location = new Point(363, 65);
            no.Name = "no";
            no.Size = new Size(156, 41);
            no.TabIndex = 2;
            no.Text = "no";
            no.UseVisualStyleBackColor = true;
            no.Click += no_Click;
            // 
            // si
            // 
            si.FlatStyle = FlatStyle.Flat;
            si.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            si.ForeColor = Color.White;
            si.Location = new Point(186, 65);
            si.Name = "si";
            si.Size = new Size(156, 41);
            si.TabIndex = 1;
            si.Text = "Si";
            si.UseVisualStyleBackColor = true;
            si.Click += si_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(165, 25, 42);
            tabPage4.Controls.Add(button1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(760, 192);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "tabPage4";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(350, 70);
            button1.Name = "button1";
            button1.Size = new Size(156, 41);
            button1.TabIndex = 4;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BoxMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 22, 36);
            ClientSize = new Size(701, 305);
            Controls.Add(panel);
            Controls.Add(tabControl2);
            Controls.Add(Cerrar);
            Controls.Add(Aviso_arriba);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BoxMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BoxMessage";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel;
        private Button Cerrar;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        public Label Cuerpo_men;
        public Label Aviso_arriba;
        public Button si;
        public Button no;
    }
}