using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PaintEater : MonoBehaviour
{
    
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;
        transform.localScale = scale;

        if (Player.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1;                       
        }
        else
        {
            scale.x = Mathf.Abs(scale.x);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
        }
    }
}
