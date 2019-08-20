using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraNoRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    //lateupdate r bedre til camera  "læs mere --> monobehaviour.lateupdate"
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
