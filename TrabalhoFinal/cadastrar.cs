﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
   public class cadastrar
    {
        public void escolherAcao()
        {
            Console.WriteLine("-------------CADASTRAR---------------\n" +
                                         "O QUE Voce?\n" +
                                         "1-CLIENTE\n" +
                                         "2-ADMINISTRADOR");

          int acao=int.Parse(Console.ReadLine());
        }
        public int escolheraco(int acao)
        {
            switch (acao)
            {
                case 1:

                    break;
                case 2:

                    break;
            }
            
            return acao;
        }
        
        
       





    }
}
