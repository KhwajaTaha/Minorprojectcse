using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBackground : MonoBehaviour
{
    [SerializeField] Vector2 paralaxEFM;
    private Transform cameraTransform;
    private Vector3 lastcameraposition;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastcameraposition = cameraTransform.position;
    }

    void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastcameraposition;

        transform.position += new Vector3(deltaMovement.x * paralaxEFM.x, deltaMovement.y * paralaxEFM.y);
        lastcameraposition = cameraTransform.position;
    }
}
