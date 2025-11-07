using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int playerScore = 0;
    public GameObject gameOverScreen;
    public Text score;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore += 1;
        score.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
