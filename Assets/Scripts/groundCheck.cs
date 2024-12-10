using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public bool onGround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        onGround = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        onGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
