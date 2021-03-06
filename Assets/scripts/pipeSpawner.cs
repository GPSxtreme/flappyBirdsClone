using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public static pipeSpawner instance;
    public float maxTime = 1f;
    private float timer;
    public GameObject pipe;
    public GameObject goldenPipe;
    private GameObject newPipe;
    public float height;
    void Awake(){
        instance = this;
    }
    void Start()
    {
        pipeInstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime){
            pipeInstantiate();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    private void pipeInstantiate(){
        var randNO = Random.Range(0,4);
        if(randNO == 2)
        newPipe = Instantiate(goldenPipe);
        else 
        newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
        Destroy(newPipe , 5);
    }
}
