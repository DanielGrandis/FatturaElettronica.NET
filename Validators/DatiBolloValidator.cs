﻿using FluentValidation;
using FatturaElettronica.FatturaElettronicaBody.DatiGenerali;

namespace FatturaElettronica.Validators
{
    public class DatiBolloValidator : AbstractValidator<DatiBollo>
    {
        public DatiBolloValidator()
        {
            RuleFor(x => x.BolloVirtuale)
                .NotEmpty()
                .Equal("SI");
            RuleFor(x => x.ImportoBollo)
                .NotNull();
        }
    }
}
