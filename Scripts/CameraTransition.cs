using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera playerCamera, groupCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            groupCamera.Priority = playerCamera.Priority + 1;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
            groupCamera.Priority = playerCamera.Priority - 1;
        }
    }

}
