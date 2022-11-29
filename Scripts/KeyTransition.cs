using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class KeyTransition : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera playerCamera, otherCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            otherCamera.Priority = playerCamera.Priority + 2;
        }
        if(Input.GetKeyUp(KeyCode.L))
        {
            otherCamera.Priority = playerCamera.Priority - 2;
        }
    }
}
