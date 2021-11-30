using UnityEngine;
using UnityEngine.UI;

public class TimeControll : MonoBehaviour
{
    public Text timeText;
    private float time;

    void Start()
    {
        timeText.text = "00:00:00.0";
        time = 0;
        Time.timeScale = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        int h, m, s, d, t;
        t = (int)time;
        h = t / 3600;
        m = (t % 3600) / 60;
        s = (t % 60);
        d = (int)((time - t) * 10);
        timeText.text =
            ((h < 10) ? "0" : "") + h + ":" +
            ((m < 10) ? "0" : "") + m + ":" +
            ((s < 10) ? "0" : "") + s + "." + d;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
        }
    }
}
