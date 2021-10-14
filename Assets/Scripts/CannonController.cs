using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject [] bulletPrefab;
    
    void Start()
    {
        InvokeRepeating("Shoot", 0.2f, 3.2f);
    }

    void Update()
    {

    }

    void Shoot()
    {
        int randomNumber = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[randomNumber], transform);
    }
}
