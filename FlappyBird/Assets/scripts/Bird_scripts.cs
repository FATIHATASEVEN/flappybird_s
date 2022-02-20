using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_scripts : MonoBehaviour
{
    public bool isDead;
    public float velocity;
    public Rigidbody2D rb;
    public GameManager manager;
    public GameObject Deathscreen;
    private AudioSource audi;
  
    
    private void Start()
    {
        Time.timeScale = 1;
        audi = GetComponent<AudioSource>();

      
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
            audi .Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="ScoreArea")
        {
            manager.Updatescore();
           
           
        }
        else if(collision.gameObject.tag=="DamageArea")
        {
            manager.ReduceScore();
            
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            Deathscreen.SetActive(true);

            
            
        }
    }
   
}
