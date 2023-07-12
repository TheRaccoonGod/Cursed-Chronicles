public class Card {
    public int cardID { get; set; }
    public string Name { get; set; }
    public cardType cardType { get; set; }
    public char grade { get; set; }
    public int[] Effects { get; set; }
    public string attribute { get; set; }
    public int[] Modifiers { get; set; }
    public int cost { get; set; }
    public int[] Pos { get; set; } 

    public  void moveUP(int x, int y) {
        Pos[0] = x - 1;
        Pos[1] = y;
    }
}

public enum cardType {
    Monster,
    Effect_Monster,
    Spell,
    Trap
}

public class Monster : Card {
    public int ATK { get; set; }
    public int DEF { get; set; }
    public MonsterType Type { get; set; }
}

public enum MonsterType {
    Undead,
    Warrior,
    Machine,
    Demon,
    Divine,
    Fairy,
    Beast,
    Beast_Warrior,
    Ocean,
    Serpent,
    Insect,
    Plant,
    Dragon
}
