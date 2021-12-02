using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private Text timeText;
    private float time;

    void Start()
    {
        timeText = GetComponent<Text>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        int h, m, s, d, t;
        t = (int) time;
        h = t / 3600;
        m = (t % 3600) / 60;
        s = (t % 60);
        d = (int) ((time - t) * 10);
        timeText.text =
            ((h < 10) ? "0" : "") + h + ":" +
            ((m < 10) ? "0" : "") + m + ":" +
            ((s < 10) ? "0" : "") + s + "." + d;
    }
}
