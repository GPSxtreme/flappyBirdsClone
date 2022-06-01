using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeCollision : MonoBehaviour
{   
    public int points;
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            playerController.instance.currentScore += points;
            uiController.instance.updateScore();
        }
    }
}
