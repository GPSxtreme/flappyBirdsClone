using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public float delay;
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start()
    {
        Time.timeScale = 0;
        uiController.instance.startMenu.SetActive(true);
        uiController.instance.scoreObj.SetActive(false);
        uiController.instance.deathMenu.SetActive(false);
        uiController.instance.settingsMenu.SetActive(false);
        playerController.instance.isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(uiController.instance.startMenu.activeInHierarchy == true)
        playerController.instance.isOnMainScreen = true;
        else
        playerController.instance.isOnMainScreen = false;
    }
    public void deathScreen(){
        playerController.instance.theRb.gravityScale = 2;
        playerController.instance.isAlive = false;
        playerController.instance.theRb.freezeRotation = false;
        uiController.instance.scoreObj.SetActive(false);
        StartCoroutine(deathCo());
    }
    private IEnumerator deathCo(){
        yield return new WaitForSeconds(delay);
        uiController.instance.showDeathUi();
    }
    public void start(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
