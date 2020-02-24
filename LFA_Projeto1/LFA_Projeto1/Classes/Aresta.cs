using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA_Projeto1.Classes
{
    public class Aresta
    {
        public Aresta(No x, No y)
        {
            Node1 = x;
            Node2 = y;
        }
        public No Node1 { get; }
        public No Node2 { get; }
    }
}
