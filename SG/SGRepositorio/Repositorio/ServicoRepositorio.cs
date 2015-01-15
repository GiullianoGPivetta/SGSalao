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
                var sql = Resource.Agenda.Inserir;
                var command = new SqlCommand(sql, _connection.Conexao);

                //command.Parameters.AddWithValue("@IdCliente", agenda.Cliente.IdCliente);
                //command.Parameters.AddWithValue("@IdProfissional", agenda.Profissional.IdProfissional);
                //command.Parameters.AddWithValue("@Data", agenda.Data);
                //command.Parameters.AddWithValue("@Situacao", EnumUtils<SituacaoAgenda>.GetValue<string>(agenda.Situacao));
                //command.Parameters.AddWithValue("@HoraInicio", agenda.HoraInicio);
                //command.Parameters.AddWithValue("@HoraFim", agenda.HoraFim);
                //command.Parameters.AddWithValue("@Complemento", agenda.Complemento);

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
                var sql = Resource.Agenda.Inserir;
                var command = new SqlCommand(sql, _connection.Conexao);

                //command.Parameters.AddWithValue("@IdAgenda", agenda.IdAgenda);
                //command.Parameters.AddWithValue("@IdCliente", agenda.Cliente.IdCliente);
                //command.Parameters.AddWithValue("@IdProfissional", agenda.Profissional.IdProfissional);
                //command.Parameters.AddWithValue("@Data", agenda.Data);
                //command.Parameters.AddWithValue("@Situacao", EnumUtils<SituacaoAgenda>.GetValue<string>(agenda.Situacao));
                //command.Parameters.AddWithValue("@HoraInicio", agenda.HoraInicio);
                //command.Parameters.AddWithValue("@HoraFim", agenda.HoraFim);
                //command.Parameters.AddWithValue("@Complemento", agenda.Complemento);
                //command.Parameters.ConvertToDbNull();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao editar a agenda", ex);
            }
            finally
            {
                _connection.Conexao.Close();
            }
        }

        public List<Servico> RecuperarListaAgenda(Agenda agenda)
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
                throw new Exception("Ocorreu um erro ao recuperar a lista de serviços da agenda", ex);
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
                var list = new List<Servico>();
                _connection.Conexao.Open();
                var sql = Resource.Agenda.RecuperarLista;
                var command = new SqlCommand(sql, _connection.Conexao);
                command.Parameters.AddWithValue("@Status", EnumUtils<Status>.GetValue<string>(status));

                var reader = command.ExecuteReader();


                //while (reader.Read())
                //{
                //    var agenda = new AgendaCreator(reader, "A",
                //                      new ClienteCreator(reader, "C", null),
                //                      new ProfissionalCreator(reader, "P", null)).Create();

                //    agenda.Servicos =
                //}

                return list;
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
                var sql = Resource.Agenda.Inserir;
                var command = new SqlCommand(sql, _connection.Conexao);

                //insertCommand.Parameters.AddWithValue("@Nome", cliente.Nome);

                command.Parameters.ConvertToDbNull();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {

                }

                return resp;
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

        public void Deletar(Servico servico)
        {
            try
            {
                _connection.Conexao.Open();
                var sql = Resource.Agenda.Inserir;
                var command = new SqlCommand(sql, _connection.Conexao);

                //insertCommand.Parameters.AddWithValue("@Nome", cliente.Nome);

                command.Parameters.ConvertToDbNull();
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