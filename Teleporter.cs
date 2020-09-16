using System.Collections;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public Transform Destination;
    public GameObject welcome;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            other.transform.position = Destination.transform.position;

            if (gameObject.tag.Equals("tp"))
                welcome.SetActive(true);
        }
    }
}
