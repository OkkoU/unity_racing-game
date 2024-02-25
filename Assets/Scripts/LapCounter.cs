using System;
using UnityEngine;

public class LapCounter : MonoBehaviour
{
    int passedCheckPointNumber = 0;
    float timeAtLastPassedCheckPoint = 0;
    int numberOfPassedCheckpoints = 0;
    int lapsCompleted = 0;
    const int lapsToComplete = 2;
    bool isRaceCompleted = false;
    int carPosition = 0;

    LapCounterUIHandler lapCounterUIHandler;

    public event Action<LapCounter> OnPassCheckpoint;


    void Start()
    {
        if (CompareTag("Player_1") || CompareTag("Player_2"))
        {
            lapCounterUIHandler = FindObjectOfType<LapCounterUIHandler>();
            lapCounterUIHandler.SetLapText($"LAP {lapsCompleted + 1} / {lapsToComplete}");
        }
    }


    public void SetCarPosition(int position)
    {
        carPosition = position;
    }


    public int GetNumberOfCheckpointsPassed()
    {
        return numberOfPassedCheckpoints;
    }

    public int GetNumberOfLapsCompleted()
    {
        return lapsCompleted;
    }


    public float GetTimeAtLastCheckpoint()
    {
        return timeAtLastPassedCheckPoint;
    }


    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("CheckPoint"))
        {
            if (isRaceCompleted)
            {
                return;
            }

            CheckPoint checkPoint = collider2D.GetComponent<CheckPoint>();

            if (passedCheckPointNumber + 1 == checkPoint.checkPointNumber)
            {
                passedCheckPointNumber = checkPoint.checkPointNumber;
                numberOfPassedCheckpoints++;
                timeAtLastPassedCheckPoint = Time.time;

                if (checkPoint.isFinishLine)
                {
                    passedCheckPointNumber = 0;
                    lapsCompleted++;

                    if (lapsCompleted >= lapsToComplete)
                    {
                        FindObjectOfType<GameManager>().GameOver();
                        isRaceCompleted = true;
                    }

                    if (!isRaceCompleted && lapCounterUIHandler != null)
                    {
                        lapCounterUIHandler.SetLapText($"LAP {lapsCompleted + 1} / {lapsToComplete}");
                    }
                }

                OnPassCheckpoint?.Invoke(this);
            }
        }
    }
}
