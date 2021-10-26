using System;

namespace PooEjercicios12Punto.Entidades
{
    public class Punto:ICloneable
    {
        private Cuadrante cuadrante;
        public int X { get; set; }

        public int Y { get; set; }

        public ColorDisponible ColorDisponible { get; set; }

        public bool TrazoFino { get; set; }

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Punto))
            {
                return false;
            }

            return this.X == ((Punto) obj).X && this.Y == ((Punto) obj).Y &&
                   this.TrazoFino == ((Punto) obj).TrazoFino &&
                   this.ColorDisponible == ((Punto) obj).ColorDisponible;
        }

        public override int GetHashCode()
        {
            return (X + Y).GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetCuadrante()
        {
            if (X>=0 && Y>=0)
            {
                cuadrante= Cuadrante.Primer_Cuadrante;
            }else if (X<0 && Y>0)
            {
                cuadrante= Cuadrante.Segundo_Cuadrante;
            }else if (X<0 && Y<0)
            {
                cuadrante= Cuadrante.Tercer_Cuadrante;
            }
            else
            {
                cuadrante= Cuadrante.Cuarto_Cuadrante;
            }

            var palabras = cuadrante.ToString().Split('_');
            return $"{palabras[0]} {palabras[1]}";
        }

        public double GetDistanciaAlOrigen()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public string GetCoordenadasPolares()
        {
            var distancia = GetDistanciaAlOrigen();
            var theta = Math.Atan(Y / X);//pronunciece tita
            return $"({distancia};{theta}";
        }
    }
}