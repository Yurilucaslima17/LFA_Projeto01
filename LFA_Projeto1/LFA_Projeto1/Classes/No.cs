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
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
                Value.Add(line);
        }
        public int Id { get; set; }
        public List<string> Value { get; set; }
        public string PalavraAleatoria()
        {
            Random r = new Random();

            string ret = Value[r.Next(0, Value.Count)];

            return ret;
        }

    }
}
