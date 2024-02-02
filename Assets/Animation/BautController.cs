using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BautController : MonoBehaviour
{

    Animator _BautAnim;

    private void OnTriggerEnter(Collider other)
    {
        _BautAnim.SetTrigger("ActionStart");
    }

    // Start is called before the first frame update
    void Start()
    {
        _BautAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
