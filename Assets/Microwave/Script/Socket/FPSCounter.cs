using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    public float updateInterval = 0.5f; // Interval at which to update the FPS display
    private float accum = 0.0f; // FPS accumulated over the interval
    private int frames = 0; // Frames drawn over the interval
    private float timeleft; // Left time for current interval
    private float fps; // Current FPS
    public TMP_Text fpsText; // Reference to TextMeshPro object

    void Start()
    {
        timeleft = updateInterval;
    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        frames++;

        // Interval ended - update FPS and restart the interval
        if (timeleft <= 0.0f)
        {
            // Calculate current FPS
            fps = accum / frames;

            // Reset variables for the next interval
            timeleft = updateInterval;
            accum = 0.0f;
            frames = 0;

            // Update FPS text
            if (fpsText != null)
            {
                fpsText.text = "FPS: " + fps.ToString("F2");
            }
        }
    }
}