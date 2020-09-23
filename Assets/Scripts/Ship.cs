using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : GameEntity
{
    public float speed = 5;
    public GameObject shot;
    public Transform cannon; 

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

        if (Input.GetKeyUp(KeyCode.Space)) Shot();
       
    }
    

    void Shot()
    {
        GameObject obj = Instantiate(
            shot, cannon.position, cannon.rotation);

        obj.TryGetComponent(out Rigidbody2D rb);
        rb.AddForce(Vector3.up * 5, ForceMode2D.Impulse);     //obj tiro, pego o rigdbody e aplicou uma força pra cima 
        Destroy(obj, 3);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
        {
         if (!collision.GetComponent<Enemy>()) return;
         base.OnTriggerEnter2D(collision);
         }

}
