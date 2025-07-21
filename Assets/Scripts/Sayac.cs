using UnityEngine;

public class Sayac : MonoBehaviour
{
    int timePassed = 0;
    void Start()
    {
        InvokeRepeating("UpdateTime", 1f, 1f);
    }
    void UpdateTime()
    {
        timePassed++;
        Debug.Log("Gecen zaman: " + timePassed + " saniye");

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StopTime();
        }
    }
    void StopTime()
    {
        CancelInvoke("UpdateTime");
        Debug.Log("Timer stopped");
    }
}   
