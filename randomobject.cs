using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomobject : MonoBehaviour {
    [SerializeField]
    GameObject prefab;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Generate", 1, 1);
    }
    public float span = 10f;
    private float currentTime = 0f;
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime > span)
        {
            float x = Random.Range(-5f, 5f);
            float y = 5;
            float z = Random.Range(0f, 250f);
            Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
            currentTime = 0f;
        }
    }
}
