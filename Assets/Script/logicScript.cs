using UnityEngine;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        //permet d'afficher le game objet GameOverScreen qui dans mon hierarchie
        gameOverScreen.SetActive(true);
    }
}
