namespace MyApp // Note: actual namespace depends on the project name.
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
        void levelUp();
        String PhysicalAttack { get; }
        String ProfessionalName { get; set; }
        Skill[] Skills { get; }
    }
    class beginner : IStarter
    {
        public string ProfessionalName { get; set; } = "enter username";
        public int Level { get; set; } = 1;

        public string Speciality { get; set; } = "beginner";
        public int HP { get; set; } = 100;
        public int MP { get; set; } = 50;
        public string PhysicalAttack { get; private set; } = "punch";
        public Skill[] Skills { get; private set; } = new Skill[] { new Skill(60, "beginner fire ball", "fire"), new Skill(100, "beginner's lightning", "force lightning") };
        public beginner(string PlayerChosenName)
        {
            ProfessionalName = PlayerChosenName;
        }
        public void levelUp()
        {
            Level++;
            HP += 5;
            MP += 2;
        }
    }
    class worrier : IStarter
    {
        public string ProfessionalName { get; set; } = "enter username";
        public int Level { get; set; } = 5;

        public string Speciality { get; set; } = "worrier";
        public int HP { get; set; } = 140;
        public int MP { get; set; } = 70;
        public string PhysicalAttack { get; private set; } = "slash";
        public Skill[] Skills { get; private set; } = new Skill[] { new Skill(50, "magic shield", ""), new Skill(100, "enraged", "strengthen normal attacks") };
        public worrier(string PlayerChosenName)
        {
            ProfessionalName = PlayerChosenName;
        }
        public void levelUp()
        {
            Level++;
            HP += 7;
            MP += 2;
        }
    }
    class archer : IStarter
    {
        public string ProfessionalName { get; set; } = "enter username";
        public int Level { get; set; } = 5;

        public string Speciality { get;} = "archer";
        public int HP { get; set; } = 100;
        public int MP { get; set; } = 90;
        public string PhysicalAttack { get; private set; } = "shoot arrow";
        public Skill[] Skills { get; private set; } = new Skill[] { new Skill(70, "rain arrows", "Area of effect damage"), new Skill(110, "big boy", "an especially strong arrow shot") };
        public archer(string PlayerChosenName)
        {
            ProfessionalName = PlayerChosenName;
        }
        public void levelUp()
        {
            Level++;
            HP += 7;
            MP += 2;
        }
    }
}