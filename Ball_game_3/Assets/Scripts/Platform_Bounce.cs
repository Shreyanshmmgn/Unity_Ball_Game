using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
public class Platform_Bounce : MonoBehaviour
{   public Vector3 location;
    // Start is called before the first frame update
    public Ball_Movement movement;
    //  public Text scoreText;
    private int score=0;
    public score scoreScript;
    void OnCollisionEnter2D(Collision2D Cinfo)
    {
        if(Cinfo.collider.tag =="Player"){
           
            if(transform.tag =="powerUp"){
              
                movement.upForce();
                scoreScript.UpdateScore(5);
                // scoreText.text= score.ToString();
            }
            if(transform.tag =="powerDown"){
             
                movement.downForce();
                scoreScript.UpdateScore(5);

            }
            if(transform.tag =="platforms")
            {   
                movement.GiveForce();
            }
            if(transform.tag =="Spikes"){
                Debug.Log("hit_spikes"+score);
                movement.GiveForce();
                scoreScript.UpdateScore(-3);
            }
            Debug.Log("score"+score);
            //keepLoacation();
        }

        
    }

    public Vector3 keepLoacation(){
        location = transform.position;
        location.y+=1f;
        return location;
    }
    public int keepScore(){return score;}
}
