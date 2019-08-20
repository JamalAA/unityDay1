using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform Spawnpoint;
    public Rigidbody Prefab;
    // Start is called before the first frame update
   public void OnTriggerEnter()
    {
        Rigidbody RigidPrefab;
        RigidPrefab = Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation) as Rigidbody;
    }


}
