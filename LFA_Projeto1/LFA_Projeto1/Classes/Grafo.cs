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
            Nos = new List<No>();
            Arestas = new List<Aresta>();
        }
        public List<No> Nos { get; set; }
        public List<Aresta> Arestas { get; set; }
        public No CriarGrafos()
        {
            int x = Nos.Count +1;
            No no = new No(x);
            Nos.Add(no);
            return no;
        }
        public No CriarGrafos(string path)
        {
            int x = Nos.Count +1;
            No no = new No(x,path);
            Nos.Add(no);
            return no;
        }
        public No CriarGrafos(List<string> a)
        {
            int x = Nos.Count + 1;
            No no = new No(x,a);
            Nos.Add(no);
            return no;
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
                ret = Nos.Find(lambda => lambda.Id == a.Id);
            }

            return ret;
        }
    }
}
