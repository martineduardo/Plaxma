﻿namespace ProyectoPlaxmaNew.Administrador
{
    partial class DarAltaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DarAltaEmpleado));
            this.panel4 = new System.Windows.Forms.Panel();
            this.TablaCarro = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTN_Actualizar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Insertar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Bitacora = new System.Windows.Forms.Button();
            this.BTN_Solicitudes = new System.Windows.Forms.Button();
            this.BTN_AltaAuto = new System.Windows.Forms.Button();
            this.BTN_CerrarSesion = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCarro)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TablaCarro);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(575, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 318);
            this.panel4.TabIndex = 62;
            // 
            // TablaCarro
            // 
            this.TablaCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCarro.Location = new System.Drawing.Point(17, 16);
            this.TablaCarro.Name = "TablaCarro";
            this.TablaCarro.RowHeadersWidth = 51;
            this.TablaCarro.RowTemplate.Height = 24;
            this.TablaCarro.Size = new System.Drawing.Size(606, 192);
            this.TablaCarro.TabIndex = 37;
            this.TablaCarro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaCarro_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(267, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tabla con toda la informacón relevante a los empleados.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BTN_Actualizar);
            this.panel3.Controls.Add(this.BTN_Eliminar);
            this.panel3.Controls.Add(this.Contra);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.BTN_Insertar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Nombre);
            this.panel3.Controls.Add(this.Telefono);
            this.panel3.Controls.Add(this.ID);
            this.panel3.Controls.Add(this.Direccion);
            this.panel3.Location = new System.Drawing.Point(230, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 318);
            this.panel3.TabIndex = 61;
            // 
            // BTN_Actualizar
            // 
            this.BTN_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_Actualizar.FlatAppearance.BorderSize = 0;
            this.BTN_Actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Actualizar.ForeColor = System.Drawing.Color.LightGray;
            this.BTN_Actualizar.Location = new System.Drawing.Point(220, 252);
            this.BTN_Actualizar.Name = "BTN_Actualizar";
            this.BTN_Actualizar.Size = new System.Drawing.Size(94, 40);
            this.BTN_Actualizar.TabIndex = 56;
            this.BTN_Actualizar.Text = "Modificar";
            this.BTN_Actualizar.UseVisualStyleBackColor = false;
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_Eliminar.FlatAppearance.BorderSize = 0;
            this.BTN_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Eliminar.ForeColor = System.Drawing.Color.LightGray;
            this.BTN_Eliminar.Location = new System.Drawing.Point(120, 252);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(94, 40);
            this.BTN_Eliminar.TabIndex = 55;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // BTN_Insertar
            // 
            this.BTN_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_Insertar.FlatAppearance.BorderSize = 0;
            this.BTN_Insertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Insertar.ForeColor = System.Drawing.Color.LightGray;
            this.BTN_Insertar.Location = new System.Drawing.Point(20, 252);
            this.BTN_Insertar.Name = "BTN_Insertar";
            this.BTN_Insertar.Size = new System.Drawing.Size(94, 40);
            this.BTN_Insertar.TabIndex = 54;
            this.BTN_Insertar.Text = "Agregar";
            this.BTN_Insertar.UseVisualStyleBackColor = false;
            this.BTN_Insertar.Click += new System.EventHandler(this.BTN_Insertar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Datos Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Teléfono:";
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nombre.Location = new System.Drawing.Point(145, 88);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(156, 22);
            this.Nombre.TabIndex = 34;
            // 
            // Contra
            // 
            this.Contra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Contra.Location = new System.Drawing.Point(145, 193);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(156, 22);
            this.Contra.TabIndex = 35;
            // 
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Telefono.Location = new System.Drawing.Point(145, 156);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(156, 22);
            this.Telefono.TabIndex = 39;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ID.Location = new System.Drawing.Point(145, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(156, 22);
            this.ID.TabIndex = 36;
            // 
            // Direccion
            // 
            this.Direccion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Direccion.Location = new System.Drawing.Point(145, 121);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(156, 22);
            this.Direccion.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(224, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 54);
            this.panel2.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(614, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(370, 21);
            this.label11.TabIndex = 50;
            this.label11.Text = "Has Iniciado Sesión como Administrador(a).";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.BTN_Bitacora);
            this.panel1.Controls.Add(this.BTN_Solicitudes);
            this.panel1.Controls.Add(this.BTN_AltaAuto);
            this.panel1.Controls.Add(this.BTN_CerrarSesion);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 397);
            this.panel1.TabIndex = 59;
            // 
            // BTN_Bitacora
            // 
            this.BTN_Bitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_Bitacora.FlatAppearance.BorderSize = 0;
            this.BTN_Bitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Bitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Bitacora.ForeColor = System.Drawing.Color.LightGray;
            this.BTN_Bitacora.Location = new System.Drawing.Point(22, 266);
            this.BTN_Bitacora.Name = "BTN_Bitacora";
            this.BTN_Bitacora.Size = new System.Drawing.Size(180, 40);
            this.BTN_Bitacora.TabIndex = 58;
            this.BTN_Bitacora.Text = "Bitacora";
            this.BTN_Bitacora.UseVisualStyleBackColor = false;
            this.BTN_Bitacora.Click += new System.EventHandler(this.BTN_Bitacora_Click);
            // 
            // BTN_Solicitudes
            // 
            this.BTN_Solicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_Solicitudes.FlatAppearance.BorderSize = 0;
            this.BTN_Solicitudes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Solicitudes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Solicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Solicitudes.ForeColor = System.Drawing.Color.LightGray;
            this.BTN_Solicitudes.Location = new System.Drawing.Point(22, 221);
            this.BTN_Solicitudes.Name = "BTN_Solicitudes";
            this.BTN_Solicitudes.Size = new System.Drawing.Size(180, 40);
            this.BTN_Solicitudes.TabIndex = 57;
            this.BTN_Solicitudes.Text = "Solicitudes";
            this.BTN_Solicitudes.UseVisualStyleBackColor = false;
            this.BTN_Solicitudes.Click += new System.EventHandler(this.BTN_Solicitudes_Click);
            // 
            // BTN_AltaAuto
            // 
            this.BTN_AltaAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_AltaAuto.FlatAppearance.BorderSize = 0;
            this.BTN_AltaAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_AltaAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_AltaAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AltaAuto.ForeColor = System.Drawing.Color.LightGray;
            this.BTN_AltaAuto.Location = new System.Drawing.Point(22, 175);
            this.BTN_AltaAuto.Name = "BTN_AltaAuto";
            this.BTN_AltaAuto.Size = new System.Drawing.Size(180, 40);
            this.BTN_AltaAuto.TabIndex = 56;
            this.BTN_AltaAuto.Text = "Dar de alta Vehículo";
            this.BTN_AltaAuto.UseVisualStyleBackColor = false;
            this.BTN_AltaAuto.Click += new System.EventHandler(this.BTN_AltaAuto_Click);
            // 
            // BTN_CerrarSesion
            // 
            this.BTN_CerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.BTN_CerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_CerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CerrarSesion.ForeColor = System.Drawing.Color.LightGray;
            this.BTN_CerrarSesion.Location = new System.Drawing.Point(22, 312);
            this.BTN_CerrarSesion.Name = "BTN_CerrarSesion";
            this.BTN_CerrarSesion.Size = new System.Drawing.Size(180, 40);
            this.BTN_CerrarSesion.TabIndex = 55;
            this.BTN_CerrarSesion.Text = "Cerrar Sesión";
            this.BTN_CerrarSesion.UseVisualStyleBackColor = false;
            this.BTN_CerrarSesion.Click += new System.EventHandler(this.BTN_CerrarSesion_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(22, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 40);
            this.button4.TabIndex = 51;
            this.button4.Text = "Dar de alta de nuevo";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-42, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DarAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1222, 397);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DarAltaEmpleado";
            this.Text = "DarAltaEmpleado";
            this.Load += new System.EventHandler(this.DarAltaEmpleado_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCarro)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView TablaCarro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTN_Actualizar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Insertar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Bitacora;
        private System.Windows.Forms.Button BTN_Solicitudes;
        private System.Windows.Forms.Button BTN_AltaAuto;
        private System.Windows.Forms.Button BTN_CerrarSesion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}