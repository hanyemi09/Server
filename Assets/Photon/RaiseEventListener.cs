﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ExitGames.Client.Photon;
using Photon.Pun;

public class RaiseEventListener : MonoBehaviourPun
{
    private void OnEnable()
    {
        PhotonNetwork.NetworkingClient.EventReceived += OnEvent;
    }

    private void OnDisable()
    {
        PhotonNetwork.NetworkingClient.EventReceived += OnEvent;
    }

    private void OnEvent(EventData obj)
    {
        Debug.Log(obj);
        Debug.Log("Receiving Evnet");
        Debug.Log("OnEvent : " + (string)obj.CustomData);
    }
}
