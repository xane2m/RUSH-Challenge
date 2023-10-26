using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMovement : MonoBehaviour
{
    public Transform EmptyR;
    public Transform EmptyL;
    public float speed = 10.0f;
    void Start()
    {
        transform.LookAt(EmptyR);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EmptyR")
        {
            transform.LookAt(EmptyL);
        }
        else if (other.gameObject.name == "EmptyL")
        {
            transform.LookAt(EmptyR);
        }
    }
}