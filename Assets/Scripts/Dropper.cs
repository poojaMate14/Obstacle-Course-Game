using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rendererObj;
    Rigidbody rigidbodyObj;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rendererObj = GetComponent<MeshRenderer>();
        rigidbodyObj = GetComponent<Rigidbody>();

        rendererObj.enabled = false;
        rigidbodyObj.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rendererObj.enabled = true;
            rigidbodyObj.useGravity = true;
        }
    }
}
