using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ConnectionBtn : MonoBehaviour
{
    public void Join()
    {
        NetworkManager.Singleton.StartClient();
    }
    public void Host()
    {
        NetworkManager.Singleton.StartHost();
    }
}
