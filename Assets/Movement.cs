using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float jump = 3f;
    public AudioClip Pickmeup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Transform>().position += new Vector3(0, jump, 0);

        if (Input.GetKey(KeyCode.D))
            GetComponent<Transform>().position += new Vector3(speed, 0, 0);

        if (Input.GetKey(KeyCode.A))
            GetComponent<Transform>().position += new Vector3(-speed, 0, 0);

    }
}
