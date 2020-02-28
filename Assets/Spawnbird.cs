using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnbird : MonoBehaviour
{
    public GameObject prefab;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Instantiate(prefab, transform.position + (transform.right * 1), transform.rotation);
            Debug.Log("HAH KOM OG TOK DEG");
            Destroy(GameObject.FindWithTag("Poop"));
        }
    }

}
