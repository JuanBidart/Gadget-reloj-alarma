﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Net.Security;
using System.Text;
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
            lblhora.Text = "";
            lblmin.Text = ""; 
            lblseg.Text = "";

            

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

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
            Form1 form1 = new Form1();  
            StreamReader reader = new StreamReader("./locacion.txt");
            int Y = int.Parse(reader.ReadLine());
            int X = int.Parse(reader.ReadLine());

            

            
           
            this.Location = new Point(X, Y);
            timer.Start();

           reader.Close();

        }
       
        public void Sonido(bool activacion) {

            SoundPlayer player = new SoundPlayer("C:\\Users\\Juan Diego\\Desktop\\prueba visual\\Alarma\\Alarma.wav");
            if (activacion == true)
            {
                player.PlayLooping();
            }else player.Stop();

           
        }



        private void lblmin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int hora = int.Parse(lblhora.Text);
                int minutos = int.Parse(lblmin.Text);
                if (hora == nudHora.Value)
                {
                    if (minutos == nudMin.Value)
                    {
                        Sonido(true);
                    }
                }
            }
            catch (Exception)
            {
               

                
            }
           
           
                        
        }
        private void btnParar_Click(object sender, EventArgs e)
        {
            Sonido(false);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
         
            int Y = Location.Y;
            int X = Location.X;

            StreamWriter writer = new StreamWriter("./locacion.txt");
            writer.WriteLine(Y);
            writer.WriteLine(X);

            writer.Close();

        }
    }

}