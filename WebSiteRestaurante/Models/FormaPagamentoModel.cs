using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteRestaurante.Models
{
    public class FormaPagamentoModel
    {
        public int id_formaPagamento { get; set; }
        public string tipo_pagamento { get; set; }
        public bool apagado { get; set; } = false;
    }
}