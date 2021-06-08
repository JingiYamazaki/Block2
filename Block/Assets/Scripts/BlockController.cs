using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);

    }
}
