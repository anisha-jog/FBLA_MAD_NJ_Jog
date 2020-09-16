using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        int obj = GameObject.FindGameObjectsWithTag("music").Length;

        Debug.Log(obj);

        if (obj > 1)
        {
            Destroy(gameObject);
            Debug.Log("destroyed");
        }
    }
}
