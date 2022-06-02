using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{   
    public static audioManager instance;
    public AudioSource[] soundEffects;

    void Awake(){
        instance = this;
    }
    public void playSfx(int no){
        soundEffects[no].Stop();
        soundEffects[no].Play();
    }
}
