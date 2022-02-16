using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaRoupaAPIWeb.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public string UrlBanner { get; set; }
        public string UrlConteudo { get; set; }
        public string Descrição { get; set; }
    }
}
