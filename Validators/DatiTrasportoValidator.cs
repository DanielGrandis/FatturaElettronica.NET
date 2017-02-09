﻿using FluentValidation;
using FatturaElettronica.FatturaElettronicaBody.DatiGenerali;

namespace FatturaElettronica.Validators
{
    public class DatiTrasportoValidator : AbstractValidator<DatiTrasporto>
    {
        public DatiTrasportoValidator()
        {
            RuleFor(x => x.DatiAnagraficiVettore).SetValidator(new DatiAnagraficiVettoreValidator());
            RuleFor(x => x.MezzoTrasporto).Length(1, 80).Unless(x => string.IsNullOrEmpty(x.MezzoTrasporto));
            RuleFor(x => x.CausaleTrasporto).Length(1, 100).Unless(x => string.IsNullOrEmpty(x.CausaleTrasporto));
            RuleFor(x => x.Descrizione).Length(1, 100).Unless(x => string.IsNullOrEmpty(x.Descrizione));
            RuleFor(x => x.UnitaMisuraPeso).Length(1, 10).Unless(x => string.IsNullOrEmpty(x.UnitaMisuraPeso));
            RuleFor(x => x.TipoResa).IsValidTipoResaValue().Unless(x => string.IsNullOrEmpty(x.TipoResa));
            RuleFor(x => x.IndirizzoResa).SetValidator(new IndirizzoResaValidator());
        }
    }
}
