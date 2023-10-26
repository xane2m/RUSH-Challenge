using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnMo : MonoBehaviour
{
    public float moveSpeed;
    public Transform EO;
    public Vector3 initial;
    public Vector3 final;
    public Rigidbody Player;

    private bool moveToFinal = true;

    // Start is called before the first frame update
    void Start()
    {
        EO.position = initial;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveToFinal)
        {
            EO.position = Vector3.Lerp(EO.position, final, Time.deltaTime * moveSpeed);

            if ((EO.position - final).magnitude < 0.1f)
            {
                moveToFinal = false;
            }
        }
        else
        {
            EO.position = Vector3.Lerp(EO.position, initial, Time.deltaTime * moveSpeed);

            if ((EO.position - initial).magnitude < 0.1f)
            {
                moveToFinal = true;
            }
        }
    }
}