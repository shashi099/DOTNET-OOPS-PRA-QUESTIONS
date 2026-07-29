using System;
class Solution
{
    static void Main()
    {
        Player[] players = new Player[4];

        for(int i=0; i<4; i++)
        {
           int pId = int.Parse(Console.ReadLine());
           string skill = Console.ReadLine();
           string level = Console.ReadLine();
           int points = int.Parse(Console.ReadLine());

           players[i] = new Player(pId, skill, level, points);
        }

        string skillInput = Console.ReadLine();
        int ans1 = findPointsForGivenSkill(players, skillInput);

        if(ans1 != 0)
        {
            Console.WriteLine(ans1);
        }
        else
        {
            Console.WriteLine("The given Skill is not available");
        }

        string levelInput = Console.ReadLine();
        string skillInput2 = Console.ReadLine();

        Player ans2 = getPlayerBasedOnLevel(players, levelInput, skillInput2);
        if(ans2 != null)
        {
            Console.WriteLine(ans2.PlayerId);
        }
        else
        {
            Console.WriteLine("No player is available with specified level, skill and eligibility points");
        }

    }
 
    static int findPointsForGivenSkill(Player[] players, string skill)
    {
        int totalpoints = 0;
        foreach(Player p in players)
        {
            if(p.Skill.Equals(skill, StringComparison.OrdinalIgnoreCase))
            {
                totalpoints+= p.Points;
            }
        }
        return totalpoints;
    }
    static Player getPlayerBasedOnLevel(Player[] players, string level, string skill)
    {
        foreach(Player p in players)
        {
            if(p.Points >= 20 && p.Skill.Equals(skill, StringComparison.OrdinalIgnoreCase) && p.Level.Equals(level, StringComparison.OrdinalIgnoreCase))
            {
                return p;
            }
        }
        return null;
    }
}


class Player
{
    int playerId;
    string skill;
    string level;
    int points;

    public Player(int playerId, string skill, string level, int points)
    {
        this.playerId = playerId;
        this.skill = skill;
        this.level = level;
        this.points = points;
    }

    public int PlayerId
    {
        get{return playerId;}
        set{ playerId = value;}
    }
    public string Skill
    {
        get{return skill;}
        set{skill = value;}
    }
    public string Level
    {
        get{ return level;}
        set{ level = value;}
    }
    public int Points
    {
        get{return points;}
        set{points = value;}
    }
}