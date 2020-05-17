using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia_II
{
    class ProyFinalMateria: Proyecto
    {
		private String materia;
		private int nroReuniones;
		private String[,] reuniones = new String[50, 2];
		public ProyFinalMateria(String materia, int nroPersonas) : base("Robot", nroPersonas)
		{
			this.materia = materia;
			this.nroReuniones = 3;
			this.reuniones[0, 0] = "09/05/20"; this.reuniones[0, 1] = "14:11 pm";
			this.reuniones[1, 0] = "10/05/20"; this.reuniones[1, 1] = "17:26 pm";
			this.reuniones[2, 0] = "30/07/2020"; this.reuniones[2, 1] = "09:30 am";
		}
		public override void Mostrar()
		{
			base.Mostrar();
			Console.WriteLine("\nPROYECTO FINAL:");
			Console.WriteLine("MATERIA: " + this.materia);
			Console.WriteLine("NRO DE REUNIONES: " + this.nroReuniones);
			Console.WriteLine("FECHA \t\t HORA");
			for (int i = 0; i < nroReuniones; i++)
			{
				Console.WriteLine(reuniones[i, 0] + "\t" + reuniones[i, 1]);
			}
		}

		public String getMateria()
		{
			return materia;
		}
		public void setMateria(String materia)
		{
			this.materia = materia;
		}

		public int getNroReuniones()
		{
			return nroReuniones;
		}
		public void setNroReuniones(int nroReuniones)
		{
			this.nroReuniones = nroReuniones;
		}

		public String[,] getReuniones()
		{
			return reuniones;
		}
		public void setReuniones(String[,] reuniones)
		{
			this.reuniones = reuniones;
		}
	}
}
