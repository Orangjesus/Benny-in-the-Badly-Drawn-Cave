using UnityEngine;

public class EyedropperScript : MonoBehaviour
{
    public GameObject Player;
    public float triggerDistance = 3.0f;
    public HealthScript healthScript;

    private Vector3 originalPosition;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            Vector2 playerPosition = Player.transform.position;
            Vector2 eyedropperPosition = transform.position;

            float horizontalDistance = Vector2.Distance(
                new Vector2(playerPosition.x, playerPosition.y),
                new Vector2(eyedropperPosition.x, eyedropperPosition.y)
            );

            bool isUnderneath = Mathf.Abs(playerPosition.x - eyedropperPosition.x) < 0.5f &&
                                playerPosition.y < eyedropperPosition.y;

            if (horizontalDistance < triggerDistance && isUnderneath)
            {
                if (rb == null)
                {
                    rb = gameObject.AddComponent<Rigidbody2D>();
                }
                rb.gravityScale = 1.0f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
                rb.gravityScale = 0f;
            }
            transform.position = originalPosition;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            healthScript.Damage(20);
        }
    }
}

