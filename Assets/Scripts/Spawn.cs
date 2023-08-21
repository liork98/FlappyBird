using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawn_rate = 1f;
    public float minimum_height = -1f;
    public float maxmum_height = 1f;

    private void OnEnable() //Calls repeatedly the spawn function while the scrip is enable
    {
        InvokeRepeating(nameof(Spawn), spawn_rate, spawn_rate);
    }
    private void OnDisable() 
    {
        CancelInvoke(nameof(Spawn)); //Stops calling spawn function
    }
    private void Spawn()//This function duplicates the pipes repeatedly and place them on screen, with randomly gap position
    {
        GameObject pipeDuplication = Instantiate(prefab, transform.position, Quaternion.identity);
        pipeDuplication.transform.position += Vector3.up * Random.Range(minimum_height, maxmum_height);
    }
}
