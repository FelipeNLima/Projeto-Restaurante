using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteRestaurante.Models
{
    public class ProdutoModel
    {
        public int id_produto { get; set; }
        public float preco_custo { get; set; }
        public string nome_produto { get; set; }
        public int estoque_atual { get; set; }
        public int estoque_minimo { get; set; }
        public ClasseCategoria_Produto categoria { get; set; }
        public bool apagado { get; set; } = false;
    }
}