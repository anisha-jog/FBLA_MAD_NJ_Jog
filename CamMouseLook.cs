using System.Collections;
using UnityEngine;

public class CamMouseLook : MonoBehaviour {

    Vector2 joyLook, smoothV;
    [HideInInspector] public float sensitivity = 0.1f, smoothing = 2.0f;
    GameObject player;
    
    protected Joystick joystick;

    // Use this for initialization
    void Start () {
        player = this.transform.parent.gameObject;
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update () {
        var md = new Vector2(joystick.Horizontal, joystick.Vertical);

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        joyLook += smoothV;

        player.transform.localRotation = Quaternion.AngleAxis(joyLook.x, player.transform.up);
	}
}