using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.br.com.ctvendas.model
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int qtd_estoque { get; set; }
        public decimal preco { get; set; }

        public int for_id { get; set; }
        //para associar o produto ao fornecedor
    }
}
