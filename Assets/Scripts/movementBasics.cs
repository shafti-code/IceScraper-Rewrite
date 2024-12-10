using UnityEngine;

public class movementBasics : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public groundCheck groundCheck;
    public aproachCheck aproachCheck;
    public float playerMoveSpeed;
    public float jumpHeight;
    public float currentInput;
    public float slowdown;
    public Vector2 fixedSpeed;
    public Vector2 fixedLastSpeed;
    public Vector2 speed;
    public Vector2 lastSpeed;
    public bool jumpKeyPressed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    bool OnGround(){
        if (groundCheck.onGround){
            return true;
        }else if (!groundCheck.onGround){
            return false;
        }
    }
    
    bool BufferJump(){
        if (aproachCheck.aproachingGround){
            return true;
        }else if (!aproachCheck.aproachingGround){
            return false;
        }
    }

    bool JumpHandler(){
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            jumpKeyPressed = true;
        }else {
            jumpKeyPressed = false;
        }
        if (jumpKeyPressed && BufferJump)
        // to do, handle jumping with buffers and shi foo, maybe refactor the helper funcktios
            // rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, jumpHeight);
            //this is the goated jump command that should work once all conditions are met 
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

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, -1 * jumpHeight);
        }

        speed = rb2D.linearVelocity;
        if (lastSpeed != speed)
        {
            lastSpeed = speed;
        }
    }
}
