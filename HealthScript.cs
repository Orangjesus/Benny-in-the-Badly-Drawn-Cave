using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Image HealthBar;
    public float HealthAmount;
    public GameObject Player;
    public Transform Respawn;
    public Sprite CombatSprite;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Damage(float damage = 5)
    {
        HealthAmount -= damage;
        HealthBar.fillAmount = HealthAmount / 20f;

        if (HealthAmount <= 0)
        {
            Player.transform.position = Respawn.position;
            HealthAmount = 20;
            HealthBar.fillAmount = 1;
        }

        if (Player.GetComponent<SpriteRenderer>().sprite == CombatSprite)
        {
            
            HealthBar.fillAmount = HealthAmount / 20f;
        }

    }

    public void Update()
    {
 
    }


}
