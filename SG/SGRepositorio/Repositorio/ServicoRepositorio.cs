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
    public class ServicoRepositorio
    {
        private readonly ResolveConnection _connection = new ResolveConnection();

        public void Inserir(Servico servico)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Servico.Inserir;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@Descricao", servico.Descricao);
                command.Parameters.AddWithValue("@Tempo", servico.Tempo);
                command.Parameters.AddWithValue("@Valor", servico.Valor);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(servico.Status));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Inserir o Servico", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public void Editar(Servico servico)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Servico.Update;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@IdServico", servico.IdServico);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(servico.Status));
                command.Parameters.AddWithValue("@Tempo", servico.Tempo);
                command.Parameters.AddWithValue("@Valor", servico.Valor);
                command.Parameters.AddWithValue("@Descricao", servico.Descricao);

                command.Parameters.ConvertToDbNull();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao editar o servico", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public List<Servico> RecuperarListaPorProfissional(Profissional profissional)
        {
            try
            {
                var list = new List<Servico>();
                _connection.Conexao.Open();
                var sql = Resource.Servico.RecuperarServicosPorProfissional;
                var command = new SqlCommand(sql, _connection.Conexao);
                command.Parameters.AddWithValue("@IdProfissional", profissional.IdProfissional);
                var reader = command.ExecuteReader();

                while (reader.Read()) { list.Add(new ServicoCreator(reader, "", null).Create()); }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao recuperar a lista de serviços do Profissional", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public List<Servico> RecuperarServicoPorAgenda(Agenda agenda)
        {
            try
            {
                var list = new List<Servico>();
                _connection.Conexao.Open();
                var sql = Resource.Servico.RecuperarServicosAgenda;
                var command = new SqlCommand(sql, _connection.Conexao);
                command.Parameters.AddWithValue("@IdAgenda", agenda.IdAgenda);
                var reader = command.ExecuteReader();

                while (reader.Read()) { list.Add(new ServicoCreator(reader, "", null).Create()); }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao recuperar a lista de serviços do Profissional", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public List<Servico> RecuperarLista(Status status)
        {
            try
            {
                var servicos = new List<Servico>();

                _connection.Conexao.Open();
                var sql = Resource.Servico.RecuperarListaStatus;

                if (status != Status.NaoInformado)
                    sql = sql + " where Status = @status";

                var command = new SqlCommand(sql, _connection.Conexao);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(status));
                var reader = command.ExecuteReader();

                while (reader.Read())
                    servicos.Add(new ServicoCreator(reader, "").Create());

                return servicos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro no Cadastro", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public Servico Recuperar(Servico servico)
        {
            try
            {
                var resp = new Servico();
                _connection.Conexao.Open();
                var sql = Resource.Servico.Recuperar;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@Idservico", servico.IdServico);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    resp = new ServicoCreator(reader, "").Create();
                }

                return resp;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na consulta", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public void Deletar(Servico servico)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Servico.UpdateStatus;
                var command = new SqlCommand(sql, _connection.Conexao);

                command.Parameters.AddWithValue("@IdServico", servico.IdServico);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(servico.Status));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro no Cadastro", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }
    }
}