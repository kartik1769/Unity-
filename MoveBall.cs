using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    Rigidbody rb;
    public int ballspeed = 0;
    public int jumpspeed = 0;
    private bool istouching = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        float Hmove = Input.GetAxis ("Horizontal");
        float Vmove = Input.GetAxis ("Vertical");
        Vector3 ballmove = new Vector3(Hmove,0.0f,Vmove);
        rb.AddForce(ballmove * ballspeed);

        if ((Input.GetKey(KeyCode.Space)) && istouching == true) {
            Vector3 balljump = new Vector3(0.0f,6.0f,0.0f);
            rb.AddForce(balljump * jumpspeed);
        }

        istouching = false;
    }
 
    private void OnCollisionStay()
    {
        istouching = true;
        
    }
} 
   