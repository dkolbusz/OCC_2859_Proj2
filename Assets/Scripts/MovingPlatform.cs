using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    
    [SerializeField]
    private Vector3 finishPosition = Vector3.zero;
    [SerializeField]
    private float speed = 0.5f;

    private Vector3 startPosition;
    private float trackPercent = 0f;
    private int direction = 1;

    

    void Start()
    {
        startPosition = transform.position;
    }

    
    void Update()
    { 
        trackPercent += direction * speed * Time.deltaTime;

        float x = (finishPosition.x - startPosition.x) * trackPercent + startPosition.x;
        float y = (finishPosition.y - startPosition.y) * trackPercent + startPosition.y;
        transform.position = new Vector3(x, y, startPosition.z);

        if((direction == 1 && trackPercent > 0.9f) || (direction == -1 && trackPercent < 0.1f)){
            direction *= -1;
        }
    }
}
