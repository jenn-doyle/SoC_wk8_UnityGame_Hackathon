using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
1) add png into game
2) link to anhilator script
3) Add obstacle tag
4) link obstacle script
5) do collider 2d stuff
6) save as prefab
7) give prefab to each spawn pattern
*/
/*
TAGS:
-Obstacle 
-
SCRIPTS: 
- anihilator lifetime = 10
- Obstacle scripts damage = 1, speed = 7 
- collider 2d circle istrigger= true

-is a prefab
    -EVERY SpawnPattern has prefab
*/

public class Obstacle : MonoBehaviour
{
    public int damage = 1;

    public float speed;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //player takes damage
            //need to add public int health * 3; to player script
            //add health to player inspector
            //add player tag to player on inspector
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }


}
