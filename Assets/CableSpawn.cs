using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class CableSpawn : MonoBehaviour
{
    // [SerializeField] private ObjectInteraction[] objectInteractions;
    public GameObject firstObject, secondObject, lineRenderer, activatedObject;
    // public Collider firstObjectC, secondObjectC;
    private bool collided = false;
    private bool grabbed;

    // Start is called before the first frame update
    void Start()
    {
        if (collided == false)
        {
            activatedObject.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == firstObject.name)
        {
            collided = true;

            // Debug.Log("OnTriggerEnter OK");
        }
    }

    // Update is called once per frame
    void Update()
    {
        grabbed = firstObject.GetComponent<Grabbable>().TransferOnSecondSelection;
        ObjectInstalled();
    }

    void ObjectInstalled()
    {

        if (grabbed == false && collided == true)
        {
            //firstObject.gameObject.transform.position = transform.position;
            firstObject.gameObject.transform.rotation = secondObject.transform.rotation;
            activatedObject.SetActive(true);
            Destroy(firstObject);
            Destroy(secondObject);
            Destroy(lineRenderer);
            // Debug.Log("ObjectInstalled OK");
        }
    }

    // [System.Serializable]
    // public class ObjectInteraction{
    //     public GameObject firstObject;
    //     public GameObject secondObject;
    //     public GameObject LineRenderer;

    //     [Header("Objek yang diaktifkan")]
    //     public GameObject activatedObject;
    // }
}