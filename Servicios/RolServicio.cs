﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Duisv.Modelos;

namespace Duisv.Servicios
{
    internal class RolServicio
    {
        private readonly string _cadenaConexion;

        public RolServicio()
        {
            _cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
        }

        public List<Rol> ObtenerListaRoles()
        {
            var roles = new List<Rol>();

            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerListaRoles", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var rol = new Rol
                                {
                                    RolId = lector["RolId"] as int?,
                                    Nombre = lector["Nombre"].ToString()
                                };

                                roles.Add(rol);
                            }
                        }
                    }
                }
            }

            return roles;
        }
    }
}
