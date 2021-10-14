using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 direction = Vector3.right;
    public int damage = 1;
    static int lifePlayer = 10;
    
    void Start()
    {
       
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x > 24.8f)
        {
            Destroy(gameObject);
            Debug.Log("Jugador herido");
            LessLifes();
        }
    }

    private void LessLifes()
    {
        lifePlayer = lifePlayer - damage;

        Debug.Log("Tienes "+ lifePlayer+ " vidas");

        if (lifePlayer == 0)
        {
            Debug.Log("Fin del juego");
            Debug.Break();
        }
    }

    public int GetLifesPlayer()
    {
        return lifePlayer;
    }

    public void SetLifesPlayer(int newLifePlayer)
    {
        lifePlayer = newLifePlayer;
    }

}
