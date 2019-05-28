using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{   public gameManager manage;
     void OnCollisionEnter2D(Collision2D Cinfo)
    {
        if (Cinfo.collider.tag == "Player")
        {
            // movement.enabled = false;
            manage.winGame();
        }
    }
 
}
