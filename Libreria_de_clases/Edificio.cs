using System;
using System.Text;

namespace Libreria_de_clases
{
    public class Edificio
    {
		private int [,,] _departamento;  

		public Edificio()
		{
            _departamento = new int[0,0,0];
		}

        public Edificio(int[,,] departamento)
		{
            _departamento = departamento;
		}

        public int[,,] Departamento { get => _departamento; set => _departamento = value; }

		public string ObtenerDatos()
		{
			StringBuilder sb = new StringBuilder();
            sb.AppendLine(ObtenerModeloEdificio());
            sb.AppendLine(ObtenerDatosEdificio());
			return sb.ToString();
		}

        private string ObtenerModeloEdificio()
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            int piso = 1;

            for (int y = 0; y < _departamento.GetLength(0); y++)
            {
                sb.AppendFormat("Piso {0} \n", piso++);
                sb.AppendLine("         -------NORTE--------");
                for (int x = 0; x < _departamento.GetLength(1); x++)
                {
                    count = 0;
                    for (int z = 0; z < _departamento.GetLength(2); z++)
                    {
                        count++;
                        if (count == 1)
                            sb.Append("Oeste  | ");

                        sb.AppendFormat("{0} ", _departamento[y, x, z].ToString());

                        if (count == 9)
                            sb.AppendLine(" |  Este \n");
                    }
                }
                sb.AppendLine("         -------SUR----------");
                sb.AppendLine("------------------------------------------------");
            }

            return sb.ToString();
        }

        private string ObtenerDatosEdificio()
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            int piso = 1;
            int sumOeste = 0;
            int sumEste = 0;
            int sumNorte = 0;
            int sumSur = 0;
            string pos = string.Empty;

            for (int y = 0; y < _departamento.GetLength(0); y++)
            {
                sb.AppendFormat("Piso {0} \n", piso++);
                for (int x = 0; x < _departamento.GetLength(1); x++)
                {
                    count = 0;
                    if (pos.Equals("N"))
                        pos = "S";
                    else
                        pos = "N";

                    for (int z = 0; z < _departamento.GetLength(2); z++)
                    {
                        count++;

                        switch (count)
                        {
                            case 1:
                                sumOeste = sumOeste + _departamento[y, x, z];
                                if (pos.Equals("S"))
                                {
                                    sb.AppendFormat("Total ocupantes lado Oeste: {0} \n", sumOeste);
                                    sumOeste = 0;
                                }
                                break;
                            case 9:
                                sumEste = sumEste + _departamento[y, x, z];
                                if (pos.Equals("S"))
                                {
                                    sb.AppendFormat("Total ocupantes lado Este: {0} \n", sumEste);
                                    sumEste = 0;
                                }
                                break;
                            default:
                                if(pos.Equals("N")){
                                    sumNorte = sumNorte + _departamento[y, x, z];
                                    if (count == 8)
                                    {
                                        sb.AppendFormat("Total ocupantes lado Norte: {0} \n", sumNorte);
                                        sumNorte = 0;
                                    }
                                }else if(pos.Equals("S")){
                                    sumSur = sumSur + _departamento[y, x, z];
                                    if (count == 8)
                                    {
                                        sb.AppendFormat("Total ocupantes lado Sur: {0} \n", sumSur);
                                        sumSur = 0;
                                    }
                                }
                                break;
                        }
                    }
                }
                sb.AppendLine("------------------------------------------------");
            }
            return sb.ToString();
        }
	}
}
