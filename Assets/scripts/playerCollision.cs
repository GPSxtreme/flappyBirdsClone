using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{   
    public static playerCollision instance;
    public ParticleSystem deathFx;
    public bool shouldWork;
    void Awake(){
        instance = this;
        shouldWork = true;
    }
    private void OnTriggerEnter2D(Collider2D other){
       if((other.gameObject.tag == "pipe"||other.gameObject.tag == "land" )&& shouldWork){
           Instantiate(deathFx , transform.position,transform.rotation);
            audioManager.instance.playSfx(1);
           gameManager.instance.deathScreen();
       }
   }
}
