using System;
using System.Text;

namespace Libreria_de_clases
{
    public class Edificio
    {
        private int[,,] _departamento;

        public Edificio()
        {
            _departamento = new int[0, 0, 0];
        }

        public Edificio(int[,,] departamento)
        {
            _departamento = departamento;
        }

        public int[,,] Departamento { get => _departamento; set => _departamento = value; }

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ObtenerDatosEdificio());
            return sb.ToString();
        }

        private string ObtenerDatosEdificio()
        {
            StringBuilder sb = new StringBuilder();
            int piso = 0;
            int sumOeste = 0;
            int sumEste = 0;
            int sumNorte = 0;
            int sumSur = 0;
            string pos = string.Empty;

            for (int y = 0; y < _departamento.GetLength(0); y++)
            {
                piso++;
                for (int x = 0; x < _departamento.GetLength(1); x++)
                {
                    for (int z = 0; z < _departamento.GetLength(2); z++)
                    {
                        if (x == 0 && z == 1)
                        {
                            sumNorte = sumNorte + _departamento[y, x, z];
                            sumOeste = sumOeste + _departamento[y, x, z];
                        }
                        if (x == 0 && z == 2)
                            sumNorte = sumNorte + _departamento[y, x, z];
                        if (x == 0 && z == 3)
                            sumNorte = sumNorte + _departamento[y, x, z];
                        if (x == 0 && z == 4)
                            sumNorte = sumNorte + _departamento[y, x, z];
                        if (x == 0 && z == 5)
                            sumNorte = sumNorte + _departamento[y, x, z];
                        if (x == 0 && z == 6)
                            sumNorte = sumNorte + _departamento[y, x, z];
                        if (x == 0 && z == 7)
                        {
                            sumNorte = sumNorte + _departamento[y, x, z];
                            sumEste = sumEste + _departamento[y, x, z];
                        }
                        if (x == 0 && z == 8)
                        {
                            sumNorte = sumNorte + _departamento[y, x, z];
                            sb.AppendFormat("Piso {0}, Total ocupantes lado Norte = {1} \n", piso, sumNorte);
                            sumNorte = 0;
                        }

                        if (x == 1 && z == 1)
                        {
                            sumSur = sumSur + _departamento[y, x, z];
                            sumOeste = sumOeste + _departamento[y, x, z];
                        }
                        if (x == 1 && z == 2)
                        {
                            sumSur = sumSur + _departamento[y, x, z];
                            sumOeste = sumOeste + _departamento[y, x, z];
                        }
                        if (x == 1 && z == 3)
                            sumSur = sumSur + _departamento[y, x, z];
                        if (x == 1 && z == 4)
                        {
                            sumSur = sumSur + _departamento[y, x, z];
                            sumEste = sumEste + _departamento[y, x, z];
                        }
                        if (x == 1 && z == 5)
                        {
                            sumSur = sumSur + _departamento[y, x, z];
                            sumEste = sumEste + _departamento[y, x, z];
                        }
                        if (x == 1 && z == 6)
                        {
                            sumSur = sumSur + _departamento[y, x, z];
                            sumEste = sumEste + _departamento[y, x, z];
                        }
                        if (x == 1 && z == 7)
                        {
                            sumSur = sumSur + _departamento[y, x, z];
                            sumEste = sumEste + _departamento[y, x, z];
                        }
                        if (x == 1 && z == 8)
                        {
                            sumSur = sumSur + _departamento[y, x, z];
                            sumEste = sumEste + _departamento[y, x, z];
                        }

                        if (x == 1 && z == 8)
                        {
                            sb.AppendFormat("Piso {0}, Total ocupantes lado Sur = {1} \n", piso, sumSur);
                            sumSur = 0;
                            sb.AppendFormat("Piso {0}, Total ocupantes lado Oeste = {1} \n", piso, sumOeste);
                            sumOeste = 0;
                            sb.AppendFormat("Piso {0}, Total ocupantes lado Este = {1} \n", piso, sumEste);
                            sumEste = 0;
                        }
                    }
                }
                sb.AppendLine("------------------------------------------------");
            }
            return sb.ToString();
        }
    }
}
