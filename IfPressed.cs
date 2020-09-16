using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPressed : MonoBehaviour {

    public Material green, blue;
    public GameObject button2, button3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            this.GetComponent<MeshRenderer>().material = green;
            button2.GetComponent<MeshRenderer>().material = blue;

            try
            {
                button3.GetComponent<MeshRenderer>().material = blue;
            } catch (UnassignedReferenceException)
            {
                Debug.Log("Only Two Buttons.");
            }
        }
    }
}
