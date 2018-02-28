using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreAbsorb : MonoBehaviour {
    public LevelManger scoreKeep;
    public int score;
    Text text;

    // Use this for initialization
    void Start () {
        scoreKeep = FindObjectOfType<LevelManger>();
        text = GetComponent<Text>();
        score = scoreKeep.getScore();
        Destroy(scoreKeep.gameObject);
    }

    // Update is called once per frame
    void Update () {
        text.text = "Score: " + score;
    }
};
