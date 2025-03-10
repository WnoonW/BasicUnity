using UnityEngine;

public class Player
{
    public string name;
    public int score;
    public Player(string playerName, int playerScore)
    {
        name = playerName;
        score = playerScore;
    }

    public void ShowInfo()
    {
        Debug.Log("Player : " + name + ", Score : " + score);
    }
}

public class ClassExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = new Player("HERO", 10);
        player.ShowInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
