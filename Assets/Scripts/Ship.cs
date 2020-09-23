using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : GameEntity
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 position = transform.position;
        position.x += x * Time.deltaTime * speed;
        position.y += y * Time.deltaTime * speed;
        transform.position = position;
    }

}
