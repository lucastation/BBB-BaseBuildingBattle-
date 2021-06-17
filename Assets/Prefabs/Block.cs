using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Block: MonoBehaviour
{
    public string blockName;
    private int health = 0;
    public GameObject prefab;

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
        
        Instantiate(prefab, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        Destroy(gameObject);
        
    }

}
