using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject cleaver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Ui();
            Destroy(gameObject);
            Instantiate(cleaver, transform.position, cleaver.transform.rotation);


        }
    }

    void Ui()
    {
        uiObject.SetActive(true);
    }
}
