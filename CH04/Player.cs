namespace CH4;

public class Player
{
    public string PlayerName { get; }
    public long HighScore { get; }

    public Player(string playerName, long highScore)
    {
        PlayerName = playerName;
        HighScore = highScore;
    }

    public Player UpdateHighScore(long highScore)
    {
        return new Player(PlayerName, highScore);
    }
}
