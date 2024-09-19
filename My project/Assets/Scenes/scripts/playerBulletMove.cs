using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletMove : MonoBehaviour
{
    Camera cam;
    Vector3 relPos;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().MovePosition(transform.position += transform.right * Time.deltaTime * 5);
        relPos = cam.WorldToViewportPoint(transform.position);
        if(relPos.x > 1 || relPos.x < 0 || relPos.y > 1 || relPos.y < 0) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Tilemap")
        {
            Destroy(gameObject);
        }
    }
}