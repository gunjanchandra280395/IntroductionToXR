using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeMeOut : MonoBehaviour
{	
	public CharacterController control;
    // Start is called before the first frame update
    void Start()
    {
        this.control = GetComponent<CharacterController>();
        toggle = false;
    }

    public bool toggle;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || OVRInput.GetDown(OVRInput.Button.One))
        {
            toggle = !toggle;

            if (toggle)
            {
                var pos = transform.position;
               
                
                Debug.Log("Here");
                pos.y -= 1;
                Debug.Log(pos);
                control.enabled = false;
                control.transform.position = new Vector3(0,2,0);
                control.enabled = true;

            }
            else
            {
                Debug.Log("Other here");
                Debug.Log(transform.position);
                control.enabled = false;
                control.transform.position = new Vector3(-20, 2, -20);

            }
        }
    }
}


