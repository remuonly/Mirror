using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private Vector3 distance;
    private void Start()
    {
        distance = transform.position -player.position;
    }

    private void Update()
    {
        if(player)
        {
            // transform.position = Vector3.Lerp(transform.position, player.position + distance, Time.deltaTime*0.1f);
            transform.position = player.position + distance;
        }
    }
}
