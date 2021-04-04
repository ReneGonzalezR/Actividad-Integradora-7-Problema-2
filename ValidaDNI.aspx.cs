using System;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>

namespace Actividad_Integradora_7_Problema_2
{
    public partial class ValidaDNI : System.Web.UI.Page
    {
        ServiceValidaDNI.ValidaDniWsSoapClient misevicio = new ServiceValidaDNI.ValidaDniWsSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (misevicio.ValidaDNI(txtDNI.Text))
            {
                lblResultado.Text = "DNI es Valido";
            }
            else
            {
                lblResultado.Text = "DNI no es Valido";
            }
        }
    }
}