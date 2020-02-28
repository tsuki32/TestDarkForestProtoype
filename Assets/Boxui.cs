using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxui : MonoBehaviour
{
    public GameObject Uibox;

    private void Start()
    {
        Uibox.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

         Uibox.SetActive(true);
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Uibox.SetActive(false);
            Destroy(gameObject);
        }
        
    }
}
