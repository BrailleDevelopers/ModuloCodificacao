using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Impressora_Braille
{
    public partial class Form1 : Form
    {
        string RxString;
        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
        }

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;

            i = 0;
            quantDiferente = false;

            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            if (quantDiferente == false)
            {
                return;
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBoxReceber.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String frase = textBox1.Text;
                String fraseFinal = "";
                int tamanhoFrase = 0;

                if (!string.IsNullOrEmpty(frase))
                {
                    //Verificação, pra cada caractere maiusculo ou numérico aumenta 1 caracter ou conta menos 1 nos ifs
                    foreach (char character in frase)
                    {
                        if ((char.IsLetter(character) && character == char.ToUpper(character)) || char.IsDigit(character))
                        {
                            tamanhoFrase += 2;
                        }
                        else // The character is not a letter, it's not in uppercase, or it's not a number.
                        {
                            tamanhoFrase += 1;
                        }

                        if (tamanhoFrase >= 20)
                        {
                            break; // Exit the loop if tamanhoFrase reaches 20 or more.
                        }
                    }


                    if (frase.Length > tamanhoFrase)
                    {
                        while (frase.Length > tamanhoFrase)
                        {
                            String primeiraParteFrase = frase.Substring(0, tamanhoFrase);
                            frase = frase.Substring(tamanhoFrase);
                            fraseFinal += gerarFraseCompleta(primeiraParteFrase, false);
                            foreach (char character in frase)
                            {
                                if ((char.IsLetter(character) && character == char.ToUpper(character)) || char.IsDigit(character))
                                {
                                    tamanhoFrase += 2;
                                }
                                else 
                                {
                                    tamanhoFrase += 1;
                                }

                                if (tamanhoFrase >= 20)
                                {
                                    break;
                                }
                            }
                        }
                        if (frase.Length <= tamanhoFrase)
                        {
                            fraseFinal += gerarFraseCompleta(frase, true);
                        }
                    }
                    else
                    {
                        fraseFinal = gerarFraseCompleta(frase, true);
                    }

                    if (serialPort1.IsOpen == true) 
                    {
                        serialPort1.Write(fraseFinal);  //envia o texto
                    }
                    Console.WriteLine(fraseFinal);
                    textBoxReceber.Text = fraseFinal;

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
                {' ', new string[] {"0", "0", "0"}},
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
                {'á', new string[] {"2", "3", "3" }},
                {'é', new string[] {"3", "3", "3" }},
                {'í', new string[] {"1", "0", "2" }},
                {'ó', new string[] {"1", "0", "3" }},
                {'ú', new string[] {"1", "3", "3" }},
                {'à', new string[] {"3", "2", "1" }},
                {'â', new string[] {"2", "0", "1" }},
                {'ê', new string[] {"2", "2", "1" }},
                {'ô', new string[] {"3", "1", "1" }},
                {'ã', new string[] {"1", "1", "2" }},
                {'õ', new string[] {"1", "2", "1" }},
                {'ç', new string[] {"3", "2", "3" }},
                {',', new string[] {"0", "2", "0" }},
                {';', new string[] {"0", "2", "2" }},
                {':', new string[] {"0", "3", "0" }},
                //{':', new string[] {"0", "3", "0" }},
                {'.', new string[] {"0", "0", "2" }},
                {'’', new string[] {"0", "0", "2" }},
                {'?', new string[] {"0", "2", "1" }},
                {'!', new string[] {"0", "3", "2" }},
                {'-', new string[] {"0", "0", "3" }},
                {'∗', new string[] {"0", "1", "2" }},
                {'“', new string[] {"0", "2", "3" }},
                {'”', new string[] {"0", "2", "3" }},
                {'"', new string[] {"0", "2", "3" }},
                //{'"', new string[] {"0", "2", "3" }},
                {'&', new string[] {"3", "2", "3" }},
                {'|', new string[] {"1", "1", "1" }},
                {'$', new string[] {"0", "1", "1" }},
                {'+', new string[] {"0", "3", "2" }},
                //{'x', new string[] {"0", "2", "3" }}, //vezes 
                {'÷', new string[] {"0", "3", "1" }},
                //{':', new string[] {"0", "3", "1" }}, //dividido
                //{'/', new string[] {"0", "3", "1" }}, //dividido
                {'=', new string[] {"0", "3", "3" }},
                {'>', new string[] {"2", "1", "2" }},
                {'<', new string[] {"1", "2", "1" }},
                {'°', new string[] {"0", "1", "3" }},
                {'′', new string[] {"2", "3", "1" }},


                //Faltando -> reticencias, parênteses, colchetes, aspas simples ', aspas agulares ou outras variantes,
                //circulo, quadrado, barra, versus ×, setas, hashtag, estrela, cruz, simbolos de genero, copyright, marca registrada,
                //euro, libra, Iene, por cento, por mil, paragrafo, traço de fração, polegada, segundos
                // Sinais - maiuscula, caixa alta, numero, etc
                //http://portal.mec.gov.br/docman/dezembro-2018-pdf/104041-anexo-grafia-braille-para-lingua-portguesa/file
            };

            string linhaFinal = "";

            foreach (char character in frase)
            {
                if (char.IsLetter(character) && character == char.ToUpper(character))
                {
                    if(linha == 1)
                    {
                        linhaFinal += "1";
                    }
                    else if(linha == 2)
                    {
                        linhaFinal += "0";
                    }
                    else if(linha == 3)
                    {
                        linhaFinal += "1";
                    }
                    linhaFinal += caracteres[char.ToLower(character)][linha - 1];
                }
                else if (char.IsDigit(character))
                {
                    if (linha == 1)
                    {
                        linhaFinal += "1";
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += "1";
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += "3";
                    }
                    linhaFinal += caracteres[character][linha - 1];
                }
                else
                {
                    if (caracteres.ContainsKey(character))
                    {
                        linhaFinal += caracteres[character][linha - 1];
                    }
                }
            }

            return linhaFinal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    comboBox1.Enabled = false;
                    button3.Text = "Desconectar";
                    button3.BackColor = Color.FromArgb(190, 87, 87);

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    button3.Text = "Conectar";
                    button3.BackColor = Color.FromArgb(99, 165, 115);
                }
                catch
                {
                    return;
                }

            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();            //fecha a porta
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = Convert.ToString(serialPort1.ReadExisting());              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            textBoxReceber.AppendText(RxString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}