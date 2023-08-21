using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 player_direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            player_direction = Vector3.up * strength;
        }
        
        player_direction.y += gravity * Time.deltaTime;
        transform.position += player_direction * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D obj) //This function detects when the bird meets the pipe or the gap between them
    {
        if (obj.gameObject.tag == "Obstacle") //if we detected a collusion with a pipe/ground
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        else if (obj.gameObject.tag == "Scoring") //if we detected a collusion with the pipes gap
        {
            FindObjectOfType<GameManager>().AddPoint();
        }
    }
}
