using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndScene : MonoBehaviour
{
    public string SceneName;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Load()
    {
        SceneManager.LoadScene(SceneName);
    }
}
