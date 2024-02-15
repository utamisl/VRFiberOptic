using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFliFlopSocket : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public float flipInterval = 1.0f; // Time interval for flipping materials

    private Renderer meshRenderer;
    private bool isMaterial1 = true;
    private float timer = 0.0f;

    void Start()
    {
        meshRenderer = GetComponent<Renderer>();

        if (meshRenderer == null)
        {
            Debug.LogError("Mesh Renderer not found on the object!");
            enabled = false; // Disable the script if no renderer is found
        }

        if (material1 == null || material2 == null)
        {
            Debug.LogError("Materials not assigned!");
            enabled = false; // Disable the script if materials are not assigned
        }

        // Set the initial material
        meshRenderer.material = material1;
    }

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if it's time to flip materials
        if (timer >= flipInterval)
        {
            // Flip materials
            if (isMaterial1)
            {
                meshRenderer.material = material2;
            }
            else
            {
                meshRenderer.material = material1;
            }

            // Reset the timer
            timer = 0.0f;

            // Toggle the material flag
            isMaterial1 = !isMaterial1;
        }
    }
}