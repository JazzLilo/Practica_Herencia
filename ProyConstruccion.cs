using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia_II
{
    class ProyConstruccion:Proyecto
    {
		private int nroMateriales;
		private String[,] material = new String[50, 2];
		private String lugar;
		private int presupuesto;

		public ProyConstruccion(int nroMateriales, String lugar, int presupuesto) : base("Casa", 3, "23/03/2022")
		{

			this.nroMateriales = nroMateriales;
			this.material[0, 0] = "Colores  "; this.material[0, 1] = "12";
			this.material[1, 0] = "Boligrafos "; this.material[1, 1] = "8";
			this.material[2, 0] = "Encendedor "; this.material[2, 1] = "8";
			this.lugar = lugar;
			this.presupuesto = presupuesto;
		}

		public override void Mostrar()
		{
			Console.WriteLine("\n PROYECTO EN CONSTRUCCION:");
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
			base.Mostrar();
			Console.WriteLine("LUGAR: " + this.lugar);
			Console.WriteLine("PRESUPUESTO EN Bs: " + this.presupuesto);
			Console.WriteLine("NROMATERIALES: " + this.nroMateriales);
			Console.WriteLine("MATERIAL \t CANTIDAD");
			for (int i = 0; i < nroMateriales; i++)
			{
				Console.WriteLine(material[i, 0] + "\t" + material[i, 1]);
			}
		}
		public int getNroMateriales()
		{
			return nroMateriales;
		}
		public void setNroMateriales(int nroMateriales)
		{
			this.nroMateriales = nroMateriales;
		}

		public String[,] getMaterial()
		{
			return material;
		}
		public void setMaterial(String[,] material)
		{
			this.material = material;
		}

		public String getLugar()
		{
			return lugar;
		}
		public void setLugar(String lugar)
		{
			this.lugar = lugar;
		}

		public int getPresupuesto()
		{
			return presupuesto;
		}
		public void setPresupuesto(int presupuesto)
		{
			this.presupuesto = presupuesto;
		}
		public void MostrarPersonas(Proyecto y)
		{
			Console.WriteLine("----------------------------------------");
			for (int i = 0; i < this.nroPersonas; i++)
			{
				for (int j = 0; j < y.nroPersona; j++)
				{
					if (this.pers[i, 0] == y.pers[j, 2])
					{
						Console.WriteLine("Estan en l:" + " " + this.pers[i, j]);
					}
				}
			}
		}
	}
}
