using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notes : MonoBehaviour
{
    public GameObject cleaver;
  //  public static int note;
  //  public GameObject thescore2;

    private void Start()
    {
       // thescore2.GetComponent<Text>().text = "" + note;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
          //   note += 1;
      //  thescore2.GetComponent<Text>().text = "" + note;

        //   Destroy(this.gameObject);
        print("Haha");
        Destroy();
       // Instantiate(cleaver, transform.position, cleaver.transform.rotation);
    }

    void Destroy()
    {
        Destroy(this.gameObject);
        Instantiate(cleaver, transform.position, cleaver.transform.rotation);

    }

 
  
}
