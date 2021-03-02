using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    //on collsion
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the enemy collides with the bottom of the player
        if (collision.gameObject.tag == "Bottom")
        {
            //enemy is destroyed
            Destroy(gameObject);
           
        }
    }
}
