using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Pontos
    {
        private static int certo = 0;
        private static int erro = 0;

        public int Certo
        {
            get { return certo;  }
            set { certo = value; }
        }

        public int Erro
        {
            get { return erro; }
            set { erro = value; }
        }
    }
}
