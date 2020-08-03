using System.Collections.Generic;
using System.Linq;
using DevIO.Business.Intefaces;

namespace DevIO.Business.Notificacoes
{
    //O NOTIFICADOR IMPLEMENTA A INTERFACE
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        //MANIPULA A NOTIFICACAO, ADICIONANDO ELA(S) NA PILHA
        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }


        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        //VERIFICA SE EXISTE QUALQUER NOTIFICACAO
        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}