using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public float speed;
    public GameObject topPipe;
    public GameObject bottomPipe;
    public float heightDiff;
    // Start is called before the first frame update
    void Start()
    {
        topPipe.transform.position = new Vector2(topPipe.transform.position.x,Random.Range(topPipe.transform.position.y-heightDiff,topPipe.transform.position.y+heightDiff));
        bottomPipe.transform.position = new Vector2(bottomPipe.transform.position.x,Random.Range(bottomPipe.transform.position.y+heightDiff,bottomPipe.transform.position.y-heightDiff));

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed*Time.deltaTime;
    }
}
