using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public static playerController instance;
    public float flapStrength;
    public int currentScore;

    public Rigidbody2D theRb;
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start()
    {
        theRb = GetComponent<Rigidbody2D>();
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            theRb.velocity = new Vector2(0,flapStrength);
        }
    }
}
