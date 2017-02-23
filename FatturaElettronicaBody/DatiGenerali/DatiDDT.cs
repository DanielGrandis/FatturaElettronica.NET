﻿using FatturaElettronica.Common;
using System;
using System.Collections.Generic;
using System.Xml;

namespace FatturaElettronica.FatturaElettronicaBody.DatiGenerali
{
    /// <summary>
    /// Nei casi di fattura differita per indicare il documento con cui è stato consegnato il bene.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class DatiDDT : Common.BaseClassSerializable
    {

        private readonly List<int> _riferimentoNumeroLinea;

        /// <summary>
        /// Nei casi di fattura differita per indicare il documento con cui è stato consegnato il bene.
        /// </summary>
        public DatiDDT() {
            _riferimentoNumeroLinea = new List<int>();
        }


        public DatiDDT(XmlReader r) : base(r) { }

        /// IMPORTANT
        /// Each data property must be flagged with the Order attribute or it will be ignored.
        /// Also, properties must be listed with the precise order in the specification.
        
        /// <summary>
        /// Numero del documento di trasporto.
        /// </summary>
        [DataProperty]
        // ReSharper disable once InconsistentNaming
        public string NumeroDDT { get; set; }

        /// <summary>
        /// Data del documento di trasporto.
        /// </summary>
        [DataProperty]
        // ReSharper disable once InconsistentNaming
        public DateTime DataDDT { get; set; }

        /// <summary>
        /// Linea di dettaglio della fattura cui si riferisce il DDT (non viene valorizzato se il riferimento è all'intera fattura).
        /// </summary>
        [DataProperty]
        public List<int> RiferimentoNumeroLinea { get { return _riferimentoNumeroLinea; }}
    }
}
