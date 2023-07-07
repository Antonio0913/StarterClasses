using System;
using System.Diagnostics.Metrics;
using System.Net;
using System.Runtime.InteropServices;

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
    private int cooldownTime;
    private int cooldownProgress = 0;
    private bool available = false;
    private string skillName;
    private string physicalAttack;
    public Skill(int cooldownTime, string skillName, string physicalAttack)
    {
      this.cooldownTime = cooldownTime;
      this.skillName = skillName;
      this.physicalAttack = physicalAttack;
    }
    public void UpdateAvailability()
    {
      available = cooldownTime == cooldownProgress;
    }
    public void UseSkill()
    {
      UpdateAvailability();
      if (available)
      {
        Console.WriteLine("Using " + this.skillName);
        this.cooldownProgress = 0;
      }
      else
      {
        Console.WriteLine(skillName + " is still charging wait another " + (cooldownTime - cooldownProgress) + "secconds to use this skill");
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
    public beginner(string PlayerChosenName)
    {
      this.ProfessionalName = PlayerChosenName;
    }
    private string _professionalName = "enter username";
    public string ProfessionalName
    {
      get => _professionalName;
      set=> _professionalName = value;
    }
    private int _level = 1;
    public int Level
    {
      get => _level; 
      set => _level = value;  
    }
    private string _speciality = "beginner";
    public string Speciality
    {
      get => _speciality;
    }
    private int _hP = 100;
    public int HP
    {
      get => _hP;
      set => _hP = value;
    }
    private int _mP = 50;
    public int MP
    {
      get => _mP;
      set => _mP = value;
    }
    private string _physicalAttack = "punch";
    public string PhysicalAttack
    {
      get => _physicalAttack;
    }
    public void levelUp()
    {
      Level++;
      HP += 5;
      MP += 2;
    }
    Skill[] _skills = new Skill[] { new Skill(60, "beginner fire ball", "fire"), new Skill(100, "beginner's lightning", "force lightning") };
    public Skill[] Skills
    {
      get => _skills;
    }
  }
  class  worrier: IStarter
  {
    public worrier(string PlayerChosenName)
    {
      this.ProfessionalName = PlayerChosenName;
    }
    private string _professionalName = "enter username";
    public string ProfessionalName
    {
      get => _professionalName;
      set => _professionalName = value;
    }
    private int _level = 5;
    public int Level
    {
      get => _level;
      set => _level = value;
    }
    private string _speciality = "worrier";
    public string Speciality
    {
      get => _speciality;
    }
    private int _hP = 140;
    public int HP
    {
      get => _hP;
      set => _hP = value;
    }
    private int _mP = 70;
    public int MP
    {
      get => _mP;
      set => _mP = value;
    }
    private string _physicalAttack = "slash";
    public string PhysicalAttack
    {
      get => _physicalAttack;
    }
    public void levelUp()
    {
      Level++;
      HP += 7;
      MP += 2;
    }
    Skill[] _skills = new Skill[] { new Skill(50, "magic shield", ""), new Skill(100, "enraged", "strengthen normal attacks") };
    public Skill[] Skills
    {
      get => _skills;
    }
  }
  class archer : IStarter
  {
    public archer(string PlayerChosenName)
    {
      this.ProfessionalName = PlayerChosenName;
    }
    private string _professionalName = "enter username";
    public string ProfessionalName
    {
      get => _professionalName;
      set => _professionalName = value;
    }
    private int _level = 5;
    public int Level
    {
      get => _level;
      set => _level = value;
    }
    private string _speciality = "archer";
    public string Speciality
    {
      get => _speciality;
    }
    private int _hP = 100;
    public int HP
    {
      get => _hP;
      set => _hP = value;
    }
    private int _mP = 90;
    public int MP
    {
      get => _mP;
      set => _mP = value;
    }
    private string _physicalAttack = "shoot arrow";
    public string PhysicalAttack
    {
      get => _physicalAttack;
    }
    public void levelUp()
    {
      Level++;
      HP += 7;
      MP += 2;
    }
    Skill[] _skills = new Skill[] { new Skill(70, "rain arrows", "Area of effect damage"), new Skill(110, "big boy", "an especially strong arrow shot") };
    public Skill[] Skills
    {
      get => _skills;
    }
  }
}