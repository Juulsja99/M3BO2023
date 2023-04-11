using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 20f;
    private bool OnFloor = false;
    public float gravityScale;
    public float gravScaleUp;
    public float gravScaleDown;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnFloor == true)
        {
            rb.AddForce(Vector3.up * force);
        }

                if (rb.velocity.y > 0) {
            gravityScale = gravScaleUp;
        } else if (rb.velocity.y < 0) {
            gravityScale = gravScaleDown;
        }

    }

    private void FixedUpdate()
    {
        rb.AddForce((gravityScale - 1) * Physics.gravity * rb.mass);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            OnFloor = true;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            OnFloor = false;
        }

    }




}
