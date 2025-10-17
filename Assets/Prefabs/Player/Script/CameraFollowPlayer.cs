using System;
using System.Collections.Specialized;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private Vector3 offSet;
    private PlayerMovement playerMovement;


    void Start()
    {
        offSet = new Vector3(0, 1, -5);
        playerMovement = FindFirstObjectByType<PlayerMovement>(); // Unity sugiere Object.FindFirstObjectByType
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        gameObject.transform.position = playerMovement.transform.position + offSet; ;
    }
}
