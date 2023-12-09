using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alarma
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();

            //Inicializar vacia la hora minutos y seg 

            lblhora.Text = "";
            lblmin.Text = "";
            lblseg.Text = "";
            pbxAlarma.Visible = false;

            Task tareaTiempo = new Task(() =>
            {
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
               
            });
            tareaTiempo.Start();
            



            // Suscribirse a los eventos MouseDown y MouseMove del formulario
            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            string horas = DateTime.Now.Hour.ToString();
            string minutos = DateTime.Now.Minute.ToString();
            string segundos = DateTime.Now.Second.ToString();

           
            if (segundos.Length < 2)
            {
                lblseg.Text = segundos.Insert(0, "0");
            }
            else lblseg.Text = segundos;

            if (minutos.Length < 2)
            {
                lblmin.Text = minutos.Insert(0, "0");
            }
            else lblmin.Text = minutos;

            if (horas.Length < 2)
            {
                lblhora.Text = horas.Insert(0, "0");
            }
            else lblhora.Text = horas;




        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificar si se hizo clic con el botón izquierdo del mouse
            if (e.Button == MouseButtons.Left)
            {
                // Guardar la posición actual del mouse y establecer la bandera de arrastre en verdadero
                mouseX = e.X;
                mouseY = e.Y;
                isDragging = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Verificar si se está arrastrando el formulario
            if (isDragging)
            {
                // Calcular la nueva posición del formulario en función del desplazamiento del mouse
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);

                // Establecer la nueva posición del formulario
                this.Location = new Point(newX, newY);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            // Establecer la bandera de arrastre en falso cuando se suelta el botón del mouse
            isDragging = false;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                

                //Form1 form1 = new Form1();
                StreamReader reader = new StreamReader("./Recursos/location.txt");
                int Y;
                int X;
                
                if (reader.ReadLine()==null)
                {
                    Y = 0;
                    X = 0;
                }
                else
                {
                    Y = int.Parse(reader.ReadLine());
                    X = int.Parse(reader.ReadLine());
                }
                

                this.Location = new Point(X, Y);

                
                reader.Close();

               

            }
            catch (Exception)
            {
                
            }
            finally { timer.Start(); }

        }

        public void Sonido(bool activacion)
        {


            SoundPlayer player = new SoundPlayer("./Recursos/Alarma.wav");
            if (activacion == true)
            {

                player.Play();
                player.Play();
                player.Play();
                player.Play();

            }
            else player.Stop();


        }
        public void imagenReloj(bool activo)
        {
            if (activo == true)
            {
                pbxAlarma.Visible = true;
                pbxAlarma.ImageLocation = "./Recursos/reloj.png";
            }
            else pbxAlarma.Visible = false;

        }



        private void lblmin_TextChanged(object sender, EventArgs e)
        {

            //Debug.WriteLine(lblhora);
            //Debug.WriteLine(lblmin);
            //Debug.WriteLine(nudHora.Value.ToString());
            //Debug.WriteLine(nudMin.Value.ToString());
            //Evento que compara la hora actul con la puesta en el cuadro para sonar la alarma
            try
            {
                int horalblb = int.Parse(lblhora.Text);
                int minutoslbl = 0;
                if (lblmin.Text == "00")
                {
                    minutoslbl = 0;
                }
                else { minutoslbl = int.Parse(lblmin.Text); }

                int horanud = (int)nudHora.Value;
                int minutosnud = (int)nudMin.Value;



                if (horalblb == horanud)
                {
                    if (minutoslbl == minutosnud)
                    {
                        Sonido(true);
                        imagenReloj(true);

                    }
                    else imagenReloj(false);
                }
            }
            catch (Exception)
            {



            }
        }
        private void btnParar_Click(object sender, EventArgs e)
        {
            Sonido(false);
            imagenReloj(false);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Sonido(false);
            imagenReloj(false);
            timer.Stop();
            this.Close();
        }


        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.ForeColor = Color.SeaGreen;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (double)trackBar1.Value/10;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int Y = this.Location.Y;
                int X = this.Location.X;

                StreamWriter writer = new StreamWriter("./Recursos/location.txt");
                writer.WriteLine(Y);
                writer.WriteLine(X);

                writer.Close();


            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }

}
