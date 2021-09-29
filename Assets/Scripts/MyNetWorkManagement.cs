using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class MyNetWorkManagement : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log("start server!");
    }
    public override void OnStopServer()
    {
        Debug.Log("stop server!");
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("connect to server!");
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("disconnect to server!");
    }
}
