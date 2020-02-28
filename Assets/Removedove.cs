using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removedove : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag =="Dove")
       {

            Destroy(GameObject.FindWithTag("Dove"));

       }

        
    }


}
