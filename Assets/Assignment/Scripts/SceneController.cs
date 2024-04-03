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
    public Slider HealthBarTemp;
    public TMP_Text HpValue;
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

    public void TempTakeDamage()
    {
        HealthBarTemp.value += Pokemon.getStrength();
        currentHP = 100 - HealthBarTemp.value;
        HpValue.text = "HP: " + currentHP.ToString();
    }
}
