﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the
    bool gameHasEnded = false;
    public void EndGame(){
        if(gameHasEnded == false)
        {
        gameHasEnded=true;
         restart();
        }
    }
    public void restart(){
        SceneManager.LoadScene("lvl1");
    }

    public void winGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
