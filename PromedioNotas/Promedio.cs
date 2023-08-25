using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNotas
{
    public class Promedio
    {
        public string nombreEstudiante { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set;}
        public int nota3 { get; set;}   
        public int nota4 { get; set;}

        

        public int NotaMasBaja()
        {

            int notabaja;
            if (nota1<nota2 && nota1<nota3 && nota1 < nota4)
            {
                return notabaja = nota1;
            }
            else if(nota2 < nota1 && nota2 < nota3 && nota2 < nota4)
            {
                return notabaja = nota2;
            }
            else if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4)
            {
                return notabaja = nota3;
            }
            else if (nota4 < nota1 && nota4 < nota2 && nota4 < nota3)
            {
                return notabaja = nota4;
            }

            return 0;
        }

        public double PromedioNotas()
        {
            double promedio = (nota1 + nota2 + nota3 + nota4 - NotaMasBaja()) / 3;
            return promedio;
        }

        public string Condicion()
        {
            if (PromedioNotas() > 90)
            {
                return "Excelente";
            }
            else if(PromedioNotas()>80 && PromedioNotas() <= 90)
            {
                return "Muy bueno";
            }
            else if(PromedioNotas()>70 && PromedioNotas() <= 80)
            {
                return "Bueno";
            }
            else if(PromedioNotas()>60 && PromedioNotas() <= 70)
            {
                return "Regular";
            }
            else if(PromedioNotas()<60)
            {
                return "Reprobado";
            }

            return "";

        }
    }
}
