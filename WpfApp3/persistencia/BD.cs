﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Model;

namespace WpfApp3.persistencia
{
    internal class BD
    {
        public static List<ideiainovacao> mybd = new();

        public static void SalvarBD(ideiainovacao i) => mybd.Add(i);

        public static List<ideiainovacao> RetornarBD() => mybd;
    }
}
