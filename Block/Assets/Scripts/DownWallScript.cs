using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownWallScript : MonoBehaviour
{
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            PlayerController.ballExistFlag = false;
        }
    }
}
