using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{   
    public Text scoreText;
    public int gameScore=0;
    
    public void Start(){
        gameScore=0;
    }
    // Update is called once per frame
    public void UpdateScore(int score){
        Debug.Log(score);
        gameScore+=score;
        scoreText.text="SCORE : "+gameScore.ToString();
    }
}
