using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject userMenu;
    public Slider tubesSpeedSlider;
    public Slider tubesGapSlider;

    private Text buttonText;
    private Text pauseText;

    public void ShowUserMenu()
	{
        userMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void HideUserMenu()
    {
        userMenu.SetActive(false);
        Time.timeScale = 1;
    }

    void Start()
    {
        ShowUserMenu();
        buttonText = GameObject.Find("ButtonStart")
            .GetComponentInChildren<Text>();
        pauseText = GameObject.Find("TextPause")
            .GetComponent<Text>();
        pauseText.text = "Game";
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
		{
            ShowUserMenu();
            buttonText.text = "Continue";
            pauseText.text = "Pause";
        }
    }

    public void ButtonStartClick()
	{
        HideUserMenu();
        Egg.MoveVelocity = 0.5f + tubesSpeedSlider.value;
        MoveTube.MoveVelocity = 0.5f + tubesSpeedSlider.value;
        MoveTube.GapSize = 1.5f + tubesGapSlider.value;
    }
}
