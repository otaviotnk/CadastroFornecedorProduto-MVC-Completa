using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using static DevIO.Business.Models.Validations.Documentos.ValidacaoDocs;

namespace DevIO.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            string notEmptyMessage = "O campo {PropertyName} precisa ser fornecido.";
            string lengthMessage = "O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.";
            string documentMessage = "O campo precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.";
            string invalidDocument = "O documento fornecido é inválido.";

            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage(notEmptyMessage)
                .Length(2, 100).WithMessage(lengthMessage);

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () => 
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage(documentMessage);
                RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true)
                    .WithMessage(invalidDocument);
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage(documentMessage);
                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                    .WithMessage(invalidDocument);
            });
        }
    }
}
