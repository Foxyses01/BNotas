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
        Dictionary<string, int> dic = new Dictionary<string, int>();

        public Buscar(string Texto)
        {
            InitializeComponent();
            this.Texto = Texto;
        }

        private 
        void button1_Click(object sender, EventArgs e)
        {
            this.Palabra = this.textBox1.Text;
            Tabla();
        }
        
        void Tabla()
        {
            
            
            for(int i = Palabra.Length - 1; i >= 0; i--)
            {
                if (!dic.ContainsKey(Palabra[i].ToString()))
                {
                    dic.Add(Palabra[i].ToString(), (Palabra.Length - 1) - i);
                }
            }

            dic.Add("Otros", Palabra.Length);

            foreach(var key in dic.Keys)
            {
                Console.WriteLine(key + " -> " + dic[key]);
            }

            Console.WriteLine(dic);
        }

        void Boyer() 
        {
        

        }
    }
}
