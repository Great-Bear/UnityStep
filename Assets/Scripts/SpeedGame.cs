using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedGame : MonoBehaviour
{
    public Slider slider;
    public static float SpeedGameValue = 1;
    public void ChangeSpeedGame(Slider slider)
    {
        SpeedGameValue = slider.value;
    }
}
