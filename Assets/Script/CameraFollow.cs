using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Transform player;
    [SerializeField] Vector3 a ;
    // Update is called once per frame
    void Update()
    {   
        transform.position = player.transform.position + a;
    }
}
