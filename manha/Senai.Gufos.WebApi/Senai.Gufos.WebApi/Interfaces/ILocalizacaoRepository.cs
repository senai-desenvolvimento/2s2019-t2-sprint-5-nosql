using Senai.Gufos.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.Gufos.WebApi.Interfaces
{
    public interface ILocalizacaoRepository
    {
        void Cadastrar(Localizacoes localizacoes);

        List<Localizacoes> Listar();
    }
}
