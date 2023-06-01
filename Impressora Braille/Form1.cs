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

                    if (serialPort1.IsOpen == true) 
                    {
                        serialPort1.Write(fraseFinal);  //envia o texto
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