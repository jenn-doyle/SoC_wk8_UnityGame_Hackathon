using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;
    public Player player;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            if (player.health > 0)
            {
                score++;
                Debug.Log(score);
            }
        }
    }
}

//before increasing score of 1 make an if statement checking whether the player's health is greater than 0 !
