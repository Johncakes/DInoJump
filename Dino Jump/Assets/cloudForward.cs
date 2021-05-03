using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudForward : MonoBehaviour
{
    GameObject wall;
    GameMaster gameMaster; 
    Rigidbody2D rb;
    cloudForward forward;

    public float Speed;
    void Start()
    {
     rb = gameObject.GetComponent<Rigidbody2D>();
     wall = GameObject.FindGameObjectWithTag("Wall");
     forward = GameObject.FindGameObjectWithTag("obstacle").GetComponent<cloudForward>();
     gameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();
    }
 
    void Update()
    {
        if(gameMaster.PlayerState() == true)
        {
            rb.velocity = new Vector2(Speed, 0f);
            //Debug.Log("Speed : " + gameMaster.returnSpeed());
        }
        else if (gameMaster.PlayerState() == false)
        {
            rb.velocity = new Vector2(0, 0f);
        }
    }

 private void OnTriggerEnter2D(Collider2D other) {
      if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
 }
}
