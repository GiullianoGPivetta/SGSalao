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
            var registryKey = Registry.LocalMachine.OpenSubKey(@"MNSalao");
            return registryKey.GetValue("ConnectionString").ToString();

            //return "Server = NOTE-GIU; Database = DBSalao; User Id = sa; Password = 190990";
        }


    }
}