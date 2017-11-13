using System;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Modelos
{
    class ClassePagamento
    {
        public int id_pagamento { get; set; }
        public float Valor { get; set; }
        public DateTime data { get; set; }
        public bool apagado { get; set; } = false;          
        public float troco { get; set; }
        public ClasseVenda id_venda { get; set; }
        public ClasseFormaPagamento id_formaPagamento { get; set; }
        public ClasseBandeira id_bandeiras { get; set; }
        public ClasseCaixa id_caixa { get; set; }


        //public bool CadastrarPagamento()
        //{

        //}

        //public bool AtualizarPagamento()
        //{

        //}

    }
}
