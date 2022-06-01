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
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart(){
        playerController.instance.gameObject.SetActive(false);
        StartCoroutine(deathCo());
    }
    private IEnumerator deathCo(){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
