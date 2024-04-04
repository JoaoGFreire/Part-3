using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    //public Slider HealthBarTemp;
    //public TMP_Text HpValue;
    float currentHP;

    private void Start()
    {

    }
    public void LoadNextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = (currentScene + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextScene);
    }
    public static void DeathScene()
    {
        SceneManager.LoadScene(2);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public static void WinScene()
    {
        SceneManager.LoadScene(3);
    }

}
