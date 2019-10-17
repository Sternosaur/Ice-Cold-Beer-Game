using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampScript : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public string inputAxis;
    private float verticalInput;
    private Rigidbody2D rigidBody;
    //private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.color = Color.green;

        rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis(inputAxis);
        rigidBody.velocity = new Vector2(0, verticalInput * moveSpeed);
    }
}
