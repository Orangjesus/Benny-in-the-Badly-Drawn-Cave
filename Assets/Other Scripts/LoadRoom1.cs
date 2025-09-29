using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRoom1 : MonoBehaviour
{
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D Door)
    {
        if (Door.gameObject.CompareTag("Player"))
        {
           
            SceneManager.LoadScene("Room1");
        }
        
    }
}
