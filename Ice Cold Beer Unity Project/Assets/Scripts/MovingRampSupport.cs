using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{
    public float moveSpeed = 1f;
    public string inputAxis;
    private float verticalInput;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();       
    }

    private void Update()
    {
        verticalInput = Input.GetAxis(inputAxis);
    }
    // Use fixed update for physics code, because we need to be 
    // careful about how often we call expensive, hardware intensive,
    // physics stuff.
    private void FixedUpdate()
    {
        if (!GameOver.IsGameOver)
        {
            rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
        }
    }

}
