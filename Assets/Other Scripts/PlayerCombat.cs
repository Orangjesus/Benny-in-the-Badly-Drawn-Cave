using UnityEngine;
using System.Collections;
using System;



public class PlayerCombat : MonoBehaviour
{
    public int damage;
    public float attackRange;
    public Sprite[] IdleSprite;
    public Sprite CombatSprite;
    public Sprite EraserSprite;
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
            if (closestPainteater != null && closestDistance <= attackRange)
            {
                closestPainteater.SetActive(false);

                StartCoroutine(RespawnEnemies());

                IEnumerator RespawnEnemies()
                {
                    closestPainteater.SetActive(false);
                    yield return new WaitForSeconds(5);
                    closestPainteater.SetActive(true);
                }
            }
        }

        Eraser();

    }
    
    public void Eraser()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpriteRenderer.sprite = EraserSprite;
            GameObject[] PencilLead = GameObject.FindGameObjectsWithTag("Graphite");
            GameObject closestPencilLead = null;
            float closestDistance = Mathf.Infinity;

            foreach (GameObject pe in PencilLead)
            {
                if (pe.activeInHierarchy)
                {
                    float distance = Vector3.Distance(transform.position, pe.transform.position);
                    if (distance < closestDistance)
                    {
                        closestDistance = distance;
                        closestPencilLead = pe;
                    }
                }
            }
            if (closestPencilLead != null && closestDistance <= attackRange)
            {
                closestPencilLead.SetActive(false);

            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            SpriteRenderer.sprite = IdleSprite[0];
        }
    }

    internal static void Eraser(bool v)
    {
        throw new NotImplementedException();
    }
}

