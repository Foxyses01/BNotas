/*
 * Created by SharpDevelop.
 * User: ULISE
 * Date: 24/10/2019
 * Time: 12:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void GuardarToolStripMenuItemClick(object sender, EventArgs e)//nuevo
		{
			richTextBox1.Text="";
		}
		void GuardarComoToolStripMenuItemClick(object sender, EventArgs e)//abrir
		{
			openFileDialog1.ShowDialog();
			richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
		}
		void GuardarToolStripMenuItem1Click(object sender, EventArgs e)//Guardar
		{
			SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Documento de Texto|*.txt";
            guardar.Title = "Guardar RichTextBox";
            guardar.FileName = "Sin Titulo 1";
            var resultado = guardar.ShowDialog();
            if (resultado==DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object line in richTextBox1.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
		}
		void GuardarComoToolStripMenuItem1Click(object sender, EventArgs e)//Guadar como
		{
			saveFileDialog1.ShowDialog();
			richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
		}

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Buscar = new Buscar(this.richTextBox1.Text);
            Buscar.Show();


        }
    }
}
