using System;
using System.Data.SqlClient;
using System.Net.Sockets;
using Microsoft.Win32;

namespace SGRepositorio.Connection
{
    public class ResolveConnection
    {
        public SqlConnection Conexao = new SqlConnection(Connection());

        public static string Connection()
        {
            var registryKey = Registry.LocalMachine.OpenSubKey(@"Software");

            var key = registryKey.OpenSubKey(@"MNSalao");
            if (key == null)
                throw new Exception("Não foi possível recuperar as configurações do sistema no registro do windows.");

            return key.GetValue("ConnectionString").ToString();

            //return "Server = NOTE-GIU; Database = DBSalao; User Id = sa; Password = 190990";
        }


    }
}