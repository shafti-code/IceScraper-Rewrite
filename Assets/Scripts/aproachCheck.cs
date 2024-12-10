using UnityEngine;

public class aproachCheck : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public bool aproachingGround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        aproachingGround = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        aproachingGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}