using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    public Text ScoreText;
    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        ScoreText.text = playerScore.ToString();
    }
}
