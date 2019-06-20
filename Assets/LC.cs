using UnityEngine.SceneManagement;
using UnityEngine;

public class LC : MonoBehaviour
{
   public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
