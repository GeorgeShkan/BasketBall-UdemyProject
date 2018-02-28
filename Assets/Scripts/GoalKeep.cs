using UnityEngine;
using System.Collections;

public class GoalKeep : MonoBehaviour {
    //public int score; //Score keeping variable
    public Collider scoreCollider;
    public LevelManger scoreGoal;

    void Start()
    {
        scoreGoal = FindObjectOfType<LevelManger>();
    }

    public void ExpectTrigger(Collider collider) {
        scoreCollider = collider;
    }

    void OnTriggerEnter(Collider colliderSecond)
    {
        if(colliderSecond == scoreCollider)
        {
            scoreGoal.incrementScore();
        }
    }
}
