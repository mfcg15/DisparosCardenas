using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject player;
    int life = 0;

    void Start()
    {
        life = player.GetComponent<BulletController>().GetLifesPlayer();
        Debug.Log("Tienes " + life + " vidas");
    }

    void Update()
    {
        
    }
}
