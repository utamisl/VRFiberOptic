using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePerangkat : MonoBehaviour
{

    public GameObject show, hide;

    public void proses()
    {
        show.SetActive(true);
        hide.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
