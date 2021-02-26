using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    public float speed;
    public float Xend;
    public float length, startpos;
    public GameObject cam;

    void Start()
    { length = GetComponent<SpriteRenderer>().bounds.size.x * 2; }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < Xend)
        {
           transform.position =  new Vector2(transform.position.x + length, transform.position.y);
        
        }
    }
}
