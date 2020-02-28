using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayScarynoise : MonoBehaviour
{
    public AudioSource boombitch;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            boombitch.Play();
            Destroy(gameObject, 3);
        }
    }
}
