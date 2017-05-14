using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public GameObject ball;
    public GameObject bronze;
    public GameObject silver;
    public GameObject gold;
    public GameObject untill;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);


    }
}