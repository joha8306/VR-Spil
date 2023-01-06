using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mennesker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Wall")
        {
            Destroy(gameObject);
        }

        if (collision.collider.tag == "CannonBall")
        {
            Destroy(gameObject);
        }

    }

}
