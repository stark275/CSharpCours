using POO_AbsatractClass_Interface.Jeu;
using POO_AbsatractClass_Interface.Jeu.Modes;
using ui.Jeu.Messages;
using Msg = ui.Jeu.Messages.Message;



namespace ui
{
    public partial class Form1 : Form
    {

        private Jeux jeu;
        private IMessage messages;
        public Form1()
        {
            InitializeComponent();

            IModeDeJeu modeHumain = new ModeHumain();
            // Créer un jeu avec des joueurs bot
            IModeDeJeu modeBot = new ModeBot();
            messages = new Msg();
            jeu = new Jeux(1, modeHumain, messages);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlay_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue dans le jeu de plus ou moins multijoueur ! Devinez le nombre entre 1 et 100.");

        }

        private void PlayerInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            PlayerInput.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    jeu.Jouer(PlayerInput);
                }

            };

            messageLabel.Text = messages.Contenu;

        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
