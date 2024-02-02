using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombolcontroller : MonoBehaviour
{

    Animator _MCBAnim;

    private void OnTriggerEnter(Collider other)
    {
        _MCBAnim.SetTrigger("ActionStart");
    }

    // Start is called before the first frame update
    void Start()
    {
        _MCBAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
