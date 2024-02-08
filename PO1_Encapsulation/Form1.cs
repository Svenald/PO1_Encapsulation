namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new();
        Personnage dragon = new();

        public Form1()
        {
            InitializeComponent();
            joueur.PointsDeVie = 10;
            joueur.PointsDePuissance = 1;

            dragon.PointsDeVie = joueur.PointsDeVie * 3;
            dragon.PointsDePuissance = 3;
        }

        private void ActualiserLaberls()
        {
            lbl_pointsVieJoueur.Text = "PV : " + joueur.PointsDeVie;
            lbl_pointsVieDragon.Text = "PV : " + dragon.PointsDeVie;
            lbl_puissanceAttaqueJoueur.Text = "Pts de Puissance : " + joueur.PointsDePuissance;
            lbl_puissanceAttaqueDragon.Text = "Pts de puissance : " + dragon.PointsDePuissance;
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointsDeVie -= joueur.PointsDePuissance;
            ActualiserLaberls();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            ActualiserLaberls();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            ActualiserLaberls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLaberls();
        }
    }
}