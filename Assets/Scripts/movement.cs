using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigid;
    public float speed;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        bool fkey = Input.GetKey(KeyCode.F);
        Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);

        rigid.AddForce(move * speed);
       
        if (fkey)
        {
            print("Respect");
        }
    }
}
