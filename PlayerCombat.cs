using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    
    public GameObject Painteater;
    public int damage;
    public float attackRange;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Painteater != null && Painteater.activeInHierarchy)
            {
                float distance = Vector3.Distance(transform.position, Painteater.transform.position);
                if (distance <= attackRange)
                {
                    Destroy(Painteater);
                }
            }
        }
    }
}
