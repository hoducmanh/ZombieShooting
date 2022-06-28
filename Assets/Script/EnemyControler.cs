using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyControler : MonoBehaviour
{
    private Rigidbody myRb;
    public float speed;
    public int maxHealth;
    private int curHealth;
    public PlayerControler Player;

    void Start()
    {
        curHealth = maxHealth;
        myRb = GetComponent<Rigidbody>();
        Player = FindObjectOfType<PlayerControler>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform.position);
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void EnemyHurt(int damage)
    {
        curHealth -= damage;
    }

    void FixedUpdate()
    {
        myRb.velocity = (transform.forward * speed);
    }
}
