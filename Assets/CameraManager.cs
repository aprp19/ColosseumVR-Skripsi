using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraManager : MonoBehaviour
{
    public GameObject localPlayer;
    public Camera camera;
    public Canvas canvas;
    public string state;

    public MyNetManager myNetManager;

    void Update()
    {
        if (myNetManager.state == "Playing")
        {
            setCanvas();
            state = myNetManager.state;
        }
        else
        {
            state = myNetManager.state;
            unsetCanvas();
        }
    }

    public void setCanvas()
    {
        localPlayer = GameObject.Find("local player");
        camera = localPlayer.GetComponentInChildren<Camera>();
        canvas.transform.position = camera.transform.position;
        canvas.worldCamera = camera;
    }

    public void unsetCanvas()
    {
        canvas.worldCamera = null;
    }
}
