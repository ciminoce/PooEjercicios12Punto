using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PooEjercicios12Punto.Entidades;

namespace PooEjercicios12Punto.Datos
{
    public class RepositorioDePuntos
    {
        private readonly string _archivo = Environment.CurrentDirectory + @"\Puntos.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\Puntos.bak";
        
        private List<Punto> listaPuntos;

        public RepositorioDePuntos()
        {
            listaPuntos = new List<Punto>();
            listaPuntos = LeerDatosDelArchivo();
        }

        private List<Punto> LeerDatosDelArchivo()
        {
            var lista = new List<Punto>();
            StreamReader lector = new StreamReader(_archivo);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Punto punto = ConstruirPunto(linea);
                lista.Add(punto);
            }
            lector.Close();
            return lista;
        }

        private Punto ConstruirPunto(string linea)
        {
            var campos = linea.Split('|');
            return new Punto()
            {
                X = int.Parse(campos[0]),
                Y = int.Parse(campos[1]),
                ColorDisponible = (ColorDisponible) int.Parse(campos[2]),
                TrazoFino = bool.Parse(campos[3])
            };
        }

        public void Agregar(Punto punto)
        {
            //Agrego en Archivo
            StreamWriter escritor = new StreamWriter(_archivo, true);
            string linea = ConstruirLinea(punto);
            escritor.WriteLine(linea);
            escritor.Close();
            //Agrego en lista
            listaPuntos.Add(punto);
        }

        private string ConstruirLinea(Punto punto)
        {
            return $"{punto.X}|{punto.Y}|{punto.ColorDisponible.GetHashCode()}|{punto.TrazoFino}";
        }

        public void Borrar(Punto punto)
        {
            BorrarRegistroEnArchivo(punto);
            listaPuntos.Remove(punto);
        }

        private void BorrarRegistroEnArchivo(Punto punto)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Punto puntoEnArchivo = ConstruirPunto(linea);
                if (!puntoEnArchivo.Equals(punto))
                {
                    escritor.WriteLine(linea);
                }
            }

            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }

        public void Editar(Punto puntoBuscado, Punto puntoModificado)
        {
            EditarRegistroEnArchivo(puntoBuscado, puntoModificado);
            int index = listaPuntos.IndexOf(puntoBuscado);
            listaPuntos.RemoveAt(index);
            listaPuntos.Insert(index, puntoModificado);
        }

        private void EditarRegistroEnArchivo(Punto puntoBuscado, Punto puntoModificado)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var puntoEnArchivo = ConstruirPunto(linea);
                if (puntoEnArchivo.Equals(puntoBuscado))
                {
                    linea = ConstruirLinea(puntoModificado);

                }
                escritor.WriteLine(linea);
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }

        public int GetCantidad()
        {
            return listaPuntos.Count;
        }

        public List<Punto> GetLista()
        {
            return listaPuntos;
        }

        public List<Punto> GetListaOrdenadaPorXAsc()
        {
            return listaPuntos.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();
        }

        public List<Punto> GetListaOrdenadaPorXDesc()
        {
            return listaPuntos.OrderByDescending(p => p.X).ThenByDescending(p => p.Y).ToList();
        }

        public List<Punto> GetListaOrdenadaPorYAsc()
        {
            return listaPuntos.OrderBy(p => p.Y).ThenBy(p => p.X).ToList();
        }

        public List<Punto> GetListaOrdenadaPorYDesc()
        {
            return listaPuntos.OrderByDescending(p => p.Y).ThenByDescending(p => p.X).ToList();
        }

        public List<Punto> Filtrar()
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(Punto punto)
        {
            return listaPuntos.Contains(punto);
        }

        public List<Punto> FiltrarPorCuadrante(string cuadranteFiltro)
        {
            var listaFiltrada = new List<Punto>();
            foreach (var punto in listaPuntos)
            {
                var cuadranteDelPunto = punto.GetCuadrante();
                if (cuadranteDelPunto==cuadranteFiltro)
                {
                    listaFiltrada.Add(punto);
                }
            }

            return listaFiltrada;

        }

        public int GetCantidad(string cuadranteFiltro)
        {
            return listaPuntos.Count(p => p.GetCuadrante() == cuadranteFiltro);
        }

        
    }
}