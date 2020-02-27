using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA_Projeto1.Classes
{
    public class No
    {
        public No(int i)
        {
            Id = i;
        }
        public No(int i, string path)
        {
            Id = i;
            if (path.Contains(".csv"))
            {
                Value = lerCSV(path);
            }
            else
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                    Value.Add(line);
            }
        }
        public No(int i, List<string> a)
        {
            Id = i;

            Value = a;
        }
        public int Id { get; set; }
        public List<string> Value { get; set; }
        public string PalavraAleatoria()
        {
            Random r = new Random();

            string ret = Value[r.Next(0, Value.Count)];

            return ret;
        }
        private List<string> lerCSV(string nome)
        {
            var lista = File.ReadAllText(nome).Split(',').ToList();
            return lista;
        }
    }
}
