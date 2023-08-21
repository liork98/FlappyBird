using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    public string scene_name;
    
    public void ChangeScene() //This function change scenes between the mainMenu scene to the Game scene
    {
        SceneManager.LoadScene(scene_name);
    }
}
