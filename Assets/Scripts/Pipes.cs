using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
   public float speed = 5f;
   private float left_edge;
   private void Start()
   {
       left_edge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f; //set the left edge of the screen
   }
   private void Update()
   {
	   transform.position += Vector3.left * (speed * Time.deltaTime);

	   if (transform.position.x < left_edge) //when pipes pass the screen on it's left edge - we destroy the duplication that dissapeared.
	   {
		   Destroy(gameObject);
	   }
   }
}
