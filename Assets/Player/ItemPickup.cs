using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ItemPickup : MonoBehaviour
{

    public PlayerCombat playerCombat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<PlayerCombat>().enabled = false;
        if (SceneManager.GetActiveScene().name == "Room0")
        {
            GetComponent<PlayerCombat>().enabled = false;
        }
    }

    // Update is called once per frame
 
        void OnTriggerEnter2D(Collider2D other)
        {
            
            GetComponent<PlayerCombat>().enabled = false;
            if (other.CompareTag("Player"))
            {
                
                Destroy(gameObject);
                other.GetComponent<PlayerCombat>().enabled = true;
            }
        }
    
}
