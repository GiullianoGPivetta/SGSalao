using System.Collections.Generic;
using System.Linq;
using SGEntidades.Entidades;
using SGRepositorio.Repositorio;
using SGEntidades.Enum;

namespace SGServico.Servicos
{
    public class ServicoServico
    {
        private readonly ServicoRepositorio _repositorio = new ServicoRepositorio();

        public List<Servico> RecuperarListaPorProfissional(Profissional profissional)
        {
            var resp = _repositorio.RecuperarListaPorProfissional(profissional);
            var serv = resp.Select(servico => new Servico
            {
                IdServico = servico.IdServico,
                Descricao = servico.Descricao,
                Status = servico.Status,
                Valor = servico.Valor,
                Tempo = servico.Tempo,
                Selecionado = false
            }).ToList();

            return serv;

        }

        public void Inserir(Servico servico)
        {
            _repositorio.Inserir(servico);
        }

        public void Editar(Servico servico)
        {
            _repositorio.Editar(servico);
        }

        public void Deletar(Servico servico)
        {
            _repositorio.Deletar(servico);
        }

        public Servico recuperar(Servico servico)
        {
            return _repositorio.Recuperar(servico);
        }

        public List<Servico> RecuperarListaStatus(Status status)
        {
            return _repositorio.RecuperarLista(status);
        }


    }
}
