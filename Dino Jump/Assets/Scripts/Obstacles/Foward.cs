using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foward : MonoBehaviour
{
    GameObject wall;
    GameMaster gameMaster; 
    Rigidbody2D rb;
    Foward forward;
    void Start()
    {
     rb = gameObject.GetComponent<Rigidbody2D>();
     wall = GameObject.FindGameObjectWithTag("Wall");
     forward = GameObject.FindGameObjectWithTag("obstacle").GetComponent<Foward>();
     gameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();
    }
 
    void Update()
    {
        if( gameMaster.PlayerState() == true)
        {
            rb.velocity = new Vector2(-gameMaster.returnSpeed(), 0f);
            //Debug.Log("Speed : " + gameMaster.returnSpeed());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            gameMaster.Player_Dead();
        }
    }
}
