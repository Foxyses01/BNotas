using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notas
{
    public partial class Buscar : Form
    {
        string Texto;
        string Palabra;
        List<string> Letras;
        List<int> Indices;

        public Buscar(string Texto)
        {
            InitializeComponent();
            this.Texto = Texto;
        }

        private 
            void button1_Click(object sender, EventArgs e)
        {
            this.Palabra = this.textBox1.Text;
        }
        
            void Tabla()
        {
            foreach (var Letra in Palabra)
            {
                if (!Letras.Contains(Letra.ToString()))
                {
                    Letras.Add(Letra.ToString());
                }
            }
            Letras.Add("otros");

            for (int i=0;i<Letras.Count;i++)
            {
                for( int j=Palabra.Length-1;j>=0;j--)
                {
                   
                }

            }
         
        }

            void Boyer() 
        {
        

        }
    }
}
