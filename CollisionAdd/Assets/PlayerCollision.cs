
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    //public PlayerMovement movement;
    public GameManager gameManager;

     void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.tag);
        FindObjectOfType<GameManager>().EndGame();
       
    }
   
}
