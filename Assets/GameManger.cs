using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManger : MonoBehaviour
{
   
    bool gameover = false;
    
        
            
        
    
    public void EndGame()
    {
        if (gameover == false)
        {
            gameover = true;
            Debug.Log("ENDGAME");
            Invoke("Restart", 2f);
            
        }
      
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
