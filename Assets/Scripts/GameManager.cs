using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public Player bird;
   private int bird_points;
   public TextMeshProUGUI points_text;
   public GameObject game_over;
   public GameObject continue_to_menu;
   public string scene_name;
   public bool waiting_to_click;
    
   public void Awake()
   {
      Play(); 
   }

   public void Update()
   {
      if (waiting_to_click == true && Input.anyKeyDown) //waiting for any input from the user to move to the mainMenu scene, when the game is over
      {
         SceneManager.LoadScene(scene_name);
      }
   }

   public void AddPoint() //Adding 1 point to the total score when the bird fly through the pipes gap
   {
      bird_points++;
      points_text.text = "Points:" + bird_points.ToString();
   }
   
   public void Play() //Init the game's data and objects
   {
      bird_points = 0;
      points_text.text = "Points:" + bird_points.ToString();
      game_over.SetActive(false);
      continue_to_menu.SetActive(false);
      Time.timeScale = 1f;
      bird.enabled = true;
      waiting_to_click = false;
      
      Pipes[] pipes = FindObjectsOfType<Pipes>();
      for (int i = 0; i < pipes.Length; i++)
      {
         Destroy(pipes[i].gameObject);
      }
   }
   
   public void GameOver() //Ending the game after detecting collusion between the bird and obstacle 
   {
      game_over.SetActive(true);
      continue_to_menu.SetActive(true);
      Pause();
      waiting_to_click = true;
   }
   
   public void Pause() //Pause the game
   {
      Time.timeScale = 0f;
      bird.enabled = false;
   }
}
