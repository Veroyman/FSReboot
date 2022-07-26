namespace FSReboot
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.MinimizarButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.OlvidoUsuario_ContraseñaLabel = new System.Windows.Forms.Label();
            this.AccederButton = new System.Windows.Forms.Button();
            this.RecuerdameCheckBox = new System.Windows.Forms.CheckBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fSREBOOTDataSet = new FSReboot.FSREBOOTDataSet();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.usuariosTableAdapter = new FSReboot.FSREBOOTDataSetTableAdapters.UsuariosTableAdapter();
            this.PanelSuperior.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSREBOOTDataSet)).BeginInit();
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
            this.PanelSuperior.Size = new System.Drawing.Size(380, 32);
            this.PanelSuperior.TabIndex = 0;
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
            this.MinimizarButton.Location = new System.Drawing.Point(310, 0);
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
            this.CerrarButton.Location = new System.Drawing.Point(345, 0);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CerrarButton.Size = new System.Drawing.Size(35, 32);
            this.CerrarButton.TabIndex = 0;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // PanelInferior
            // 
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(0, 447);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(380, 32);
            this.PanelInferior.TabIndex = 1;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.label3);
            this.PanelContenedor.Controls.Add(this.OlvidoUsuario_ContraseñaLabel);
            this.PanelContenedor.Controls.Add(this.AccederButton);
            this.PanelContenedor.Controls.Add(this.RecuerdameCheckBox);
            this.PanelContenedor.Controls.Add(this.ContraseñaTextBox);
            this.PanelContenedor.Controls.Add(this.UsuarioTextBox);
            this.PanelContenedor.Controls.Add(this.label2);
            this.PanelContenedor.Controls.Add(this.label1);
            this.PanelContenedor.Controls.Add(this.shapeContainer1);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 32);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(380, 415);
            this.PanelContenedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(140, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "¡Registrarme!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OlvidoUsuario_ContraseñaLabel
            // 
            this.OlvidoUsuario_ContraseñaLabel.AutoSize = true;
            this.OlvidoUsuario_ContraseñaLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OlvidoUsuario_ContraseñaLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.OlvidoUsuario_ContraseñaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OlvidoUsuario_ContraseñaLabel.Location = new System.Drawing.Point(86, 334);
            this.OlvidoUsuario_ContraseñaLabel.Name = "OlvidoUsuario_ContraseñaLabel";
            this.OlvidoUsuario_ContraseñaLabel.Size = new System.Drawing.Size(211, 32);
            this.OlvidoUsuario_ContraseñaLabel.TabIndex = 13;
            this.OlvidoUsuario_ContraseñaLabel.Text = "¿Olvidó su nombre de usuario \r\no contraseña?";
            this.OlvidoUsuario_ContraseñaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccederButton
            // 
            this.AccederButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(209)))));
            this.AccederButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccederButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(92)))), ((int)(((byte)(162)))));
            this.AccederButton.FlatAppearance.BorderSize = 0;
            this.AccederButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.AccederButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccederButton.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.AccederButton.ForeColor = System.Drawing.Color.White;
            this.AccederButton.Location = new System.Drawing.Point(98, 232);
            this.AccederButton.Name = "AccederButton";
            this.AccederButton.Size = new System.Drawing.Size(183, 36);
            this.AccederButton.TabIndex = 11;
            this.AccederButton.Text = "ACCEDER";
            this.AccederButton.UseVisualStyleBackColor = false;
            this.AccederButton.Click += new System.EventHandler(this.AccederButton_Click);
            this.AccederButton.Paint += new System.Windows.Forms.PaintEventHandler(this.AccederButton_Paint);
            // 
            // RecuerdameCheckBox
            // 
            this.RecuerdameCheckBox.AutoSize = true;
            this.RecuerdameCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuariosBindingSource, "Recuerdame", true));
            this.RecuerdameCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.usuariosBindingSource, "Recuerdame", true));
            this.RecuerdameCheckBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.RecuerdameCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.RecuerdameCheckBox.Location = new System.Drawing.Point(71, 181);
            this.RecuerdameCheckBox.Name = "RecuerdameCheckBox";
            this.RecuerdameCheckBox.Size = new System.Drawing.Size(107, 22);
            this.RecuerdameCheckBox.TabIndex = 10;
            this.RecuerdameCheckBox.Text = "Recuérdame";
            this.RecuerdameCheckBox.UseVisualStyleBackColor = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.fSREBOOTDataSet;
            // 
            // fSREBOOTDataSet
            // 
            this.fSREBOOTDataSet.DataSetName = "FSREBOOTDataSet";
            this.fSREBOOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.ContraseñaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ContraseñaTextBox.Location = new System.Drawing.Point(71, 152);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(240, 23);
            this.ContraseñaTextBox.TabIndex = 9;
            this.ContraseñaTextBox.UseSystemPasswordChar = true;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre_Usuario", true));
            this.UsuarioTextBox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.UsuarioTextBox.Location = new System.Drawing.Point(71, 90);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(240, 23);
            this.UsuarioTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(68, 131);
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
            this.label1.Location = new System.Drawing.Point(68, 69);
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
            this.shapeContainer1.Size = new System.Drawing.Size(380, 415);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 71;
            this.lineShape1.X2 = 311;
            this.lineShape1.Y1 = 321;
            this.lineShape1.Y2 = 320;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(380, 479);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSREBOOTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button MinimizarButton;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button AccederButton;
        private System.Windows.Forms.CheckBox RecuerdameCheckBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OlvidoUsuario_ContraseñaLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label3;
        private FSREBOOTDataSet fSREBOOTDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private FSREBOOTDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}

