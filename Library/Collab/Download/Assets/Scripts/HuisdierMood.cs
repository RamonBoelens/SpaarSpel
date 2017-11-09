using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuisdierMood : MonoBehaviour {

    [SerializeField] Renderer Renderer;

    [SerializeField] Color happy;
    [SerializeField] Color sad;

    private float moodLevel = 100;
    private float decreaseMoodAmount = 1.67f;
    private float time;

    private int i = 0;

    // Use this for initialization
    void Start ()
    {
        // Call the function DecreaseMood every second
        InvokeRepeating("DecreaseMood", 1.0f, 1.0f);

        time = moodLevel / decreaseMoodAmount;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Seconds: " + i + ", MoodLevel: " + moodLevel);
        // Change to color depending on the moodLevel
        Renderer.material.color = Color.Lerp(sad, happy, moodLevel/time);
    }

    private void DecreaseMood()
    {
        // Decreases MoodLevel with decreaseMoodAmount as long as moodLevel is above 0
        if (moodLevel > 0)
        {
            moodLevel -= decreaseMoodAmount;
        }

        i++;
    }
}
