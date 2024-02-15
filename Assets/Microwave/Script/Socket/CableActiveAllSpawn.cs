using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class CableActiveAllSpawn : MonoBehaviour
{
    public GameObject firstObject1, secondObject1, lineRenderer1;
    public GameObject[] activatedObjects1;
    public GameObject[] naration; // New array for narration objects
    private bool[] collided;
    private bool[] grabbed;

    // Start is called before the first frame update
    void Start()
    {
        collided = new bool[activatedObjects1.Length];
        grabbed = new bool[activatedObjects1.Length];

        for (int i = 0; i < activatedObjects1.Length; i++)
        {
            activatedObjects1[i].SetActive(false);
        }

        // Deactivate narration objects at the start
        //foreach (GameObject narrationObj in naration)
        //{
           // narrationObj.SetActive(false);
        //}
    }

    public void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < activatedObjects1.Length; i++)
        {
            if (other.gameObject.name == firstObject1.name)
            {
                collided[i] = true;
                // Debug.Log("OnTriggerEnter OK");
            }
        }

        // Activate narration objects when triggered
        //foreach (GameObject narrationObj in naration)
        //{
            //narrationObj.SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < activatedObjects1.Length; i++)
        {
            grabbed[i] = firstObject1.GetComponent<Grabbable>().TransferOnSecondSelection;
            ObjectInstalled(i);
        }
    }

    void ObjectInstalled(int index)
    {
        if (grabbed[index] == false && collided[index] == true)
        {
            firstObject1.gameObject.transform.rotation = secondObject1.transform.rotation;
            activatedObjects1[index].SetActive(true);
            // Periksa apakah ada objek narration untuk indeks ini
            if (index < naration.Length)
            {
                naration[index].SetActive(false);
            }

            Destroy(firstObject1);
            Destroy(secondObject1);
            Destroy(lineRenderer1);
            // Debug.Log("ObjectInstalled OK");
        }
    }
}