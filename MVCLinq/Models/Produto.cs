using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLinq.Models
{
    public class Produto
    {
        private int v;
        private string value1;
        private string value2;
        private string value3;

        public Produto(int v, string value1, string value2, string value3)
        {
            this.v = v;
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }
    }
}