using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public static playerController instance;
    public float flapStrength;
    public int currentScore;
    public ParticleSystem airFx;
    public Transform airFxPoint;
    public bool isAlive;
    public bool isOnMainScreen;

    public Rigidbody2D theRb;
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start()
    {
        theRb = GetComponent<Rigidbody2D>();
        currentScore = 0;
        theRb.velocity = new Vector2(0,flapStrength);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isAlive && !isOnMainScreen){
            theRb.velocity = new Vector2(0,flapStrength);
            audioManager.instance.playSfx(4);
            audioManager.instance.playSfx(3);
            Instantiate(airFx , airFxPoint.transform.position,transform.rotation);
        }
    }
}
