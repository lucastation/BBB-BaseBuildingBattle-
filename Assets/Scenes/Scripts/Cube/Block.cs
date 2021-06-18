using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Block: MonoBehaviour
{
    public string blockName;
    private int health = 0;

    private void Start()
    {
        blockName = "Block in plm";
        health = 100;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        
        Destroy(gameObject);
        
    }

}
