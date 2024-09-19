using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.Collections;
using UnityEngine;

public class playermove1 : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 300;
    public int power;
    private float tick = 0;
    public int shooting = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateBullets();

    }

    void UpdateMovement()
    {
        float h = 0;
        float v = 0;

        if (Input.GetKey(KeyCode.W))
        {
            v += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            v -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            h -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            h += 1;
        }

        Vector3 inp = new Vector3(h, v, 0);
        GetComponent<Rigidbody2D>().MovePosition(transform.position + (inp * Time.deltaTime * speed));
    }

    void UpdateBullets()
    {
        tick = Mathf.Min(tick + Time.deltaTime, 2f);

        if(shooting == 0)
        {
            if(tick >= 0.4f && Input.GetKey(KeyCode.F)) 
            {
                tick = 0;
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 0));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 10));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 350));
            }
            if(tick >= 0.4f && Input.GetKey(KeyCode.G)) 
            {
                tick = 0;
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 0));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 45));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 90));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 135));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 180));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 225));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 270));
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 315));
                shooting = 1;
                speed = 50;
            }
        }
        else if (shooting == 1 && tick >= 0.5)
        {
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 15));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 60));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 105));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 150));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 195));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 240));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 285));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 330));
            tick = 0;
            shooting = 2;
        }
        else if (shooting == 2 && tick >= 0.5)
        {
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 30));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 75));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 120));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 165));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 210));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 255));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 300));
            GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 345));
            tick = 0;
            shooting = 0;
            speed = 300;
        }
        
        
    }
}