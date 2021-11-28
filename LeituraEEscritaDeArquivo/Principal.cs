using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraEEscritaDeArquivo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            txtLocalArquivoEntrada.Select();
        }

        OpenFileDialog arquivo = new OpenFileDialog();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            arquivo.Filter = "Arquivo TXT|*.txt";
            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                txtLocalArquivoEntrada.Text = Path.GetFullPath(arquivo.FileName);

                if (txtLocalArquivoEntrada.Text != String.Empty)
                {
                    btnLimparArquivoEntrada.Visible = true;
                    btnBuscarArquivoEntrada.Visible = false;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLocalArquivoEntrada.Text = string.Empty;
            btnBuscarArquivoEntrada.Visible = true;
            btnLimparArquivoEntrada.Visible = false;
        }

        private void btnLocalArquivoSaida_Click(object sender, EventArgs e)
        {
            SaveFileDialog localArquivo = new SaveFileDialog();

            string FileName = "Saída.csv";

            localArquivo.FileName = FileName;
            localArquivo.Filter = "Arquivo CSV|*.csv";

            if (localArquivo.ShowDialog() == DialogResult.OK)
            {
                txtLocalArquivoSaida.Text = localArquivo.FileName;
                btnLocalArquivoSaida.Visible = false;
                btnLimparLocalArquivoSaida.Visible = true;
            }
        }

        private void btnLimparLocalArquivoSaida_Click(object sender, EventArgs e)
        {
            txtLocalArquivoSaida.Text = string.Empty;
            btnLocalArquivoSaida.Visible = true;
            btnLimparLocalArquivoSaida.Visible = false;
        }

        private void btnGerarAquivoSaida_Click(object sender, EventArgs e)
        {
            if (txtLocalArquivoEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione o arquivo de entrada");
                btnBuscarArquivoEntrada.Select();
            }

            else if (txtLocalArquivoSaida.Text == string.Empty)
            {
                MessageBox.Show("Selecione o local para o arquivo de saída");
                btnLocalArquivoSaida.Select();
            }
            else
            {
                GerarArquivoCSV();
            }

        }

        private void GerarArquivoCSV()
        {
            List<string> lista = new List<string>();
            string linha;
            string texto = "";

            using (StreamReader arquivoEntrada = new StreamReader(txtLocalArquivoEntrada.Text))
            {
                linha = arquivoEntrada.ReadLine();


                if (!string.IsNullOrEmpty(linha))
                {
                    for (int i = 0; i < linha.Length; i++)
                    {
                        if (linha[i] != '#')
                        {
                            texto += linha[i].ToString();
                        }

                        if (linha[i] == '#' || i + 1 == linha.Length)
                        {
                            texto += ";" +
                                     ContadorDeLetras(texto).ToString() + ";" +
                                     ContadorDePalavras(texto).ToString() + ";" +
                                     ContadorDeBuracos(texto).ToString();

                            lista.Add(texto);
                            texto = "";
                        }
                    }
                }
                else
                { 
                    MessageBox.Show("Não há texto no arquivo!");
                }
            }

            using (StreamWriter arquivoSaida = new StreamWriter(txtLocalArquivoSaida.Text))
            {

                foreach (var item in lista)
                {
                    arquivoSaida.WriteLine(item);
                }
                MessageBox.Show("Arquivo gerado com sucesso!");
            }
        }

        public static int ContadorDeLetras(string TextoDigitado)
        {
            int Contador = 0;

            for (int i = 0; i < TextoDigitado.Length; i++)
            {
                if (Char.IsLetterOrDigit(TextoDigitado[i]) || Char.IsWhiteSpace(TextoDigitado[i]))
                {
                    Contador++;
                }
            }

            return Contador;
        }
        public static int ContadorDePalavras(string TextoDigitado)
        {
            int Contador = 1;

            for (int i = 0; i < TextoDigitado.Length; i++)
            {
                if (Char.IsWhiteSpace(TextoDigitado[i]))
                {
                    Contador++;
                }
            }

            return Contador;
        }
        public static int ContadorDeBuracos(string TextoDigitado)
        {
            int Contador = 0;

            for (int i = 0; i < TextoDigitado.Length; i++)
            {
                if (
                    TextoDigitado[i] == 'A' ||
                    TextoDigitado[i] == 'D' ||
                    TextoDigitado[i] == 'O' ||
                    TextoDigitado[i] == 'P' ||
                    TextoDigitado[i] == 'Q' ||
                    TextoDigitado[i] == 'R' ||
                    TextoDigitado[i] == 'a' ||
                    TextoDigitado[i] == 'b' ||
                    TextoDigitado[i] == 'd' ||
                    TextoDigitado[i] == 'e' ||
                    TextoDigitado[i] == 'g' ||
                    TextoDigitado[i] == 'o' ||
                    TextoDigitado[i] == 'p' ||
                    TextoDigitado[i] == 'q'

                    )
                    Contador++;
                else if (TextoDigitado[i] == 'B')
                {
                    Contador += 2;
                }
            }

            return Contador;
        }
    }
}
