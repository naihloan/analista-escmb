using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelBelgrano.FormarParejas
{
    //https://docs.microsoft.com/es-es/visualstudio/ide/tutorial-3-create-a-matching-game?view=vs-2019
    public partial class Form1 : Form
    {
        Random random = new Random();
        private int acumIntentosCorrectos = 0;
        private int acumIntentosFallidos = 0;
        private DateTime spanTime;
        //Listado de iconos (fuente) a usar
        List<string> icons = new List<string>() {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"};
        //esta es una referencia para almacenar
        //el primel control del tipo Label
        //que le jugadr ckickea, pero va a estar en
        //null si le jugador todavía no ha clickeado ningún
        //label todavía
        Label firstClicked = null;
        //Es el segundo Label que le jugador a clickeado.
        Label secondClicked = null;


        void AssingIconsToSquares() {
            
            foreach (Control control in tlpPrincipal.Controls) {
                Label iconLabel = control as Label;
                if (iconLabel != null) {
                    //obtengo un número aleatoreo, con el valor máximo
                    //de mi lista de iconos
                    int indiceRandom = random.Next(icons.Count);
                    iconLabel.Text = icons[indiceRandom];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    //remuevo de la lista el ícono que acabo de asignar
                    icons.RemoveAt(indiceRandom);
                }
            }
        }
        /*
         Este método comprueba primero si clickedLabel se convirtió (mediante conversión de tipos) correctamente de un objeto en un control Label. Si no, tiene un valor null (C#) o Nothing (Visual Basic) y no es preciso ejecutar el resto del código del método. Luego, el método comprueba el color del texto de la etiqueta elegida mediante la propiedad ForeColor de la etiqueta. Si el color del texto de la etiqueta es negro, significa que el icono ya se ha elegido y el método ha terminado. (Eso es lo que hace la instrucción return: indica al programa que deje de ejecutar el método). Si no, el icono no se ha elegido, por lo que el programa cambia el color del texto de la etiqueta a negro.
             */
        private void Label_Click(object sender, EventArgs e) {
            
            if (timer1.Enabled == true) {
                return;
            }
                       
            Label clickedLabel = sender as Label;
            if (clickedLabel != null) {
                //Si la etiqueta clickeada es negra,
                //entonces le jugador ha ckickeado un ícono
                //que ya ha sido mostrado--> Ignoro el click
                if (clickedLabel.ForeColor == Color.Black) {
                    return;
                }
                
                /*
                 Si la variable de refencia firsClicked es null,
                 este es el primer icono en el par que le jugador
                 ha clickeado, entonces debemos setear el fisrtClciked apuntando
                 a el label que le jugador ha clickeado y cambiar su color a negro
                 y salir de la función
                 */
                if (firstClicked == null) {
                    firstClicked = clickedLabel;
                    clickedLabel.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                //agregamos un if para acumular si son intentos correctos o no:
                if (firstClicked.Text == secondClicked.Text) //hay coincidencia:
                {
                    acumIntentosCorrectos = acumIntentosCorrectos + 1;
                }
                else {
                    acumIntentosFallidos++; //el operador ++ al final de una variable númerica es equivalente a variable = variable + 1
                }

                RefreshScores();
                CheckForWinner();
               
                //Verifico si los dos labels de referncia tienen el mismo
                //texto, si tienen el mimo texto, reseteo las variables de
                //referencia y de este modo, ya quedan "visibles"
                //los labeles que hicieron match
                if (firstClicked.Text == secondClicked.Text)
                {
                    //Reseteo las variables de referencia
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                
                //Si el player llegó hasta este punto del código,
                //quiere decir que ya escogió las dos figuras, entonces
                //inicio el timer para que le de tiempo a memorizar
                timer1.Start();
            }
        }

        private void RefreshScores()
        {
            lblCorrectos.Text = acumIntentosCorrectos.ToString();
            lblFallidos.Text = acumIntentosFallidos.ToString();
            lblTotal.Text = (acumIntentosFallidos + acumIntentosCorrectos).ToString();
        }

        public Form1(string nombreJugador)
        {
            InitializeComponent();
            AssingIconsToSquares();
            //asignamos el nombre del jugador al lblJugador1:
            lblJugador1.Text = nombreJugador;
            //llamamos al helper para que ajuste el texto al label:
            Helper.FitLabel(lblJugador1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //detengo el contador
            timer1.Stop();

            //ocultar los iconos
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            //reseteo las variables de referencia
            firstClicked = null;
            secondClicked = null;
        }
        /// <summary>
        /// Verifica cada icini parave  si es match,
        /// comparando sus folores de frente contra su color de fondo
        /// (foreground and background)
        /// SI ha ahallad conincidenca en todos los iconesom entos
        /// le juguader ha ganado
        /// </summary>
        private void CheckForWinner()
        {
            //recorremos la lista de todos los controles
            // en el tablelayoutpanel 
            foreach (Control control in tlpPrincipal.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    {
                        return;
                    }
                }
            }
            timerGame.Stop();
            MessageBox.Show("Has ganado!!", "bravoo!!!!");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            grbGrid.Visible = true;
            spanTime = new DateTime(2000, 1, 1, 1, 2, 0);
            timerGame.Start();
            btnStart.Enabled = false;
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            spanTime = spanTime.AddSeconds(-1); //le restamos un segundo
            //y actualizamos el label del timer utilizamos la funcion format: https://docs.microsoft.com/es-es/dotnet/api/system.string.format?view=netcore-3.1
            lblTimer.Text = spanTime.ToString("mm:ss");
            if (spanTime.Minute == 0 && spanTime.Second <= 0) //si ha llegado al fin termino el juego
            {
                lblTimer.Text = "00:00";
                EndGame();
            }
        }

        private void EndGame()
        {
            MessageBox.Show("¡El Juego ha terminado!", "FIN");
            timerGame.Stop();
            foreach (Control control in tlpPrincipal.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)//el ícono está "oculto"
                    {
                        iconLabel.ForeColor = Color.Red; //mostramos el que no coincidió
                    }

                    iconLabel.Click -= Label_Click;//Desvinculamos el evento para que no "reaccione" ante el click
                }
            }
        }
    }
}
