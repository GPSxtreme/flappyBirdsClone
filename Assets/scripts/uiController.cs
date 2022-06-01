using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiController : MonoBehaviour
{   
    public static uiController instance;
    public GameObject startMenu;
    public Text score;
    public GameObject scoreObj;

    void Awake(){
        instance = this;
    }
    void Start()
    {
        updateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateScore(){
        score.text = playerController.instance.currentScore.ToString();
    }
    public void startGame(){
        startMenu.SetActive(false);
        uiController.instance.scoreObj.SetActive(true);
        Time.timeScale = 1;
    }
}
