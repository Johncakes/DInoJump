using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    Restart button;
    public float speed;

    bool player_alive = true;
    
     private void Start()
    {
        button = GameObject.FindGameObjectWithTag("Restart Button").GetComponent<Restart>();
    }

    private void Update() 
    {
        if(player_alive == false)
        {
            button.Visible();
        }

        speed += 0.001f;
        
    }
    public bool PlayerState()
    {
        if (player_alive == true)
        {
            return true;
        }
        else return false; 
    }

    public float returnSpeed()
    {
        return speed;
    }

    public void Player_Dead()
    {
        player_alive = !player_alive;
    }

}
