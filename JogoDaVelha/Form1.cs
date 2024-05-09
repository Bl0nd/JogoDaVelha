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
            VerificarJogada(btnA1);
        }

        private void VerificarJogada(Button botaoEscolhido)
        {
            if (botaoEscolhido.Text == "")
            {
                if (jogadorDaVez == 1)
                {
                    botaoEscolhido.Text = "X";
                    VerificarGanhador();
                    jogadorDaVez = 2;
                    lblJogadorInfo.Text = jogador2;
                }
                else
                {
                    botaoEscolhido.Text = "O";
                    VerificarGanhador();
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
            VerificarJogada(btnA2);
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            VerificarJogada(btnA3);
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            VerificarJogada(btnB1);
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            VerificarJogada(btnB2);
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            VerificarJogada(btnB3);
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            VerificarJogada(btnC1);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            VerificarJogada(btnC2);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            VerificarJogada(btnC3);
        }

        private void VerificarGanhador()
        {
            bool temosGanhador = false;

            //fileira 1
            if (btnA1.Text != "" && btnA2.Text != "" && btnA3.Text != "" && btnA1.Text == btnA2.Text && btnA2.Text == btnA3.Text)
            {
                temosGanhador = true;
            }
            //fileira 2
            else if(btnB1.Text != "" && btnB2.Text != "" && btnB3.Text != "" && btnB1.Text == btnB2.Text && btnB2.Text == btnB3.Text)
            {
                temosGanhador= true;
            }
            //fileira 3
            else if (btnC1.Text != "" && btnC2.Text != "" && btnC3.Text != "" && btnC1.Text == btnC2.Text && btnC2.Text == btnC3.Text)
            {
                temosGanhador = true;
            }
            //fileira 4
            else if (btnA1.Text != "" && btnB2.Text != "" && btnC3.Text != "" && btnA1.Text == btnB2.Text && btnB2.Text == btnC3.Text)
            {
                temosGanhador = true;
            }
            //fileira 5
            else if (btnA3.Text != "" && btnB2.Text != "" && btnC1.Text != "" && btnA3.Text == btnB2.Text && btnB2.Text == btnC1.Text)
            {
                temosGanhador = true;
            }
            //fileira 6
            else if (btnA1.Text != "" && btnB1.Text != "" && btnC1.Text != "" && btnA1.Text == btnB1.Text && btnB1.Text == btnC1.Text)
            {
                temosGanhador = true;
            }

            else if (btnA2.Text != "" && btnB2.Text != "" && btnC2.Text != "" && btnA2.Text == btnB2.Text && btnB2.Text == btnC2.Text)
            {
                temosGanhador = true;
            }
            //fileira 7
            else if (btnA3.Text != "" && btnB3.Text != "" && btnC3.Text != "" && btnA3.Text == btnB3.Text && btnB3.Text == btnC3.Text)
            {
                temosGanhador = true;
            }

            if (temosGanhador == true)
            {
                MessageBox.Show($"{lblJogadorInfo.Text} GANHOU !!!");

                //desativar os botões
                btnA1.Enabled = false;
                btnA2.Enabled = false;
                btnA3.Enabled = false;
                btnB1.Enabled = false;
                btnB2.Enabled = false;
                btnB3.Enabled = false;
                btnC1.Enabled = false;
                btnC2.Enabled = false;
                btnC3.Enabled = false;
            }
        }
    }
}
