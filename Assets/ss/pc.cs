using UnityEngine;
public class pc : MonoBehaviour
{
    public move movement;
    


    void OnCollisionEnter(Collision Info)
    {
        if (Info.collider.tag=="ob")
        {
            movement.enabled = false;
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
        
    


