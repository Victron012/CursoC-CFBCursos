using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class Globais
    {
        public static string versao="1.0";
        public static bool logado=false;
        public static int nivel = 0; //0=Básico - 1=Gerente - 2=Master
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_academia.db";
        public static string caminhoBanco = caminho + @"\banco\" + nomeBanco;
    }
}
