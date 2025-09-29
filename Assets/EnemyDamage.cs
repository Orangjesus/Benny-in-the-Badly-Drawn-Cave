using System;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public HealthScript healthScript;
    private GameObject PaintEater;
    void Start()
    {
        GetComponent<PlayerCombat>();
        GetComponent<PlayerMovement>();

       
    }


    public void TakeDamage()
    {
        
        healthScript.Damage(5);
    }

    //Player taking damage
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            healthScript.Damage(5);
        }
    }

  




}
