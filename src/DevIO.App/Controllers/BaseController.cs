using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

//CLASSE CRIADA PARA SERVIR DE BASE GLOBAL PARA TODAS AS CONTROLLERS

namespace DevIO.App.Controllers
{
    public abstract class BaseController : Controller
    {
        //SERVICO DE NOTIFICACOES PERSONALIZADAS

        private readonly INotificador _notificador;

        protected BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }
    }
}