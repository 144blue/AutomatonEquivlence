using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equivalencia_de_automatas
{
    public class Estado
    {


        public String[] Estados { get; set; }
        public int[] Salidas { get; set; }

        public String NombreGrupo;

        public String estado { get; set; }
        private Estado estadoPendiente = null;
        public Estado(String name)
        {
            estado = name;
            NombreGrupo = "";

        }

        public bool CompararSalidas(int[] SalidasB)
        {
            for (int i = 0; i < SalidasB.Length; i++)
            {
                if (!Salidas[i].Equals(SalidasB[i]))
                {
                    return false;
                }
            }

            return true;
        }
        public bool ComparadorSubEstados(List<String> A, List<String> B)
        {

            for (int i = 0; i < B.Count(); i++)
            {
                var varUno = B[i];

                if (!A.Contains(varUno))
                {
                    Console.WriteLine("VarUno " + B[i]);
                    return false;
                }

            }
            return true;

        }

        public bool ComparacionInternaMealy(List<String> grupo, Estado evaluado)
        {
            var estadoComparador = this.Estados;
            var estadoEvaluado = evaluado.Estados;
            int contadorResultado = 0;
            bool resultado = false;

            for (int i = 0; i < estadoComparador.Count(); i++)
            {
                var estCo1 = estadoComparador[i];
                var estEv1 = estadoEvaluado[i];

                List<string> resultadoEstados = grupo;
                foreach (var t in resultadoEstados)
                {
                    Console.WriteLine("resultado  " + t);

                }
                if (ComparadorSubEstados(resultadoEstados, grupo))
                {
                    contadorResultado++;
                    Console.WriteLine("Contador resultado " + contadorResultado);

                }
                if (contadorResultado.Equals(evaluado.Estados.Count()))
                {
                    Console.WriteLine("Resultado = true ");
                    resultado = true;
                }
            }

            return resultado;
        }

        public String CompararEstadosMealy(IEnumerable<IGrouping<string, Estado>> grupo, Estado evaluado)
        {
            var estadoComparador = this.Estados;
            var estadoEvaluado = evaluado.Estados;
            int contadorResultado = 0;
            bool resultado = false;


            for (int i = 0; i < estadoComparador.Count(); i++)
            {
                var estCo1 = estadoComparador[i];
                var estEv1 = estadoEvaluado[i];
                bool continua = true;


                List<string> busqueda = new List<string>() { estCo1, estEv1 };

                foreach (var estados in grupo)
                {


                    if (estados.Count() >= busqueda.Count() && continua)
                    {
                        List<string> resultadoEstados = estados.Select(e => e.estado).ToList();

                        foreach (var t in resultadoEstados)
                        {
                            Console.WriteLine("resultado  " + t);

                        }

                        if (ComparadorSubEstados(resultadoEstados, busqueda))
                        {
                            contadorResultado++;
                            Console.WriteLine("Contador resultado " + contadorResultado);
                            continua = false;
                        }
                        else
                        {
                            if (estadoPendiente == null)
                            {
                                estadoPendiente = evaluado;

                                Console.WriteLine("estadoPendiente " + evaluado.estado);
                            }
                            else if (!estadoPendiente.estado.Equals(evaluado.estado))
                            {
                                Console.WriteLine("Entré");
                                var est = estadoPendiente.Estados.ToList();
                                if (estadoPendiente.ComparacionInterna(est, evaluado))
                                {
                                    Console.WriteLine("EVALUADO NAME " + evaluado.estado);
                                    contadorResultado = 2;

                                    // NombreGrupo = estado;

                                    break;

                                }
                            }


                        }
                    }
                }
                if (contadorResultado.Equals(Salidas.Count()))
                {
                    Console.WriteLine("Resultado = true " + estCo1 + " , " + estEv1);
                    resultado = true;
                }

            }
            if (resultado == true)
            {
                evaluado.NombreGrupo = estado;
                NombreGrupo = estado;
            }
            else
            {
                evaluado.NombreGrupo = evaluado.estado;
            }

            return evaluado.NombreGrupo;
        }
        public bool ComparacionInterna(List<String> grupo, Estado evaluado)
        {
            var estadoComparador = this.Estados;
            var estadoEvaluado = evaluado.Estados;
            int contadorResultado = 0;
            bool resultado = false;

            for (int i = 0; i < estadoComparador.Count(); i++)
            {
                var estCo1 = estadoComparador[i];
                var estEv1 = estadoEvaluado[i];

                List<string> resultadoEstados = grupo;
                foreach (var t in resultadoEstados)
                {
                    Console.WriteLine("resultado  " + t);

                }
                if (ComparadorSubEstados(resultadoEstados, grupo))
                {
                    contadorResultado++;
                    Console.WriteLine("Contador resultado " + contadorResultado);

                }
                if (contadorResultado == 2)
                {
                    Console.WriteLine("Resultado = true ");
                    resultado = true;
                }
            }

            return resultado;
        }

        public String CompararEstadosMoore(IEnumerable<IGrouping<string, Estado>> grupo, Estado evaluado)
        {
            var estadoComparador = this.Estados;
            var estadoEvaluado = evaluado.Estados;
            int contadorResultado = 0;
            bool resultado = false;


            for (int i = 0; i < estadoComparador.Count() && !resultado; i++)
            {
                var estCo1 = estadoComparador[i];
                var estEv1 = estadoEvaluado[i];
                bool continua = true;

                Console.WriteLine("Cambio de busqueda");
                List<string> busqueda = new List<string>() { estCo1, estEv1 };
                Console.WriteLine("estados " + estCo1 + " , " + estEv1);

                foreach (var estados in grupo)
                {
                    if (estados.Count() >= busqueda.Count() && continua)
                    {
                        List<string> resultadoEstados = estados.Select(e => e.estado).ToList();

                        foreach (var t in resultadoEstados)
                        {
                            Console.WriteLine("resultado  " + t);

                        }

                        if (ComparadorSubEstados(resultadoEstados, busqueda))
                        {
                            contadorResultado++;
                            Console.WriteLine("Contador resultado " + contadorResultado);
                            continua = false;
                        }
                        else
                        {
                            if (estadoPendiente == null)
                            {
                                estadoPendiente = evaluado;

                                Console.WriteLine("estadoPendiente " + evaluado.estado);
                            }
                            else if (!estadoPendiente.estado.Equals(evaluado.estado))
                            {
                                Console.WriteLine("Entré");
                                var est = estadoPendiente.Estados.ToList();
                                if (estadoPendiente.ComparacionInterna(est, evaluado))
                                {
                                    Console.WriteLine("EVALUADO NAME " + evaluado.estado);
                                    contadorResultado = 2;

                                    // NombreGrupo = estado;

                                    break;

                                }


                            }

                            Console.WriteLine("Si");
                        }
                    }

                }
                if (contadorResultado == 2)
                {
                    Console.WriteLine("Resultado = true ");
                    resultado = true;
                }
            }
            if (resultado == true)
            {
                if (estadoPendiente == null)
                {
                    evaluado.NombreGrupo = estado;
                    NombreGrupo = estado;

                }


                else if (estadoPendiente != null)
                {
                    evaluado.NombreGrupo = estadoPendiente.NombreGrupo;
                    estadoPendiente = null;
                }
                Console.WriteLine("TRUE :Evaluado.estad " + evaluado.estado + " evaluado.nomG " + evaluado.NombreGrupo);
            }
            else
            {
                evaluado.NombreGrupo = evaluado.estado;
                //  NombreGrupo = estado;
                Console.WriteLine("Evaluado.estad " + evaluado.estado + " evaluado.nomG " + evaluado.NombreGrupo);
            }

            return evaluado.NombreGrupo;
        }
    }
}
