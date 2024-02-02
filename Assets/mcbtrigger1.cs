using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mcbtrigger1 : MonoBehaviour
{

    Animator _mcbAnim;

    private void OnTriggerEnter(Collider other)
    {
        _mcbAnim.SetTrigger("ActionStart");
    }

    // Start is called before the first frame update
    void Start()
    {
        _mcbAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
