using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public float maxTime = 1f;
    private float timer;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
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
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
        Destroy(newPipe , 15);
    }
}
