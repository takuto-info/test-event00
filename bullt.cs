using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullt : MonoBehaviour
{
    public GameObject Cube;


    // Use this for initialization

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(Cube,this.transform.position, Quaternion.identity);
    }
}
