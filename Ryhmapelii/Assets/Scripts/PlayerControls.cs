using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour { 
 public float moveSpeed;
public bool isGrounded = false;
public float moveHorizontal;
public float moveVertical;
public Rigidbody2D rb2D;
private Vector3 startPos;





// Start is called before the first frame update
void Start()
{
    rb2D = gameObject.GetComponent<Rigidbody2D>();
    startPos = transform.position;
}

// Update is called once per frame
void Update()
{
    moveHorizontal = Input.GetAxisRaw("Horizontal");
    moveVertical = Input.GetAxisRaw("Vertical");

    Jump();
}

private void FixedUpdate()
{
    if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
    {
        rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
    }
}
void Jump()
{
    if (Input.GetButtonDown("Jump") && isGrounded == true)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 26f, 0f), ForceMode2D.Impulse);
    }
}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Water")
        {
            gameObject.transform.position = startPos;
        }
        if (collision.collider.tag == "Spike")
        {
            gameObject.transform.position = startPos;
        }

        if (collision.collider.tag == "EndObstacle")
        {
            gameObject.transform.position = startPos;
        }

        //if (collision.collider.tag == "Enemy")
        //{
          //  gameObject.transform.position = startPos;
        //}

        else if (collision.collider.tag == "CheckPoint")
        {

            startPos = transform.position;
        }

    }
   
}