using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    MeshRenderer meshRenderer;
    GameMaster Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("GameMaster").GetComponent<GameMaster>();
        Invisible();
    }

    private void Update()
    {
         if( Player.PlayerState() == false &&(Input.GetKey(KeyCode.KeypadEnter) || Input.GetKey(KeyCode.Space) ||  Input.GetKey(KeyCode.UpArrow)))
         {
              SceneManager.LoadScene(0);
         }   
    }
    public void onclick()
    {
        SceneManager.LoadScene(0);
    }
     public void Invisible()
    {
        gameObject.SetActive(false);
    }
     public  void Visible()
    {
        gameObject.SetActive(true);
    }
}
