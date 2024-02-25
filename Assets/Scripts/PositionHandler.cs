using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PositionHandler : MonoBehaviour
{
    public List<LapCounter> carLapCounters = new List<LapCounter>();


    void Start()
    {
        LapCounter[] carLapCounterArray = FindObjectsOfType<LapCounter>();

        carLapCounters = carLapCounterArray.ToList<LapCounter>();

        foreach (LapCounter lapCounters in carLapCounters)
            lapCounters.OnPassCheckpoint += OnPassCheckpoint;

    }


    void OnPassCheckpoint(LapCounter lapCounter)
    {
        carLapCounters = carLapCounters.OrderByDescending(s => s.GetNumberOfCheckpointsPassed()).ThenBy(s => s.GetTimeAtLastCheckpoint()).ToList();

        int carPosition = carLapCounters.IndexOf(lapCounter) + 1;

        lapCounter.SetCarPosition(carPosition);
    }
}
