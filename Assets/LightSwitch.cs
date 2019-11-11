using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public bool change = false;
    private Color original ;
    void Start()
    {
        light = GetComponent<Light>();
        original = light.color;

    }

    public Light light;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)|| OVRInput.GetDown(OVRInput.Button.Two))

        {
            if (!change)
            {
                light.color = new Color(0, 0, 0);
            }
            else
            {
                light.color = original;

            }

            change = !change;

        }
    }
}
