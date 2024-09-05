using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.persistencia;

namespace WpfApp3.Model
{
    internal class ideiainovacao
    {
        public string Area { get; set; } = "";

        public string Ideia { get; set; } = "";

        public float Custo { get; set; } = 0;

        public Boolean CadastrarideiaInovacao(ideiainovacao i)
        { 
        
        BD.SalvarBD(i);
        
        return true;
        }
    }
}
