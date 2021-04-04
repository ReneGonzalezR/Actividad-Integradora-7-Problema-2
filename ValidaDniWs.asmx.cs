using System.Web.Services;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>

namespace Actividad_Integradora_7_Problema_2
{
    /// <summary>
    /// Descripción breve de ValidaDniWs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ValidaDniWs : System.Web.Services.WebService
    {

        [WebMethod]
        public bool ValidaDNI(string valor)
        {
            bool continuar = true;
            if (valor.Length == 9)
            {
                for (int i = 0; i < valor.Length-1; i++)
                {
                    //A=65 Z=90 and a=97 z=122
                    if (!char.IsDigit(valor[i]))
                    {
                        continuar = false;
                    }
                }
                if ((int)valor[valor.Length - 1] < 65 || ((int)valor[valor.Length - 1] > 90
                        && (int)valor[valor.Length - 1] < 97) || (int)valor[valor.Length - 1] > 122)
                {
                    continuar = false;
                }
            }
            else
            {
                continuar = false;
            }
            return continuar;
        }
    }
}
