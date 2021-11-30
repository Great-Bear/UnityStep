using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControll : MonoBehaviour
{
    public GameObject menu;
    public GameObject MenuBtn;
    public Text infoText;
    public void Play() 
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        MenuBtn.SetActive(true);
        infoText.text = string.Empty;
    }
    public void Menu()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
        MenuBtn.SetActive(false);
        infoText.text = "Пауза";
    }
    public void Restard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
