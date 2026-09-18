using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score { get; private set; }
    public int Xp { get; private set; }
    public int Coins { get; private set; }

    System.Random _rand = new System.Random();
    
    public void AddScore()
    {
        Score += 100;
        Debug.Log($"Score: {Score}");
    }

    public void AddXp()
    {
        Xp += _rand.Next(1, 40);
        Debug.Log($"XP: {Xp}");
    }

    public void AddCoins()
    {
        Coins += _rand.Next(1, 10);
        Debug.Log($"Coins: {Coins}");
    }   
}
