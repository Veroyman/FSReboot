namespace FSReboot
{
    partial class Registro_de_Prueba
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_de_Prueba));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.MinimizarButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.ConfirmarContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ApellidosTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OlvidoUsuario_ContraseñaLabel = new System.Windows.Forms.Label();
            this.AccederButton = new System.Windows.Forms.Button();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.fSREBOOTDataSet = new FSReboot.FSREBOOTDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new FSReboot.FSREBOOTDataSetTableAdapters.UsuariosTableAdapter();
            this.PanelSuperior.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSREBOOTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelSuperior.Controls.Add(this.MinimizarButton);
            this.PanelSuperior.Controls.Add(this.CerrarButton);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(364, 32);
            this.PanelSuperior.TabIndex = 3;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // MinimizarButton
            // 
            this.MinimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizarButton.FlatAppearance.BorderSize = 0;
            this.MinimizarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinimizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarButton.Image")));
            this.MinimizarButton.Location = new System.Drawing.Point(294, 0);
            this.MinimizarButton.Name = "MinimizarButton";
            this.MinimizarButton.Size = new System.Drawing.Size(35, 32);
            this.MinimizarButton.TabIndex = 1;
            this.MinimizarButton.TabStop = false;
            this.MinimizarButton.UseVisualStyleBackColor = true;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarButton.FlatAppearance.BorderSize = 0;
            this.CerrarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("CerrarButton.Image")));
            this.CerrarButton.Location = new System.Drawing.Point(329, 0);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CerrarButton.Size = new System.Drawing.Size(35, 32);
            this.CerrarButton.TabIndex = 0;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.PanelContenedor.Controls.Add(this.ConfirmarContraseñaTextBox);
            this.PanelContenedor.Controls.Add(this.label6);
            this.PanelContenedor.Controls.Add(this.CorreoTextBox);
            this.PanelContenedor.Controls.Add(this.label5);
            this.PanelContenedor.Controls.Add(this.ApellidosTextBox);
            this.PanelContenedor.Controls.Add(this.label4);
            this.PanelContenedor.Controls.Add(this.NombresTextBox);
            this.PanelContenedor.Controls.Add(this.label3);
            this.PanelContenedor.Controls.Add(this.OlvidoUsuario_ContraseñaLabel);
            this.PanelContenedor.Controls.Add(this.AccederButton);
            this.PanelContenedor.Controls.Add(this.ContraseñaTextBox);
            this.PanelContenedor.Controls.Add(this.UsuarioTextBox);
            this.PanelContenedor.Controls.Add(this.label2);
            this.PanelContenedor.Controls.Add(this.label1);
            this.PanelContenedor.Controls.Add(this.shapeContainer1);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(364, 527);
            this.PanelContenedor.TabIndex = 5;
            // 
            // ConfirmarContraseñaTextBox
            // 
            this.ConfirmarContraseñaTextBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.ConfirmarContraseñaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ConfirmarContraseñaTextBox.Location = new System.Drawing.Point(62, 210);
            this.ConfirmarContraseñaTextBox.Name = "ConfirmarContraseñaTextBox";
            this.ConfirmarContraseñaTextBox.Size = new System.Drawing.Size(240, 23);
            this.ConfirmarContraseñaTextBox.TabIndex = 21;
            this.ConfirmarContraseñaTextBox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(59, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "CONFIRMAR CONTRASEÑA:";
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.CorreoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CorreoTextBox.Location = new System.Drawing.Point(62, 387);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(240, 23);
            this.CorreoTextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(59, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "CORREO:";
            // 
            // ApellidosTextBox
            // 
            this.ApellidosTextBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.ApellidosTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ApellidosTextBox.Location = new System.Drawing.Point(62, 328);
            this.ApellidosTextBox.Name = "ApellidosTextBox";
            this.ApellidosTextBox.Size = new System.Drawing.Size(240, 23);
            this.ApellidosTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(59, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "APELLIDOS:";
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.NombresTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.NombresTextBox.Location = new System.Drawing.Point(62, 270);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(240, 23);
            this.NombresTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(59, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "NOMBRES:";
            // 
            // OlvidoUsuario_ContraseñaLabel
            // 
            this.OlvidoUsuario_ContraseñaLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OlvidoUsuario_ContraseñaLabel.AutoSize = true;
            this.OlvidoUsuario_ContraseñaLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OlvidoUsuario_ContraseñaLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.OlvidoUsuario_ContraseñaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OlvidoUsuario_ContraseñaLabel.Location = new System.Drawing.Point(120, 495);
            this.OlvidoUsuario_ContraseñaLabel.Name = "OlvidoUsuario_ContraseñaLabel";
            this.OlvidoUsuario_ContraseñaLabel.Size = new System.Drawing.Size(106, 16);
            this.OlvidoUsuario_ContraseñaLabel.TabIndex = 13;
            this.OlvidoUsuario_ContraseñaLabel.Text = "Iniciar sesión";
            this.OlvidoUsuario_ContraseñaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OlvidoUsuario_ContraseñaLabel.Click += new System.EventHandler(this.OlvidoUsuario_ContraseñaLabel_Click);
            // 
            // AccederButton
            // 
            this.AccederButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AccederButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(209)))));
            this.AccederButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccederButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(92)))), ((int)(((byte)(162)))));
            this.AccederButton.FlatAppearance.BorderSize = 0;
            this.AccederButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.AccederButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccederButton.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.AccederButton.ForeColor = System.Drawing.Color.White;
            this.AccederButton.Location = new System.Drawing.Point(89, 427);
            this.AccederButton.Name = "AccederButton";
            this.AccederButton.Size = new System.Drawing.Size(183, 36);
            this.AccederButton.TabIndex = 11;
            this.AccederButton.Text = "REGISTRAR";
            this.AccederButton.UseVisualStyleBackColor = false;
            this.AccederButton.Click += new System.EventHandler(this.AccederButton_Click);
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.ContraseñaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ContraseñaTextBox.Location = new System.Drawing.Point(62, 151);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(240, 23);
            this.ContraseñaTextBox.TabIndex = 9;
            this.ContraseñaTextBox.UseSystemPasswordChar = true;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.UsuarioTextBox.Location = new System.Drawing.Point(62, 90);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(240, 23);
            this.UsuarioTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(59, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOMBRE DE USUARIO:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(364, 527);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 60;
            this.lineShape1.X2 = 300;
            this.lineShape1.Y1 = 480;
            this.lineShape1.Y2 = 479;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(0, 527);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(364, 32);
            this.PanelInferior.TabIndex = 4;
            // 
            // fSREBOOTDataSet
            // 
            this.fSREBOOTDataSet.DataSetName = "FSREBOOTDataSet";
            this.fSREBOOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.fSREBOOTDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Registro_de_Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 559);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_Prueba";
            this.Text = "Registrar Usuarios";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSREBOOTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button MinimizarButton;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button AccederButton;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Label OlvidoUsuario_ContraseñaLabel;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ApellidosTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConfirmarContraseñaTextBox;
        private System.Windows.Forms.Label label6;
        private FSREBOOTDataSet fSREBOOTDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private FSREBOOTDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}