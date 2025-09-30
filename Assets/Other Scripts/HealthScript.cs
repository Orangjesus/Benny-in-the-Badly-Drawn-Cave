using System; 
using System.Collections; 
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthScript : MonoBehaviour
{
    public Image HealthBar;
    public float HealthAmount;
    public GameObject Player;
    public Transform Respawn;
    public Sprite CombatSprite;
    public GameObject Gameover;
 


    void Start()
    {
        Gameover.SetActive(false);
    }

    IEnumerator RespawnPlayer()
    {
        Player.SetActive(false);
        Gameover.SetActive(true);

        yield return new WaitForSeconds(2);
      
        Player.transform.position = Respawn.position;
        
        HealthAmount = 20;
        HealthBar.fillAmount = 1;
        Player.SetActive(true);
        Gameover.SetActive(false);
    }


    // Update is called once per frame
    public void Damage(float damage = 5)
    {
        HealthAmount -= damage;
        HealthBar.fillAmount = HealthAmount / 20f;

        if (HealthAmount <= 0)
        {
            StartCoroutine(RespawnPlayer());

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
