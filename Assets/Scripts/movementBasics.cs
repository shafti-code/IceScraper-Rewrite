using UnityEngine;

public class movementBasics : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float playerMoveSpeed;
    public float jumpHeight;
    public float currentInput;
    public float slowdown;
    public Vector2 fixedSpeed;
    public Vector2 fixedLastSpeed;
    public Vector2 speed;
    public Vector2 lastSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate(){
        if (currentInput == 0)
        {
            rb2D.linearVelocity = new Vector2(fixedLastSpeed[0] * slowdown, rb2D.linearVelocity.y);
        }
        fixedSpeed = rb2D.linearVelocity;
        if (fixedLastSpeed != fixedSpeed)
        {
            fixedLastSpeed = fixedSpeed;
        }
    }
    // Update is called once per frame
    void Update()
    {
        currentInput = Input.GetAxisRaw("Horizontal");


        if (currentInput != 0)
        {
            rb2D.linearVelocity = new Vector2(currentInput * playerMoveSpeed, rb2D.linearVelocity.y);
        }

        // rb2D.linearVelocity = new Vector2 (currentInput * playerMoveSpeed * 0.99f,rb2D.linearVelocity.y );

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("the jump input true");
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("the jump input true");
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, -1 * jumpHeight);
        }

        speed = rb2D.linearVelocity;
        if (lastSpeed != speed)
        {
            lastSpeed = speed;
        }
    }
}
