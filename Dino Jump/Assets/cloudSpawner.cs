using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    GameMaster gameMaster;
    Transform trans;
    public GameObject cloud;
    float rand;
    
    float PrevTime = 0;
    void Start() 
    {
        PrevTime = Time.time;

        gameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();
        trans = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        
        if( (Time.time - PrevTime) > Random.Range(1f, 1.5f) && gameMaster.PlayerState() == true)
        {   
            rand = Random.Range(-0f, 4.1f);
            gameObject.transform.position = new Vector3(transform.position.x, rand, 1.5f);
            Instantiate(cloud, transform.position, Quaternion.Euler(0f,0,0f));
            PrevTime = Time.time;
        }
        
    }
}
