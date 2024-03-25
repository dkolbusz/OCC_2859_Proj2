using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{   
    [SerializeField]
    private int health = 1;
    
    private SpriteRenderer mySprite;

    private void Awake(){
        mySprite = GetComponent<SpriteRenderer>();
    }

    public void Hit(){
        health--;
        if(health <= 0){
            Kill();
        }
    }
    public void Kill(){
        StartCoroutine(DisableBox(0.01f));
        mySprite.flipY = true;
        
    }

  IEnumerator DisableBox(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        GetComponent<BoxCollider2D> ().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.CompareTag("Deathzone")){
        Destroy(this.gameObject);
    }
    }

}



