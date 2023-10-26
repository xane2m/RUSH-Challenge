using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public float gravity = -9.81f;
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float y = velocity.y;
        float z = Input.GetAxis("Vertical") * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        y += gravity * Time.deltaTime;
        velocity = new Vector3(x, y, z);
        transform.position += velocity * Time.deltaTime;
    }
}