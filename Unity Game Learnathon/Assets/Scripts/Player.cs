using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 targetPos;
    public float Moveup;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            targetPos = new Vector2(transform.position.x, transform.position.y + Moveup);
            transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Moveup);
            transform.position = targetPos;
        
        }
    }

    // Update is called once per frame

}
