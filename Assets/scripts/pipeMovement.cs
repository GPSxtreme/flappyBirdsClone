using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public float speed;
    public GameObject topPipe;
    public GameObject bottomPipe;
    // Start is called before the first frame update
    void Start()
    {
        topPipe.transform.position = new Vector2(topPipe.transform.position.x,Random.Range(topPipe.transform.position.y - 0.08f,topPipe.transform.position.y+0.3f));
        bottomPipe.transform.position = new Vector2(bottomPipe.transform.position.x,Random.Range(bottomPipe.transform.position.y+0.08f,bottomPipe.transform.position.y-0.3f));

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed*Time.deltaTime;
    }
}
