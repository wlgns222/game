using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject ball;



    void Start()
    {
    }
	void Update () 
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPosition = transform.position;
            newPosition.x += 1.0f * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPosition = transform.position;
            newPosition.x += -1.0f * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
