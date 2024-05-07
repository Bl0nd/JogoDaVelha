using Microsoft.VisualBasic;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //variaveis
            int jogadorDaVez; //1=X 2=O
            string jogador1;
            string jogador2;

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
    }
}
