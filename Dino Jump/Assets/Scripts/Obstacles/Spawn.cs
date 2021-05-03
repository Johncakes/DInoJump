using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject cactus;
    GameMaster gameMaster;
    Size size;
    string[] types = new string[3]{"one","two","three"}; 
    int nextType;
    float prevTime = 0;


    void Start()
    {
        prevTime = Time.time;
        size = cactus.GetComponent<Size>();
        gameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();
    
    }
    
    void Update()
    {
        if( (Time.time - prevTime) > Random.Range(0.8f, 1.3f) && gameMaster.PlayerState() == true)
        {
            nextType = Random.Range(1,4);
            
            switch (nextType)
            {
                case 1 :
                Instantiate(cactus, transform.position, Quaternion.Euler(0f,180f,0f)); //Quaternion.identity);
                prevTime = Time.time;
                size.mediumSize();
                break;

                case 2 :
                Instantiate(cactus, transform.position, Quaternion.Euler(0f,180f,0f)); //Quaternion.identity);
                prevTime = Time.time;
                size.largeSize();
                break;

                default:
                Instantiate(cactus, transform.position, Quaternion.Euler(0f,180f,0f)); //Quaternion.identity);
                prevTime = Time.time;
                size.smallSize();
                break;

            }

        }
            
            
    }

    
}
