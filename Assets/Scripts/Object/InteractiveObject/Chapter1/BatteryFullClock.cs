using UnityEngine;

public class BatteryFullClock : MonoBehaviour
{
    [SerializeField]
    private Texture dayTexture;

    [SerializeField]
    private Texture nightTexture;

    public void ClickDaytimeButton()
    {
        GetComponent<MeshRenderer>().materials[2].mainTexture = dayTexture;
        GameManager.Instance.ChangeToDaytime();
    }

    public void ClickNightButton()
    {
        GetComponent<MeshRenderer>().materials[2].mainTexture = nightTexture;
        GameManager.Instance.ChangeToNight();
    }
}
