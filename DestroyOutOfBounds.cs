using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float topBound = 30;
    private float lowerBound = -10;
    private float rightBound = 21;
    private float leftBound = -21;
    private float upBound = 30;
    private float downBound = -1;

    void Update()
    {
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound){
            Destroy(gameObject);
        }
        if (transform.position.x > rightBound) {
            Destroy(gameObject);
        } else if (transform.position.x < leftBound){
            Destroy(gameObject);
        }
        if (transform.position.y > upBound) {
            Destroy(gameObject);
        } else if (transform.position.y < downBound){
            Destroy(gameObject);
        }
    }
}
