using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour //This class responsible for the background movement, that makes it looks like we're moving towards
{
    private MeshRenderer mesh_renderer;
    public float speed = 1f;
    
    private void Awake()
    {
        mesh_renderer = GetComponent<MeshRenderer>();
    }
    
    private void Update()
    {
        mesh_renderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0); //Moving the background horizontally
    }
}
