using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManger3 : MonoBehaviour
{
    bool gameover = false;
    public float RD = 2;
    public void CL()
    {
        Debug.Log("L1");
    }
    public void EndGame()

    {
        if (gameover == false)
            gameover = true;
        Debug.Log("endgame");
        Invoke("Restart", RD);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
