using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
    Transform scale;
    GameObject obstacle;
    

    /*
    private void Awake()
    {

         gameObject.transform.localScale = new Vector2(Random.Range(0.5f,2f),gameObject.transform.localScale.y);
    }
    */
    public void smallSize()
    {
         gameObject.transform.localScale = new Vector2(Random.Range(0.5f,2f),gameObject.transform.localScale.y);
    
    }

    public void mediumSize()
    {
        gameObject.transform.localScale = new Vector2(Random.Range(0.5f,2f),gameObject.transform.localScale.y);
    }
    public void largeSize()
    {
        gameObject.transform.localScale = new Vector2(Random.Range(0.5f,2f),gameObject.transform.localScale.y);
    }
}
