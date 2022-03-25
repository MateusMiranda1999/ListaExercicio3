using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.oito
{
    internal class Program
    {
        private const char _b = 'b';
        private const char _c = 'c';
        private const char _d = 'd';
        private const char _f = 'f';
        private const char _g = 'g';
        private const char _h = 'h';
        private const char _j = 'j';
        private const char _k = 'k';
        private const char _l = 'l';
        private const char _m = 'm';
        private const char _n = 'n';
        private const char _p = 'p';
        private const char _q = 'q';
        private const char _r = 'r';
        private const char _s = 's';
        private const char _t = 't';
        private const char _v = 'v';
        private const char _x = 'x';
        private const char _w = 'w';
        private const char _y = 'y';
        private const char _z = 'z';


        static void Main(string[] args)
        {
            int count = 0;

            try
            {
                Console.WriteLine("Digite o seu nome: ");
                string nome = Console.ReadLine().ToLower();

                for (int i = 0; i < nome.Length; i++)
                {
                    if (_b.Equals(nome[i])
                        || _c.Equals(nome[i])
                        || _d.Equals(nome[i])
                        || _f.Equals(nome[i])
                        || _g.Equals(nome[i])
                        || _h.Equals(nome[i])
                        || _j.Equals(nome[i])
                        || _k.Equals(nome[i])
                        || _l.Equals(nome[i])
                        || _m.Equals(nome[i])
                        || _n.Equals(nome[i])
                        || _p.Equals(nome[i])
                        || _q.Equals(nome[i])
                        || _r.Equals(nome[i])
                        || _s.Equals(nome[i])
                        || _t.Equals(nome[i])
                        || _v.Equals(nome[i])
                        || _x.Equals(nome[i])
                        || _w.Equals(nome[i])
                        || _y.Equals(nome[i])
                        || _z.Equals(nome[i]))
                        count++;
                }

                Console.WriteLine($"Seu nome possui {count} consoante(is)!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}