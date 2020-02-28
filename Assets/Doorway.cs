using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doorway : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject drop;
    
   

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);

           


        }
        else
        {
            uiObject.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        uiObject.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(drop, transform.position, drop.transform.rotation);
            Destroy(this.gameObject);
            print("HAHAHAHA");
        }

    }

}
