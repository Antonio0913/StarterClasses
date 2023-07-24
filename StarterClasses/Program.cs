namespace MyApp 
{
    internal class Starters
    {
        static void Main(string[] args)
        {
        }
    }

    public class Skill
    {
        private int _cooldownTime;
        private int _cooldownProgress = 0;
        private bool _available = false;
        private string _skillName;
        private string _physicalAttack;

        public Skill(int cooldownTime, string skillName, string physicalAttack)
        {
            _cooldownTime = cooldownTime;
            _skillName = skillName;
            _physicalAttack = physicalAttack;
        }

        public void UpdateAvailability()
        {
            _available = _cooldownTime == _cooldownProgress;
        }

        public void UseSkill()
        {
            UpdateAvailability();
            if (_available)
            {
                Console.WriteLine($"Using {_skillName}");
                _cooldownProgress = 0;
            }
            else
            {
                Console.WriteLine($"{_skillName} is still charging wait another {_cooldownTime - _cooldownProgress} secconds to use this skill");
            }
        }
    }

    interface IStarter
    {
        string Speciality { get; }
        int HP { get; set; }
        int MP { get; set; }
        int Level { get; set; }
        void LevelUp();
        String PhysicalAttack { get; }
        String ProfessionalName { get; set; }
        Skill[] Skills { get; }
    }

    class Beginner : IStarter
    {
        public string ProfessionalName { get; set; } = "enter username";
        public string PhysicalAttack { get; private set; } = "punch";
        public string Speciality { get; set; } = "beginner";
        public int Level { get; set; } = 1;
        public int HP { get; set; } = 100;
        public int MP { get; set; } = 50;
        public Skill[] Skills { get; private set; } = new Skill[] { new Skill(60, "beginner fire ball", "fire"), new Skill(100, "beginner's lightning", "force lightning") };
        
        public Beginner(string PlayerChosenName)
        {
            ProfessionalName = PlayerChosenName;
        }

        public void LevelUp()
        {
            Level++;
            HP += 5;
            MP += 2;
        }
    }

    class Worrier : IStarter
    {
        public string ProfessionalName { get; set; } = "enter username";
        public string Speciality { get; set; } = "worrier";
        public string PhysicalAttack { get; private set; } = "slash";
        public int Level { get; set; } = 5;
        public int HP { get; set; } = 140;
        public int MP { get; set; } = 70;
        public Skill[] Skills { get; private set; } = new Skill[] { new Skill(50, "magic shield", ""), new Skill(100, "enraged", "strengthen normal attacks") };
        
        public Worrier(string PlayerChosenName)
        {
            ProfessionalName = PlayerChosenName;
        }

        public void LevelUp()
        {
            Level++;
            HP += 7;
            MP += 2;
        }
    }

    class Archer : IStarter
    {
        public string ProfessionalName { get; set; } = "enter username";
        public string Speciality { get; } = "archer";
        public string PhysicalAttack { get; private set; } = "shoot arrow";
        public int Level { get; set; } = 5;
        public int HP { get; set; } = 100;
        public int MP { get; set; } = 90;
        public Skill[] Skills { get; private set; } = new Skill[] { new Skill(70, "rain arrows", "Area of effect damage"), new Skill(110, "big boy", "an especially strong arrow shot") };
        
        public Archer(string PlayerChosenName)
        {
            ProfessionalName = PlayerChosenName;
        }

        public void LevelUp()
        {
            Level++;
            HP += 7;
            MP += 2;
        }
    }
}