using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnpoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")

            print("I AM ABOUT TO DIE");
          
       collision.transform.position = respawnpoint.transform.position;
        
    }
}
