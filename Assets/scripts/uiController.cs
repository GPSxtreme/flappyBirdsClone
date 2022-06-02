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
    public GameObject deathMenu;
    public Text highScore;
    public Text scoreCardTxt;
    public GameObject[] medals;

    void Awake(){
        instance = this;
    }
    void Start()
    {
        updateScore();
        for(int i=0;i<3;i++){
             medals[i].SetActive(false);
        }

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
        scoreObj.SetActive(true);
        Time.timeScale = 1;
    }
    public void hideDeathUi(){
        scoreObj.SetActive(true);
        deathMenu.SetActive(false);
        gameManager.instance.start();
    }
    public void showDeathUi(){
        deathMenu.SetActive(true);
        scoreObj.SetActive(false);
        medalRewarder();
        scoreCardTxt.text = playerController.instance.currentScore.ToString();
        if(playerController.instance.currentScore > PlayerPrefs.GetInt("highScore")){
            PlayerPrefs.SetInt("highScore",playerController.instance.currentScore);
        }
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
    }
    public void medalRewarder(){
        int a = playerController.instance.currentScore;
        if(a <= 10)
        medals[0].SetActive(true);
        if(a<=20 && a > 10)
        medals[1].SetActive(true);
        if(a>20)
        medals[2].SetActive(true);
    }
}
