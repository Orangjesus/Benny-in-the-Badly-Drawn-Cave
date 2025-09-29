using UnityEngine;



    public class PlayerCombat : MonoBehaviour
    {
        public int damage;
        public float attackRange;
    public Sprite[] IdleSprite;
    public Sprite CombatSprite;
    SpriteRenderer SpriteRenderer;

    void Start()
        {
          SpriteRenderer = GetComponent<SpriteRenderer>();
        }

        void Update()
        {
         if (Input.GetKeyDown(KeyCode.F))
         {

            SpriteRenderer.sprite = CombatSprite;

         }
         else if (Input.GetKeyUp(KeyCode.F))
         {
            SpriteRenderer.sprite = IdleSprite[0];
         }
         if (Input.GetKeyDown(KeyCode.F))
            {
                // Find all active Painteater objects in the scene
                GameObject[] painteaters = GameObject.FindGameObjectsWithTag("Enemy");
                GameObject closestPainteater = null;
                float closestDistance = Mathf.Infinity;

                foreach (GameObject pe in painteaters)
                {
                    if (pe.activeInHierarchy)
                    {
                        float distance = Vector3.Distance(transform.position, pe.transform.position);
                        if (distance < closestDistance)
                        {
                            closestDistance = distance;
                            closestPainteater = pe;
                        }
                    }
                }

                // Destroy the closest Painteater if within attack range
                if (closestPainteater != null && closestDistance <= attackRange)
                {
                    Destroy(closestPainteater);
                }
            }
        }
    }

