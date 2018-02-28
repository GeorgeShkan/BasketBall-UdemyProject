using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public LevelManger levelManager;
    Text text;
    public float timeRemaining;
    public bool gameOn = true;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManger>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOn)
        {
            //timeRemaining = 20.0f;
            if (timeRemaining >= 0.0f)
            {
                //gameOn = true;
                timeRemaining -= Time.deltaTime;
            }

            if (timeRemaining < 0.0f)
            {
                //finalScore = score;
                gameOn = false;
                levelManager.NextSceneLevel();
                timeRemaining = 20.0f;
            };
        }

        //timeLeft = levelManager.getTime();
        text.text = "Time Left: " + timeRemaining;
    }
}