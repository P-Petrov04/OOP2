using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace WinFormArenaGame
{
    public partial class MainForm : Form
    {
        private bool isHeroATbUsed = true;
        private GameEngine gameEngine = new GameEngine();
        private System.Windows.Forms.Timer healthUpdateTimer;

        public MainForm()
        {
            InitializeComponent();
            InitializeHealthUpdateTimer();
        }

        private void InitializeHealthUpdateTimer() //ChatGPT
        {
            healthUpdateTimer = new System.Windows.Forms.Timer();
            healthUpdateTimer.Interval = 100;
            healthUpdateTimer.Tick += new EventHandler(UpdateHeroHealth);
            healthUpdateTimer.Start();
        }

        private void UpdateHeroHealth(object sender, EventArgs e)
        {
            if (gameEngine.HeroA != null)
            {
                tbHero1Health.Text = (gameEngine.HeroA.Health > 0 ? gameEngine.HeroA.Health : 0).ToString("f2");
            }
            if (gameEngine.HeroB != null)
            {
                tbHero2Health.Text = (gameEngine.HeroB.Health > 0 ? gameEngine.HeroB.Health : 0).ToString("f2");
            }
        }

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker;
            if (isHeroATbUsed)
                tbAttacker = tbHeroA;
            else
                tbAttacker = tbHeroB;

            isHeroATbUsed = !isHeroATbUsed;

            tbAttacker.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;

            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbHeroB.Text = "";
            tbHeroA.Text = "";
            lbWinner.Visible = false;

            gameEngine.NotificationsCallBack = gameNotification;
            gameEngine.HeroA = gameEngine.ChooseHeroForFight();
            gameEngine.HeroB = gameEngine.ChooseHeroForFight();

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;
        }

        private void tbHero1Health_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbHero2Health_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
