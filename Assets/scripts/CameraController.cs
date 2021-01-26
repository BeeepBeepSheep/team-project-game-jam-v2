using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform Player;
    public float dampTime = 1f;
    private Vector3 cameraPos;
    private Vector3 velocity = Vector3.zero;


    void Update()
    {
        Vector3 temp = transform.position;

        temp.x = Player.position.x;
        transform.position = temp;

        temp.y = Player.position.y;
        transform.position = temp;
    }
}
