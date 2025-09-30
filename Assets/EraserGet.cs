using UnityEngine;

public class EraserGet : MonoBehaviour
{
    

    // Reference to the player script
    public PlayerCombat Eraser;

    void Start()
    {
        // Find the player and get its controller script
        Eraser = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCombat>();
        PlayerCombat.Eraser(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {           
             PlayerCombat.Eraser(true);
            Destroy(gameObject);
        }
    }
}
