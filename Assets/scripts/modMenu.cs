using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class modMenu : MonoBehaviour
{
    private string jumpStrength;
    private string gravityMod;
    private string scoreMod;
    private string pipeSpawnerSpeed;
    private string yDifference;
    public InputField jumpStrengthIF;
    public InputField gravityModIF;
    public InputField scoreModIF;
    public InputField pipeSpawnerSpeedIF;
    public InputField yDifferenceIF;
    public Toggle colliderToggle;

    
    public void onSubmitModSettings(){
        //storing values in local
        jumpStrength = jumpStrengthIF.text;
        gravityMod = gravityModIF.text;
        scoreMod = scoreModIF.text;
        pipeSpawnerSpeed = pipeSpawnerSpeedIF.text;
        yDifference = yDifferenceIF.text;
        //injection local values
        playerController.instance.flapStrength = float.Parse(jumpStrength);
        playerController.instance.theRb.gravityScale = float.Parse(gravityMod);
        playerController.instance.currentScore = int.Parse(scoreMod);

        pipeSpawner.instance.maxTime = float.Parse(pipeSpawnerSpeed);
        pipeSpawner.instance.height = float.Parse(yDifference);
        if(colliderToggle.isOn == true)
        playerCollision.instance.shouldWork = false;
        gameObject.SetActive(false);
    }
}
