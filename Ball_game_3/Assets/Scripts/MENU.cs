using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MENU : MonoBehaviour
{
    // Start is called before the first frame update
    public gameManager manage;
    public void startGame(){
        manage.winGame();
    }
}
