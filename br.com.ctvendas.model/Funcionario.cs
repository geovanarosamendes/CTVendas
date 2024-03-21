using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.br.com.ctvendas.model
{
    public class Funcionario : Cliente
    {


        //Atributos e os Getter/Setter
        public string? senha { get; set; }
        public string? cargo { get; set; }
        public string? nivel_acesso { get; set; }
    }

  }

