namespace knightmoves;
public class Awarder
{
    public string CalculateAward(int points)
    {
        if (points > 99)
        {
            return "First Place";
        }
        else if (points > 49)
        {
            return "Second Place";
        }
        else
        {
            return "Participation Award";
        }
    }
}
