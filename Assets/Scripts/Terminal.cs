﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Terminal : MonoBehaviour
{
    public ConnectedObjectData[] ConnectedObjects;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TerminalManager.Instance.Open(ConnectedObjects);
        }
    }

}

[Serializable]
public struct ConnectedObjectData
{
    public string Name;
    public ConnectedObject Prefab;
}
