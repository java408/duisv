﻿namespace Duisv.Formularios
{
    partial class FrmInicioSesion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBxUsuario = new System.Windows.Forms.TextBox();
            this.TBxClave = new System.Windows.Forms.TextBox();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBxMinimizar = new System.Windows.Forms.PictureBox();
            this.PBxCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Duisv.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(170, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar sesión";
            // 
            // TBxUsuario
            // 
            this.TBxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxUsuario.Location = new System.Drawing.Point(137, 275);
            this.TBxUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBxUsuario.Name = "TBxUsuario";
            this.TBxUsuario.Size = new System.Drawing.Size(245, 23);
            this.TBxUsuario.TabIndex = 5;
            // 
            // TBxClave
            // 
            this.TBxClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxClave.Location = new System.Drawing.Point(137, 306);
            this.TBxClave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBxClave.Name = "TBxClave";
            this.TBxClave.Size = new System.Drawing.Size(245, 23);
            this.TBxClave.TabIndex = 6;
            this.TBxClave.UseSystemPasswordChar = true;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(195, 355);
            this.BtnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(129, 38);
            this.BtnIniciarSesion.TabIndex = 7;
            this.BtnIniciarSesion.Text = "Ingresar";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PBxMinimizar);
            this.panel1.Controls.Add(this.PBxCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 48);
            this.panel1.TabIndex = 8;
            // 
            // PBxMinimizar
            // 
            this.PBxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxMinimizar.Image = global::Duisv.Properties.Resources.minimizar;
            this.PBxMinimizar.Location = new System.Drawing.Point(455, 14);
            this.PBxMinimizar.Name = "PBxMinimizar";
            this.PBxMinimizar.Size = new System.Drawing.Size(23, 23);
            this.PBxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxMinimizar.TabIndex = 0;
            this.PBxMinimizar.TabStop = false;
            // 
            // PBxCerrar
            // 
            this.PBxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxCerrar.Image = global::Duisv.Properties.Resources.cerrar;
            this.PBxCerrar.Location = new System.Drawing.Point(484, 14);
            this.PBxCerrar.Name = "PBxCerrar";
            this.PBxCerrar.Size = new System.Drawing.Size(23, 23);
            this.PBxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxCerrar.TabIndex = 0;
            this.PBxCerrar.TabStop = false;
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TBxClave);
            this.Controls.Add(this.TBxUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicioSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBxUsuario;
        private System.Windows.Forms.TextBox TBxClave;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBxMinimizar;
        private System.Windows.Forms.PictureBox PBxCerrar;
    }
}