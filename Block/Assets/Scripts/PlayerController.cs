using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject ballPosition;

    static public bool ballExistFlag = false;

    //f つけないとダブル型　↓
    float accel = 1000.0f;
    Rigidbody rb;

    void Start()
    {
        ballExistFlag = false;
        rb = this.GetComponent<Rigidbody>();
    }

        void Update()
    {
        //addforseとは物体に力を加える
        rb.AddForce(transform.right * Input.GetAxis("Horizontal") * accel, ForceMode.Impulse);
        if (Input.GetKeyDown("space"))
        {
            if (!ballExistFlag)
            {
                Instantiate(ball,
                 ballPosition.transform.position,
                 ballPosition.transform.rotation);
                ballExistFlag = true;
            }
            
        }
    }
}
