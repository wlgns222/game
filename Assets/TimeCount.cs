using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    public float PlayTime = 0;
    public GameObject bronze, silver, gold;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayTime += Time.deltaTime;
        if (PlayTime > 30)
        {
            Vector3 newPosition = Vector3.zero;
            bronze.transform.position = newPosition;
        }

        if ( PlayTime > 35)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
        }
    }
}