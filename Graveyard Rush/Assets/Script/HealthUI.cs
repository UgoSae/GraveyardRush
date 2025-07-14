using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public PlayerHealth playerHealth;

    void Update()
    {
        int currentHealth = playerHealth.GetCurrentHealth();
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = i < currentHealth ? fullHeart : emptyHeart;
        }
    }
}
