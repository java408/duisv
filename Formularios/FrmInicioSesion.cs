﻿using System;
using System.Windows.Forms;
using Duisv.Herramientas;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios
{
    public partial class FrmInicioSesion : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private Usuario _usuario;

        public FrmInicioSesion()
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();
        }

        private void IniciarSesion(string nombreUsuario, string clave)
        {
            if (_usuarioServicio.ValidarNombreUsuario(nombreUsuario) > 0)
            {
                var claveCodificada = Codificador.ObtenerClaveCodificada(string.Concat(nombreUsuario, clave));

                if (_usuarioServicio.ValidarClaveUsuario(claveCodificada) > 0)
                {
                    var usuario = _usuarioServicio.ObtenerUsuarioPorNombre(nombreUsuario);

                    if (usuario != null)
                    {
                        _usuario = usuario;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("La clave del usuario no es correcta.", "Iniciar sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario ingresado no es correcto.", "Iniciar sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Usuario ObtenerUsuarioLogeado()
        {
            return _usuario;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuario = TBxUsuario.Text;
            var clave = TBxClave.Text;

            if (!string.IsNullOrEmpty(usuario))
            {
                if (!string.IsNullOrEmpty(clave))
                {
                    IniciarSesion(usuario, clave);
                }
                else
                {
                    MessageBox.Show("La contraseña del usuario es requerida.", "Iniciar sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario es requerido.", "Iniciar sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChBVerClave_CheckedChanged(object sender, EventArgs e)
        {
            TBxClave.UseSystemPasswordChar = !ChBVerClave.Checked;
        }
    }
}
