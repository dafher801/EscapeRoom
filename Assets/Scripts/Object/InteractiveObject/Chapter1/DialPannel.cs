using UnityEngine;

public class DialPannel : MonoBehaviour
{
    [SerializeField]
    private GameObject RGBPuzzlePadUI;

    private MoveSceneCamera moveSceneCamera;

    private void Start()
    {
        moveSceneCamera = GetComponentInChildren<MoveSceneCamera>();
    }

    public void Interact()
    {
        if (RGBPuzzlePadUI && moveSceneCamera)
        {
            RGBPuzzlePadUI.SetActive(true);
            CameraSystem.Instance.MoveCamera(moveSceneCamera);
        }
    }
}
