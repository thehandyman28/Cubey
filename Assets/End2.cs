
using UnityEngine;

public class End2 : MonoBehaviour
{
    public GameObject Doneui;
    public GameManger gameManger;
    private void OnCollisionEnter(Collision collisionInfo)
    {

        Debug.Log(collisionInfo.collider.tag);
        
        if (collisionInfo.collider.tag == "Player")
        {
           
            Debug.Log("good job");
            Doneui.SetActive(true);

       

        }
    }

}
