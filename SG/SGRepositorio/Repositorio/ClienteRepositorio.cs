using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGRepositorio.Connection;
using SGRepositorio.Creator;

namespace SGRepositorio.Repositorio
{
    public class ClienteRepositorio
    {
        private readonly ResolveConnection _connection = new ResolveConnection();

        public void Inserir(Cliente cliente)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Cliente.Inserir;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Nascimento", cliente.Nascimento);
                command.Parameters.AddWithValue("@Numero", cliente.Numero);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(cliente.Status));
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@CPF", cliente.CPF);
                command.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                command.Parameters.AddWithValue("@Celular", cliente.Celular);

                command.Parameters.ConvertToDbNull();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Inserir o cliente", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public void Editar(Cliente cliente)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Cliente.Update;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Nascimento", cliente.Nascimento);
                command.Parameters.AddWithValue("@Numero", cliente.Numero);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(cliente.Status));
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@CPF", cliente.CPF);
                command.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                command.Parameters.AddWithValue("@Celular", cliente.Celular);

                command.Parameters.ConvertToDbNull();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Editar o cliente", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }

        }

        public List<Cliente> RecuperarLista()
        {
            try
            {
                var lista = new List<Cliente>();
                _connection.Conexao.Open();
                var sql = Resource.Cliente.RecuperarLista;
                var command = new SqlCommand(sql, _connection.Conexao);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ClienteCreator(reader, "", null).Create());
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao RecuperarLista dos clientes", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public Cliente Recuperar(Cliente cliente)
        {
            try
            {
                var resp = new Cliente();
                _connection.Conexao.Open();
                var sql = Resource.Cliente.RecuperarLista;
                var command = new SqlCommand(sql, _connection.Conexao);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resp = new ClienteCreator(reader, "", null).Create();
                    }
                }

                return resp;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao recuperar o cliente", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public void Deletar(Cliente cliente)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Cliente.Update;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(cliente.Status));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao alterar o status do Cliente", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }
    }
}