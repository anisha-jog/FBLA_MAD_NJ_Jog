using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRandomizer : MonoBehaviour {

    public Material[] tiles = new Material[13];

    public void Start()
    {
        this.GetComponent<MeshRenderer>().material = tiles[0];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            this.GetComponent<MeshRenderer>().material = tiles[Random.Range(1, tiles.Length-1)];
            //Debug.Log("tile changed");
        }
    }
}
