using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManual : MonoBehaviour
{
    public GameObject toTriggerObj;
    public GameObject[] actObj;
    public GameObject[] nonActObj;

    void Start()
    {
        //SetObjectsActive(actObj, false);
        //SetObjectsActive(nonActObj, false);
    }
    
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == toTriggerObj)
        {
            
            SetObjectsActive(actObj, true);
            SetObjectsActive(nonActObj, false);
        }
    }

    void SetObjectsActive(GameObject[] objects, bool active)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(active);
        }
    }
}
