using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

    [HideInInspector] private float speed = 3F;

    protected Joystick joystick;

    // Use this for initialization
    void Start () {
        joystick = FindObjectOfType<Joystick>();
    }
	
	// Update is called once per frame
	void Update () {

        float translation = joystick.Vertical * speed;
        translation *= Time.deltaTime;

        //Debug.Log(translation + " " + joystick.Vertical + " " + speed);

        transform.Translate(0, 0, translation);
	}
}
