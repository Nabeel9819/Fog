using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{

    bool GameHasEnd = false;

    public void EndGame()
    {
        if (GameHasEnd == false)
        {
            GameHasEnd = true;
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
