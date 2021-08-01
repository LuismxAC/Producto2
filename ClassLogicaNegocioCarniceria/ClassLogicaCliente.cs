using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassAccesoSQL;
using System.Data.SqlClient;
using System.Data;

using ClassCapaIntedidades;

namespace ClassLogicaNegocioCarniceria
{
    public class ClassLogicaCliente
    {
        private ClassMiAccesoSQL objAcceso = 
            new ClassMiAccesoSQL(@"Data Source=DESKTOP-H5Q2S4F\MSSQLSERVER01;"+
                     "Initial Catalog=PedidosCarniceria; Integrated Security = true;");

        public Boolean InsertaCliente(Cliente nuevo, ref string mensaje_salida)
        {
            //arreglo de 6 parametros
            SqlParameter[] params1 = new SqlParameter[5];
            //params1[0] = new SqlParameter
            //{
            //    ParameterName = "id_cliente",
            //    SqlDbType = SqlDbType.Int,
            //    Direction = ParameterDirection.Input,
            //    Value = nuevo.id_Cliente
            //};

            params1[0] = new SqlParameter
            {
                ParameterName = "nombre",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevo.Nombre
            };

            params1[1] = new SqlParameter
            {
                ParameterName = "app",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevo.App
            };

            params1[2] = new SqlParameter
            {
                ParameterName = "apm",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevo.ApM
            };

            params1[3] = new SqlParameter
            {
                ParameterName = "celular",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevo.Celular
            };

            params1[4] = new SqlParameter
            {
                ParameterName = "correo",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo.Correo
            };

            string sentencia = "insert into Cliente values(@nombre,@app,@apm,@celular,@correo)";

            Boolean salida = false;

            salida = objAcceso.ModificaBDunPocoMasSegura(sentencia,
                objAcceso.AbrirConexion(ref mensaje_salida), ref mensaje_salida, params1);

            return salida;
        }


    }
}
