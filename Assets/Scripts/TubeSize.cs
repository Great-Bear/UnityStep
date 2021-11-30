using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeSize : MonoBehaviour
{
    public static bool isHardMode = false;
    public GameObject tube;
    public void ChangeSizeTube()
    {
        isHardMode = !isHardMode;
        if (isHardMode == true)
        {
            tube.transform.position = new Vector2(tube.transform.position.x, 3.8f);
        }
        else
        {
            tube.transform.position = new Vector2(tube.transform.position.x, 4.9f);
        }
       
    }
}
