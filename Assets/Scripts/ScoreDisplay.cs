using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    public LevelManger scoreKeep;
    public int currentScore;
    Text text;

    // Use this for initialization
    void Start() {
        scoreKeep = FindObjectOfType<LevelManger>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        int currentScore = scoreKeep.getScore();
        text.text = "Score: " + currentScore;     
    }
}
