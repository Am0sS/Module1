using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawn : MonoBehaviour
{

    [SerializeField] public GameObject Spheres;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(Spheres, new Vector3(252, 8, 0), Quaternion.identity);
        }
    }
}
