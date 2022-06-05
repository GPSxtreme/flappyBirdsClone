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
        jumpStrength = float.Parse(jumpStrengthIF.text);
        gravityMod = float.Parse(gravityModIF.text);
        scoreMod = int.Parse(scoreModIF.text);
        pipeSpawnerSpeed = float.Parse(pipeSpawnerSpeedIF.text);
        yDifference = float.Parse(yDifferenceIF.text);
        //injection local values
        if(jumpStrength != 0) playerController.instance.flapStrength = jumpStrength;
        if(gravityMod != 0) playerController.instance.theRb.gravityScale = gravityMod;
        if(scoreMod != 0) playerController.instance.currentScore = scoreMod;
        if(pipeSpawnerSpeed != 0) pipeSpawner.instance.maxTime = pipeSpawnerSpeed;
        if(yDifference != 0) pipeSpawner.instance.height = yDifference;
        if(colliderToggle.isOn == true) playerCollision.instance.shouldWork = false;
    }
    public void close(){
        gameObject.SetActive(false);
    }
}
