using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA_Projeto1.Classes
{
    public class Grafo
    {
        public Grafo()
        {
            Grafos = new List<No>();
            Arestas = new List<Aresta>();
        }
        public List<No> Grafos { get; set; }
        public List<Aresta> Arestas { get; set; }
        public void CriarGrafos()
        {
            int x = Grafos.Count +1;
            Grafos.Add(new No(x));
        }
        public void CriarGrafos(string path)
        {
            int x = Grafos.Count +1;
            Grafos.Add(new No(x, path));
        }
        public void CriarAresta(No x, No y)
        {
            Arestas.Add(new Aresta(x, y));
        }
        public No Procurar(object x)
        {
            No ret = null;

            if(x is No)
            {
                No a = x as No;
                ret = Grafos.Find(lambda => lambda.Id == a.Id);
            }

            return ret;
        }
    }
}
