using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text mytext;
    public Text scoretext;
    public Text leveltext;
    public int scores;
    public int levels;
    float timer = 0.0f;
    public int seconds;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        if(seconds == 30)
        {
            seconds = 0;
            timer = 0;
            levels = levels + 1;
        }

        scores = points.score;
        leveltext.text = "Level: " + levels;
        mytext.text = "Timer: " + seconds;
        scoretext.text = "score: " + scores ;
    }
}
