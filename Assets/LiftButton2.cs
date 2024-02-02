using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftButton2 : MonoBehaviour
{
    public CharacterController characterController;
    public Vector3 naik;
    public Vector3 turun;
    public Transform targetPosition;

    public void MoveToTargetUp()
    {
        characterController.Move(naik - characterController.transform.position);
    }

    public void MoveToTargetDown()
    {
        characterController.Move(turun - characterController.transform.position);
    }
}
