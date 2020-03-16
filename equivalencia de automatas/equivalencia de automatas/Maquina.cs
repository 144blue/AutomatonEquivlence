using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equivalencia_de_automatas
{
    public class Maquina
    {

        public const int Mealy = 1;
        public const int Moore = 0;

        public int type { get; set; }
        public Estado[] Lista { get; set; }
        public int Indice { get; set; }
        public Maquina(Estado[] lis, int tipo)
        {
            Lista = lis;
            Indice = 0;
            type = tipo;
        }

        public void AsignarParticion(IEnumerable<IGrouping<string, Estado>> grupo)
        {
            if (type == Mealy)
            {
                ParticionPnMealy(grupo);

            }
            else
            {
                ParticionPnMoore(grupo);

            }

        }
        public IEnumerable<IGrouping<string, Estado>> ParticionP0()
        {
            foreach (var n in Lista)
            {
                var v1 = n.Salidas;
                // Console.WriteLine("Estado de actual" +n.estado);

                foreach (var n2 in Lista)
                {
                    if (!n2.estado.Equals(n.estado))
                    {
                        var v2 = n2.Salidas;
                        // Console.WriteLine("Estado temp " + n2.estado);

                        if (n.CompararSalidas(v2) == true)
                        {
                            //Console.WriteLine("Salidas iguales " +n.estado+ " y " + n2.estado);
                            n.NombreGrupo = v1[0] + "";
                        }

                    }

                }
                if (n.NombreGrupo.Equals(""))
                {
                    n.NombreGrupo = n.estado;
                }

            }
            var p1 = Lista.GroupBy(m => m.NombreGrupo);
            return p1;
        }

        public void ParticionPnMealy(IEnumerable<IGrouping<string, Estado>> p1)
        {
            foreach (var e in p1)
            {
                var comparador = e.First();

                foreach (var evaluado in e)
                {
                    if (!evaluado.estado.Equals(comparador.estado))
                    {

                     //   Console.WriteLine("Evaluado " + evaluado.estado);
                     //   Console.WriteLine("Comparador " + comparador.estado);

                        comparador.CompararEstadosMealy(p1, evaluado);


                    }
                }

            }
        }

        public void ParticionPnMoore(IEnumerable<IGrouping<string, Estado>> p1)
        {
            foreach (var e in p1)
            {
                var comparador = e.First();

                foreach (var evaluado in e)
                {
                    if (!evaluado.estado.Equals(comparador.estado))
                    {

                     //   Console.WriteLine("Evaluado " + evaluado.estado);
                       // Console.WriteLine("Comparador " + comparador.estado);

                        comparador.CompararEstadosMoore(p1, evaluado);


                    }
                }

            }
        }

        public Maquina SumaMaquinas(Maquina A, Maquina B)
        {
            IEnumerable<Estado> Todos = A.Lista.Union(B.Lista);
            var a1 = A.Lista;
            var b2 = B.Lista;
            var total = a1.Count() + b2.Count();
            Estado[] sumaEstados = new Estado[total];

            for (int i = 0; i < a1.Count(); i++)
            {
                sumaEstados[i] = a1[i];

            }
            for (int i = 0; i < b2.Count(); i++)
            {
                sumaEstados[i] = b2[i];

            }


            for (int i=0; i < sumaEstados.Count(); i++)
            {
                sumaEstados[i] = Todos.ElementAt(i);
            }
            int SumaType = A.type;

            Maquina suma = new Maquina(sumaEstados, A.type);
            return suma;

        }
        public String ResultadoEquivalencia(Maquina A, Maquina B)
        {
            var p2 = Lista.GroupBy(m => m.NombreGrupo);
            String resultado = "";
            bool result = false;

            var Q0 = p2.First();
            var Qa = A.Lista.First().estado;
            var Qb = B.Lista.First().estado;

            // var res= Q0.Select(o => o.estado.Where(i => i.Equals(Qa) || i.Equals(Qb)));
            var res = Q0.Where(e => e.estado.Equals(Qa) || e.estado.Equals(Qb));


            if (res.Count() == 2)
            {
                result = true;
            }
            if (result)
            {
                resultado = "Son equivalentes";
            }
            else
            {
                resultado = "No son equivalentes";
            }
            return resultado;

        }

    }
}
