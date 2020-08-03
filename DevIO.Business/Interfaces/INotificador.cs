using System;
using System.Collections.Generic;
using System.Text;
using DevIO.Business.Notificacoes;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);

    }
}
