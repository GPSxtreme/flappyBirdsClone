using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchInputScript : MonoBehaviour
{
    public void jump(){
        playerController.instance.jump(1);
    }
    public void smolJump(){
        playerController.instance.jump(2);
    }
}
