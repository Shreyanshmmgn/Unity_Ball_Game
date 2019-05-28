using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigSpikes : MonoBehaviour
{
    // Start is called before the first frame update
     public Ball_Movement movement;
     public gameManager manage;
    void OnCollisionEnter2D(Collision2D Cinfo)
    {
        if (Cinfo.collider.tag == "Player")
        {
            // movement.enabled = false;
            manage.EndGame();
        }
    }

    // void OnTriggerEnter(){
    //     manage.EndGame();
    // }
}
