using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string loadLevel;

    public GameObject loadingScreen;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    public void load()
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(loadLevel);
    }
}
