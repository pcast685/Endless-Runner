using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    [SerializeField] float jumpForce = 10;

    Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<RigibBody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
        
    }
}
