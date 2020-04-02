using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Raycasting : MonoBehaviour
{
    public Text text;
    public Camera camera;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, distance))
        {
            if (hit.collider.gameObject.tag == "Ball")
            {
                text.text = "Press 'E' to Interact";
                if (Input.GetKeyDown("e"))
                {
                    //If you're reading this without actually playing, April Fools, ya goober
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                }
            }
        }
        else
        {
            text.text = "";
        }
    }
}
