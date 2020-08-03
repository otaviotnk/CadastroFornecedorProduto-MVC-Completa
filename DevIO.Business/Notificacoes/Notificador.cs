using DevIO.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DevIO.Business.Notificacoes
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;
        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            ///adiciona o item na lista de notificacoes
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            //retorna a lista de notificacoes
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            //retorna toda a lista de notificacoes
            return _notificacoes.Any();
        }
    }
}
