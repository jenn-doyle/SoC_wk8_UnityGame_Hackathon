using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    public Animator camAnim;
    public void CamShake(){
        camAnim.SetTrigger("shake");  //SetTrigger needs to be connected to Obstacle destruction
    }
    // Start is called before the first frame update
}
