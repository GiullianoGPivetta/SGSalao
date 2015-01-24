using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGEntidades.DTO;
using SGEntidades.Entidades;
using SGRepositorio.Repositorio;

namespace SGServico.Servicos
{
    public class ServicoServico
    {
        private readonly ServicoRepositorio _repositorio = new ServicoRepositorio();

        public List<ServicoSelecionado> RecuperarListaPorProfissional(Profissional profissional)
        {
            var resp = _repositorio.RecuperarListaPorProfissional(profissional);
            var serv = resp.Select(servico => new ServicoSelecionado
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

    }
}
