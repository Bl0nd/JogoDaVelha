using Microsoft.VisualBasic;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //variaveis
        int jogadorDaVez; //1=X 2=O
        string jogador1;
        string jogador2;
        private void Form1_Load(object sender, EventArgs e)
        {
            //pegando nome dos jogadores
            jogador1 = Interaction.InputBox("Digite o nome do Jogador 1 ");
            jogador2 = Interaction.InputBox("Digite o nome do Jogador 2 ");

            jogadorDaVez = 1;
            lblJogadorInfo.Text = jogador1;

            //iniciar botões vazio
            btnA1.Text = "";
            btnA2.Text = "";
            btnA3.Text = "";
            btnB1.Text = "";
            btnB2.Text = "";
            btnB3.Text = "";
            btnC1.Text = "";
            btnC2.Text = "";
            btnC3.Text = "";
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (btnA1.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnA1.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnA1.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (btnA2.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnA2.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnA2.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (btnA3.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnA3.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnA3.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if (btnB1.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnB1.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnB1.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (btnB2.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnB2.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnB2.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (btnB3.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnB3.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnB3.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (btnC1.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnC1.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnC1.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (btnC2.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnC2.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnC2.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (btnC3.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    btnC3.Text = "X";
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    btnC3.Text = "O";
                    jogadorDaVez = 1;
                    lblJogadorInfo.Text = jogador1;
                }
            }
            else
            {
                MessageBox.Show("Opção já Escolhida !");
            }
        }
    }
}
