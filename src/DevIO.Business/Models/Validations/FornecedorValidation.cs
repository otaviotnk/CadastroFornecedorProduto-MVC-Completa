﻿using DevIO.Business.Models.Validations.Documentos;
using FluentValidation;

//VALIDACOES FEITAS COM TO FLUENT VALIDATION, PARA TRADUZIR AS MENSAGENS DE ERRO

namespace DevIO.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            string defaultMessage = "O campo {PropertyName} precisa ser fornecido";
            string lengthMessage = "O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres";

            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage(defaultMessage)
                .Length(2, 100)
                .WithMessage(lengthMessage);

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f=> CpfValidacao.Validar(f.Documento)).Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });
        }
    }
}