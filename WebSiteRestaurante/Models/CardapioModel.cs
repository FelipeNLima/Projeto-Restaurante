using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Restaurante.Modelos;

namespace WebSiteRestaurante.Models
{
    public class CardapioModel
    {
        public int id_cardapio { get; set; }
        public float preco_item { get; set; }
        public string nome_item { get; set; }
        public ClasseCategoria_Cardapio Categoria { get; set; }
        public bool apagado { get; set; } = false;
    }
}