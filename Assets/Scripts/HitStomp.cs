using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStomp : MonoBehaviour
{
    
public float bounce;
public Rigidbody2D body;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy")){
            var slime = other.GetComponent<EnemyController>();
            body.velocity = new Vector2(body.velocity.x, bounce);
            slime.Hit();
            
        }
    }
}
