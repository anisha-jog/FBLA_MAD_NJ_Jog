using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Submit : MonoBehaviour {

    private bool n1, n2, n3, n4, n5, n6, n7, n8, n9, n10;
    private GameObject[] b;
    public Material green;
    public GameObject welcome;

    private void Start()
    {
        b = GameObject.FindGameObjectsWithTag("answer");
    }

    private void checkGreen(GameObject[] buttons)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<MeshRenderer>().sharedMaterial == green)
            {
                switch (i)
                {
                    case 0:
                        n1 = true;
                        break;
                    case 1:
                        n2 = true;
                        break;
                    case 2:
                        n3 = true;
                        break;
                    case 3:
                        n4 = true;
                        break;
                    case 4:
                        n5 = true;
                        break;
                    case 5:
                        n6 = true;
                        break;
                    case 6:
                        n7 = true;
                        break;
                    case 7:
                        n8 = true;
                        break;
                    case 8:
                        n9 = true;
                        break;
                    case 9:
                        n10 = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        checkGreen(b);

        if (!(other.tag.Equals("Player") && n1 && n2 && n3 && n4 && n5 && n6 && n7 && n8 && n9 && n10))
        {
            Destroy(gameObject.GetComponent<Teleporter>());
            SceneManager.LoadScene("GameOver");
        }
        else
            welcome.SetActive(true);
    }
}
