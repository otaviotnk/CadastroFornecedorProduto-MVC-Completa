using DevIO.Business.Models;
using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Text;
using DevIO.Business.Notificacoes;
using DevIO.Business.Interfaces;

namespace DevIO.Business.Services
{
    //Aqui ficam todos os metodos que fazem alteracao no BD

    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            //PROPAGA O ERRO ATÉ A CAMADA DE APRESENTACAO
            _notificador.Handle(new Notificacao(mensagem));
        }

        //TV - Generico de validacao
        //TE - generico de entidade
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
