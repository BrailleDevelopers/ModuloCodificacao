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
            String frase = "Ola amigo   t";
            int numCharFrase = frase.Length;

            String fraseFinal = "";
            int indexInicial = 0;

            String caracter = frase[0].ToString();

            //Função para calcular numero de linhas


            foreach (char character in frase)
            {
                indexInicial++;
                if (character.ToString().ToLower() == "a")
                {
                    fraseFinal = a_char.firstLine;
                }
                if (character.ToString().ToLower() == "b")
                {
                    fraseFinal = b_char.firstLine;
                }
                if (character.ToString().ToLower() == "c")
                {
                    fraseFinal = c_char.firstLine;
                }
                if (character.ToString().ToLower() == "d")
                {
                    fraseFinal = d_char.firstLine;
                }
                if (character.ToString().ToLower() == "t")
                {
                    fraseFinal = t_char.firstLine;
                }
                if (indexInicial == numCharFrase)
                {
                    break;
                }
            }

            button1.Text = fraseFinal;

        }

        public class a_char
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
