using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmovement : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        print("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

    public void onClickBtn()
    {
        print("hello world from btn");
        GameObject.Find("Cube").GetComponent<Rigidbody>().AddForce(0, 200, 0);
    }
}
