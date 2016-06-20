using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ECCI_Gato
{
    public partial class Juego : System.Web.UI.Page
    {
        private ECCI_GatoService.ECCI_GatoPortClient gato;

        private int clickedByPlayerNo, clickNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            Limpiartablero(false);
        }

        protected void NuevoJuego(object sender, EventArgs e)
        {
            Limpiartablero(true);
            clickNo = 0;
            gato = new ECCI_GatoService.ECCI_GatoPortClient();
        }

        protected void Limpiartablero(bool a)
        {
            Button1.Text = "";
            Button1.Enabled = a;
            Button2.Text = "";
            Button2.Enabled = a;
            Button3.Text = "";
            Button3.Enabled = a;
            Button4.Text = "";
            Button4.Enabled = a;
            Button5.Text = "";
            Button5.Enabled = a;
            Button6.Text = "";
            Button6.Enabled = a;
            Button7.Text = "";
            Button7.Enabled = a;
            Button8.Text = "";
            Button8.Enabled = a;
            Button0.Text = "";
            Button0.Enabled = a;
        }
        protected void btn0_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 0, 0 };
            movida(sender, coordinadas);
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 0, 1 };
            movida(sender, coordinadas);
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 0, 2 };
            movida(sender, coordinadas);
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 1, 0 };
            movida(sender, coordinadas);
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 1, 1 };
            movida(sender, coordinadas);
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 1, 2 };
            movida(sender, coordinadas);
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 2, 0 };
            movida(sender, coordinadas);
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 2, 1 };
            movida(sender, coordinadas);
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            int[] coordinadas = { 2, 2 };
            movida(sender, coordinadas);
        }

        private void movida(object Sender, int[] coordinadas)
        {
            clickNo += 1; //Increase no. of clicks every time a button is clicked


            if ((gato.jugadorActual()) == "X")
                ((Button)Sender).Text = "X";
            else
                ((Button)Sender).Text = "0";
            ((Button)Sender).Enabled = false; //Disable the button once it is clicked
                                              //  string[] arreglo = { coordinadas[0].ToString(), coordinadas[1].ToString(), gato.jugadorActual() };
            string arreglo = coordinadas[0].ToString() + "," + coordinadas[1].ToString() + "," + gato.jugadorActual();
            gato.mover(arreglo);
            revisarGanador();
        }

        private void revisarGanador()
        {
            if (clickNo > 4)
            {

            }
        }

        private void desplegarGanador()
        {
            int x = 0;

            if (x == 0)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Fue Un Empate", "alertMessage();", true);

            }
            if (x == 1)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "El ganador fue: ", "alertMessage();", true);
            }

            if (x == -1)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "El ganador fue: ", "alertMessage();", true);

            }

        }

        protected void guardarGanador(object sender, EventArgs e)
        {


        }

        private void Top10()
        {

        }
    }
}