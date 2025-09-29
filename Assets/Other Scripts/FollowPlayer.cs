using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   
    public Transform Player;
    public float CameraSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Newpos = new Vector3(Player.position.x, Player.position.y,-10f);
        transform.position = Vector3.SlerpUnclamped(transform.position, Newpos, CameraSpeed * Time.deltaTime);
    }
}
