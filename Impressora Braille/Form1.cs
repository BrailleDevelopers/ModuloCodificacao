using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impressora_Braille
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String frase = textBox1.Text;
                String fraseFinal = "";

                if (!string.IsNullOrEmpty(frase))
                {
                    if (frase.Length > 20)
                    {
                        while (frase.Length > 20)
                        {
                            String primeiraParteFrase = frase.Substring(0, 20);
                            frase = frase.Substring(20);
                            fraseFinal += gerarFraseCompleta(primeiraParteFrase, false);
                        }
                        if (frase.Length <= 20)
                        {
                            fraseFinal += gerarFraseCompleta(frase, true);
                        }
                    }
                    else
                    {
                        fraseFinal = gerarFraseCompleta(frase, true);
                    }

                    Console.WriteLine(fraseFinal);

                }
                else
                {
                    MessageBox.Show("É necessário preencher o campo antes de enviar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string gerarFraseCompleta(string fraseInicial, bool soUmaFrase)
        {
            fraseInicial = fraseInicial.Trim();
            String fraseCompleta = "";

            fraseCompleta = gerarLinha(fraseInicial, 1);
            fraseCompleta += "4";
            fraseCompleta += gerarLinha(fraseInicial, 2);
            fraseCompleta += "4";
            fraseCompleta += gerarLinha(fraseInicial, 3);
            if (!soUmaFrase)
            {
                fraseCompleta += "5";
            }

            return fraseCompleta;
        }

        string gerarLinha(string frase, int linha)
        {

            Dictionary<char, string[]> caracteres = new Dictionary<char, string[]>
            {
                {'a', new string[] {"2", "0", "0"}},
                {'b', new string[] {"2", "2", "0"}},
                {'c', new string[] {"3", "0", "0"}},
                {'d', new string[] {"3", "1", "0"}},
                {'e', new string[] {"2", "1", "0"}},
                {'f', new string[] {"3", "2", "0"}},
                {'g', new string[] {"3", "3", "0"}},
                {'h', new string[] {"2", "3", "0" }},
                {'i', new string[] {"1", "2", "0" }},
                {'j', new string[] {"1", "3", "0" }},
                {'k', new string[] {"2", "0", "2" }},
                {'l', new string[] {"2", "2", "2" }},
                {'m', new string[] {"3", "0", "2" }},
                {'n', new string[] {"3", "1", "2" }},
                {'o', new string[] {"2", "1", "2" }},
                {'p', new string[] {"3", "2", "2" }},
                {'q', new string[] {"3", "3", "2" }},
                {'r', new string[] {"2", "3", "2" }},
                {'s', new string[] {"1", "2", "2" }},
                {'t', new string[] {"1", "3", "2" }},
                {'u', new string[] {"2", "0", "3" }},
                {'v', new string[] {"2", "2", "3" }},
                {'w', new string[] {"1", "3", "1" }},
                {'x', new string[] {"3", "0", "3" }},
                {'y', new string[] {"3", "1", "3" }},
                {'z', new string[] {"2", "1", "3" }},
                {' ', new string[] {"0", "0", "0"}}
            };

            string linhaFinal = "";

            foreach (char character in frase.ToLower())
            {
                if (caracteres.ContainsKey(character))
                {
                    linhaFinal += caracteres[character][linha - 1];
                }
            }

            return linhaFinal;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}