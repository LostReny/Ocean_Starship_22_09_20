using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntity : MonoBehaviour
{

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = Instantiate
                        (explosion, transform.position, transform.rotation);

        Destroy (obj, .8f);

        Destroy(gameObject);
    }
}
