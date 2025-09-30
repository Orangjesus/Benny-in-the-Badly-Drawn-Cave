using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using TMPro;

public class ItemPickup : MonoBehaviour
{

    PlayerCombat playerCombat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
 
        void OnTriggerEnter2D(Collider2D other)
        {
            bool hasSword = false;
            other.GetComponent<PlayerCombat>();
            if (other.CompareTag("Player"))
            {
                hasSword = true;
                Destroy(gameObject);
                other.GetComponent<PlayerCombat>();
            }
        }
    
}
