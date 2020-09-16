using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

    public AudioSource[] water = new AudioSource[4];
    int rand;

private void OnTriggerEnter(Collider other)
    {
        water = gameObject.GetComponents<AudioSource>();

        if (other.tag.Equals("Player"))
        {
            rand = Random.Range(0, water.Length - 1);

            water[rand].Play();
        }
    }
}
