using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gliding : MonoBehaviour
{
    public float speed = 6;
    public float drag = 5;
    public Rigidbody rb;
    private Vector3 rot;
    private float precentage;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rot = transform.eulerAngles;
    }
 
    private void Update()
    {

        rb.drag = drag;

        //Rotation "rot"
        // X Axis
        rot.x += 20 * Input.GetAxis("Vertical") * Time.deltaTime;
        rot.x = Mathf.Clamp(rot.x, 0, 60 );
        // Y Axis
        rot.y += 20 * Input.GetAxis("Horizontal") * Time.deltaTime;
        // Z Axis
        rot.z = -5 * Input.GetAxis("Horizontal");
        rot.z = Mathf.Clamp(rot.z, 0, 60 );
        transform.rotation = Quaternion.Euler(rot);

        precentage = rot.x / 60;
        //Drag: faster
        float mod_drag = (precentage * -2) + drag;
        float mod_speed = precentage*(6f-5f)+ speed;
        rb.drag = mod_drag;
        
        Vector3 localV = transform.InverseTransformDirection(rb.velocity);
        localV.z = mod_speed;
        rb.velocity = transform.TransformDirection(localV);
    }
}