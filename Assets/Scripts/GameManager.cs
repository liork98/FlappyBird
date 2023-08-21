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
   public string scene_name;
   public void Awake()
   {
      Play();
   }
   public void AddPoint() //Adding 1 point to the total score when the bird fly through the pipes gap
   {
      bird_points++;
      points_text.text = bird_points.ToString();
   }

   public void Play() //Init the game's data and objects
   {
      bird_points = 0;
      points_text.text = bird_points.ToString();
      game_over.SetActive(false);
      Time.timeScale = 1f;
      bird.enabled = true;
      
      Pipes[] pipes = FindObjectsOfType<Pipes>();
      for (int i = 0; i < pipes.Length; i++)
      {
         Destroy(pipes[i].gameObject);
      }
   }
   public void GameOver() //Ending the game after detecting collusion between the bird and obstacle 
   {
      game_over.SetActive(true);
      Pause();
      SceneManager.LoadScene(scene_name);
   }
   public void Pause() //Pause the game
   {
      Time.timeScale = 0f;
      bird.enabled = false;
   }
}