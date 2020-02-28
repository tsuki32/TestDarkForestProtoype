using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabme : MonoBehaviour
{
   public GameObject object1;
    public GameObject object2;
    public bool amitouchingyou;
    public bool triggerentered = false;


   
    void OnTriggerEnter2D(Collider2D other)
    {
        triggerentered = true;

    }

      void Update()
      {

        if (Input.GetKeyDown(KeyCode.W) && triggerentered == true)
        {
            object2.transform.parent = object1.transform; 
            print("yayy");
            amitouchingyou = true;

        }
        else 
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                amitouchingyou = false;
                transform.parent = null;
                print("JEG VIL AV SA JEG");
            }

            

            
           
            
        }

      }

}     
    

