using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using SGCore.Utils;
using SGEntidades.Entidades;
using SGEntidades.Enum;
using SGRepositorio.Connection;
using SGRepositorio.Creator;

namespace SGRepositorio.Repositorio
{
    public class ProfissionalRepositorio
    {
        private readonly ResolveConnection _connection = new ResolveConnection();

        public void Inserir(Profissional profissional)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Profissional.Inserir;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@Nome", profissional.Nome);
                command.Parameters.AddWithValue("@Nascimento", profissional.Nascimento);
                command.Parameters.AddWithValue("@Numero", profissional.Numero);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(profissional.Status));
                command.Parameters.AddWithValue("@Telefone", profissional.Telefone);
                command.Parameters.AddWithValue("@Endereco", profissional.Endereco);
                command.Parameters.AddWithValue("@Bairro", profissional.Bairro);
                command.Parameters.AddWithValue("@Email", profissional.Email);
                command.Parameters.AddWithValue("@Cidade", profissional.Cidade);
                command.Parameters.AddWithValue("@Celular", profissional.Celular);

                command.Parameters.ConvertToDbNull();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Inserir o profissional", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public void Editar(Profissional profissional)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Profissional.Update;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@IdProfissional", profissional.IdProfissional);
                command.Parameters.AddWithValue("@Nome", profissional.Nome);
                command.Parameters.AddWithValue("@Nascimento", profissional.Nascimento);
                command.Parameters.AddWithValue("@Numero", profissional.Numero);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(profissional.Status));
                command.Parameters.AddWithValue("@Telefone", profissional.Telefone);
                command.Parameters.AddWithValue("@Endereco", profissional.Endereco);
                command.Parameters.AddWithValue("@Bairro", profissional.Bairro);
                command.Parameters.AddWithValue("@Email", profissional.Email);
                command.Parameters.AddWithValue("@Cidade", profissional.Cidade);
                command.Parameters.AddWithValue("@Celular", profissional.Celular);

                command.Parameters.ConvertToDbNull();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Inserir o profissional", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }

        }

        public List<Profissional> RecuperarLista()
        {
            try
            {
                var lista = new List<Profissional>();
                _connection.Conexao.Open();
                var sql = Resource.Profissional.RecuperarLista;
                var command = new SqlCommand(sql, _connection.Conexao);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ProfissionalCreator(reader, "", null).Create());
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao RecuperarLista dos profissionais", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public List<Profissional> RecuperarParticipaAgenda()
        {
            try
            {
                var lista = new List<Profissional>();
                _connection.Conexao.Open();
                var sql = Resource.Profissional.RecuperarListaAgenda;
                var command = new SqlCommand(sql, _connection.Conexao);
                command.Parameters.AddWithValue("@ParticipaAgenda", "S");

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ProfissionalCreator(reader, "", null).Create());
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao RecuperarLista dos profissionais", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public Profissional Recuperar(Profissional profissional)
        {
            try
            {
                var lista = new Profissional();
                _connection.Conexao.Open();
                var sql = Resource.Profissional.RecuperarLista;
                var command = new SqlCommand(sql, _connection.Conexao);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista= new ProfissionalCreator(reader, "", null).Create();
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao RecuperarLista dos profissionais", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public void Deletar(Profissional profissional)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Profissional.Update;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@IdProfissional", profissional.IdProfissional);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(profissional.Status));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Inserir o profissional", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }
    }

}