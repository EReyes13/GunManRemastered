using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public static ItemCollect instance;
    public int coins = 1;

    public void Awake()
    {
        instance = this;
        
    }

    public void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        // Fix: Check if the colliding object is the Player using CompareTag
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.Instance.AddScore(10);
        }
    }
}