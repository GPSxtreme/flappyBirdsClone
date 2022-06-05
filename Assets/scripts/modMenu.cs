using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class modMenu : MonoBehaviour
{
    private float jumpStrength;
    private float gravityMod;
    private int scoreMod;
    private float pipeSpawnerSpeed;
    private float yDifference;
    public InputField jumpStrengthIF;
    public InputField gravityModIF;
    public InputField scoreModIF;
    public InputField pipeSpawnerSpeedIF;
    public InputField yDifferenceIF;
    public Toggle colliderToggle;

    
    public void onSubmitModSettings(){
        //storing values in local
        if(float.Parse(jumpStrengthIF.text) !=0) jumpStrength = float.Parse(jumpStrengthIF.text);
        if(float.Parse(gravityModIF.text) !=0) gravityMod = float.Parse(gravityModIF.text);
        if(int.Parse(scoreModIF.text) !=0) scoreMod = int.Parse(scoreModIF.text);
        if(float.Parse(pipeSpawnerSpeedIF.text) !=0) pipeSpawnerSpeed = float.Parse(pipeSpawnerSpeedIF.text);
        if(float.Parse(yDifferenceIF.text) !=0) yDifference = float.Parse(yDifferenceIF.text);
        //injection local values
        if(jumpStrength != 0) playerController.instance.flapStrength = jumpStrength;
        if(gravityMod != 0) playerController.instance.theRb.gravityScale = gravityMod;
        if(scoreMod != 0) playerController.instance.currentScore = scoreMod;
        if(pipeSpawnerSpeed != 0) pipeSpawner.instance.maxTime = pipeSpawnerSpeed;
        if(yDifference != 0)pipeSpawner.instance.height = yDifference;
        if(colliderToggle.isOn == true)
        playerCollision.instance.shouldWork = false;
        gameObject.SetActive(false);
    }
}
