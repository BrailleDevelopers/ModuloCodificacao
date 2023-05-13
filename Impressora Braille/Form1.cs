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

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Tirar todos caracteres vazios do início e final .TrimStart() .TrimEnd()

            String frase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int numCharFraseInicial = frase.Length;

            String fraseFinal = "";
            int indexInicial = 0;

            String caracter = frase[0].ToString();

            //Função para calcular numero de linhas
            //20 caracteres por linha

            if(frase.Length > 20)
            {
                while (frase.Length > 20)
                {
                    String primeiraParteFrase = frase.Substring(0, 20);
                    frase = frase.Substring(20);

                    //lógica com primeira parte da frase

                    //Ao finalizar, se a nova frase ainda tiver mais que 20 caracteres, ele executa de novo 
                }
                if(frase.Length <= 20)
                {
                    //Lógica pela ultima vez com a ultima frase

                    //Aqui não usa 5
                }
            }
            else
            {
                //lógica com a frase toda

                //Aqui não usa 5

            }

            //Executar código com base na frase gerada, e então reexecutar do 0

            

            button1.Text = fraseFinal;

        }

        string gerarLinha(String frase, int linha, int numChar)
        {
            String linhaFinal = "";

            foreach (char character in frase)
            {
                if (character.ToString().ToLower() == "a")
                {
                    if(linha == 1)
                    {
                        linhaFinal += a_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += a_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += a_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "b")
                {
                    if (linha == 1)
                    {
                        linhaFinal += b_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += b_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += b_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "c")
                {
                    if (linha == 1)
                    {
                        linhaFinal += c_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += c_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += c_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "d")
                {
                    if (linha == 1)
                    {
                        linhaFinal += d_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += d_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += d_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "e")
                {
                    if (linha == 1)
                    {
                        linhaFinal += e_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += e_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += e_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "f")
                {
                    if (linha == 1)
                    {
                        linhaFinal += f_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += f_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += f_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "g")
                {
                    if (linha == 1)
                    {
                        linhaFinal += g_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += g_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += g_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "h")
                {
                    if (linha == 1)
                    {
                        linhaFinal += h_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += h_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += h_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "i")
                {
                    if (linha == 1)
                    {
                        linhaFinal += i_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += i_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += i_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "j")
                {
                    if (linha == 1)
                    {
                        linhaFinal += j_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += j_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += j_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "k")
                {
                    if (linha == 1)
                    {
                        linhaFinal += k_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += k_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += k_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "l")
                {
                    if (linha == 1)
                    {
                        linhaFinal += l_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += l_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += l_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "m")
                {
                    if (linha == 1)
                    {
                        linhaFinal += m_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += m_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += m_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "n")
                {
                    if (linha == 1)
                    {
                        linhaFinal += n_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += n_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += n_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "o")
                {
                    if (linha == 1)
                    {
                        linhaFinal += o_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += o_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += o_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "p")
                {
                    if (linha == 1)
                    {
                        linhaFinal += p_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += p_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += p_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "q")
                {
                    if (linha == 1)
                    {
                        linhaFinal += q_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += q_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += q_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "r")
                {
                    if (linha == 1)
                    {
                        linhaFinal += r_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += r_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += r_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "s")
                {
                    if (linha == 1)
                    {
                        linhaFinal += s_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += s_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += s_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "t")
                {
                    if (linha == 1)
                    {
                        linhaFinal += t_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += t_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += t_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "u")
                {
                    if (linha == 1)
                    {
                        linhaFinal += u_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += u_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += u_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "v")
                {
                    if (linha == 1)
                    {
                        linhaFinal += v_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += v_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += v_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "w")
                {
                    if (linha == 1)
                    {
                        linhaFinal += w_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += w_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += w_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "x")
                {
                    if (linha == 1)
                    {
                        linhaFinal += x_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += x_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += x_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "y")
                {
                    if (linha == 1)
                    {
                        linhaFinal += y_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += y_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += y_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == "z")
                {
                    if (linha == 1)
                    {
                        linhaFinal += z_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += z_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += z_char.thirdLine;
                    }
                }
                if (character.ToString().ToLower() == " ")
                {
                    if (linha == 1)
                    {
                        linhaFinal += no_char.firstLine;
                    }
                    else if (linha == 2)
                    {
                        linhaFinal += no_char.secondLine;
                    }
                    else if (linha == 3)
                    {
                        linhaFinal += no_char.thirdLine;
                    }
                }

            }
            return linhaFinal;
        }

        public class no_char
        {
            public static String firstLine = "0";
            public static String secondLine = "0";
            public static String thirdLine = "0";
        }public class a_char
        {
            public static String firstLine = "2";
            public static String secondLine = "0";
            public static String thirdLine = "0";
        }
        public class b_char
        {
            public static String firstLine = "2";
            public static String secondLine = "2";
            public static String thirdLine = "0";
        }
        public class c_char
        {
            public static String firstLine = "3";
            public static String secondLine = "0";
            public static String thirdLine = "0";
        }
        public class d_char
        {
            public static String firstLine = "3";
            public static String secondLine = "1";
            public static String thirdLine = "0";
        }
        public class e_char
        {
            public static String firstLine = "2";
            public static String secondLine = "1";
            public static String thirdLine = "0";
        }
        public class f_char
        {
            public static String firstLine = "3";
            public static String secondLine = "2";
            public static String thirdLine = "0";
        }
        public class g_char
        {
            public static String firstLine = "3";
            public static String secondLine = "3";
            public static String thirdLine = "0";
        }
        public class h_char
        {
            public static String firstLine = "2";
            public static String secondLine = "3";
            public static String thirdLine = "0";
        }
        public class i_char
        {
            public static String firstLine = "1";
            public static String secondLine = "2";
            public static String thirdLine = "0";
        }
        public class j_char
        {
            public static String firstLine = "1";
            public static String secondLine = "3";
            public static String thirdLine = "0";
        }
        public class k_char
        {
            public static String firstLine = "2";
            public static String secondLine = "0";
            public static String thirdLine = "2";
        }
        public class l_char
        {
            public static String firstLine = "2";
            public static String secondLine = "2";
            public static String thirdLine = "2";
        }
        public class m_char
        {
            public static String firstLine = "3";
            public static String secondLine = "0";
            public static String thirdLine = "2";
        }
        public class n_char
        {
            public static String firstLine = "3";
            public static String secondLine = "1";
            public static String thirdLine = "2";
        }
        public class o_char
        {
            public static String firstLine = "2";
            public static String secondLine = "1";
            public static String thirdLine = "2";
        }
        public class p_char
        {
            public static String firstLine = "3";
            public static String secondLine = "2";
            public static String thirdLine = "2";
        }
        public class q_char
        {
            public static String firstLine = "3";
            public static String secondLine = "3";
            public static String thirdLine = "2";
        }
        public class r_char
        {
            public static String firstLine = "2";
            public static String secondLine = "3";
            public static String thirdLine = "2";
        }
        public class s_char
        {
            public static String firstLine = "1";
            public static String secondLine = "2";
            public static String thirdLine = "2";
        }
        public class t_char
        {
            public static String firstLine = "1";
            public static String secondLine = "3";
            public static String thirdLine = "2";
        }
        public class u_char
        {
            public static String firstLine = "2";
            public static String secondLine = "0";
            public static String thirdLine = "3";
        }
        public class v_char
        {
            public static String firstLine = "2";
            public static String secondLine = "2";
            public static String thirdLine = "3";
        }
        public class w_char
        {
            public static String firstLine = "1";
            public static String secondLine = "3";
            public static String thirdLine = "1";
        }
        public class x_char
        {
            public static String firstLine = "3";
            public static String secondLine = "0";
            public static String thirdLine = "3";
        }
        public class y_char
        {
            public static String firstLine = "3";
            public static String secondLine = "1";
            public static String thirdLine = "3";
        }
        public class z_char
        {
            public static String firstLine = "2";
            public static String secondLine = "1";
            public static String thirdLine = "3";
        }
    }
}
