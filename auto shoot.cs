using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class autoshoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public GameObject projectilePrefab;
private float timeWhenAllowedNextShoot = 0f;
private float timeBetweenShooting = 0.000000001f;
 
void Update()
{
    checkIfShouldShoot();
}
 
void checkIfShouldShoot()
{
    if (timeWhenAllowedNextShoot <= Time.time)
    {
        
            shoot();
            timeWhenAllowedNextShoot = Time.time + timeBetweenShooting;
        
    }
}
 
void shoot()
{
   Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
   projectilePrefab.transform.position = new Vector3(0, 1, 0);
}
}