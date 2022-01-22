namespace WinFormsPBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = heroList();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private List<Hero> heroList()
        {
            List<Hero> list = new List<Hero>();
            list.Add(new Hero()
            {
                Id = 1,
                Name = "Jakiro",
                Type = "Intelligent",
                Skills = new string[] { "Dual Breath, Ice Path, Macropyre" }
            });

            list.Add(new Hero()
            {
                Id = 2,
                Name = "Rikimaru",
                Type = "Agility",
                Skills = new string[] { "Smoke Screen, Blink Strike, Sleeping Dart" }
            });
            list.Add(new Hero()
            {
                Id = 3,
                Name = "Rubick",
                Type = "Intelligent",
                Skills = new string[] { "Telekinesis, Fade Bolt, Spell Steal" }
            });
            list.Add(new Hero()
            {
                Id = 4,
                Name = "Sand King",
                Type = "Strength",
                Skills = new string[] { "Burrowstrike, Sand Storm, Epicenter" }
            });
            list.Add(new Hero()
            {
                Id = 5,
                Name = "Gyrocopter",
                Type = "Agility",
                Skills = new string[] { "Rocket Barrage, Homing Missile, Flak Cannonk" }
            });

            list.Add(new Hero()
            {
                Id = 6,
                Name = "Alchemist",
                Type = "Agility",
                Skills = new string[] { "Rocket Barrage, Homing Missile, Flak Cannonk" }
            });
            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells[0].Value);

                Hero selectedHero = getHeroDetail(id);
                if (selectedHero != null)
                {
                    HeroIdValue.Text = selectedHero.Id.ToString();
                    HeroNameValue.Text = selectedHero.Name;
                    HeroTypeValue.Text = selectedHero.Type;

                    string skills = "";
                    foreach (string skill in selectedHero.Skills)
                    {
                        skills = skills + "[" + skill + "] ";
                    }
                    HeroSkillsValue.Text = skills;
                }

            }
        }

        private Hero getHeroDetail(int id)
        {
            var herolist = heroList();

            return herolist.FirstOrDefault(l => l.Id == id);
        }
    }
}