using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeText : MonoBehaviour {

    public GameObject time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<UnityEngine.UI.Text>().text
    = ((int)time.GetComponent<TimeCount>().PlayTime).ToString();
    }
}
