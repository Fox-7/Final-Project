using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        // Display number of hearts
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            // Heart icon set for full health
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            // Icon replace when player injured
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            // Set the number of hearts
            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            } 
            else
            {
                hearts[i].enabled = false;

            }
        }
    }
}