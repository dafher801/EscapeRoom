using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveObject : InteractiveObject
{
    public MoveSceneCamera moveSceneCamera;

    protected override void Interact()
    {
        if (moveSceneCamera)
            CameraSystem.Instance.MoveCamera(moveSceneCamera);
    }
}
