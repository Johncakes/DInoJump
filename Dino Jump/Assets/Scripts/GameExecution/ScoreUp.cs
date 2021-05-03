using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour
{
 Text scoretxt;
 GameMaster gameMaster;
 float time;
 float score = 0;
 private void Start() 
 {
     scoretxt = GameObject.FindGameObjectWithTag("text").GetComponent<Text>();
     gameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();
 }
 void Update() 
 {
   if(gameMaster.PlayerState() == true)
   {
    time += Time.deltaTime;
    score = Mathf.Round(time*10);
    string stringScore = score.ToString();
    scoretxt.text = stringScore;
   }

 }
 
 
  
}
