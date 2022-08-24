using UnityEngine;

public class Clock : MonoBehaviour
{
    public void Interact()
    {
        GameManager.Instance.Inventory.GainItem(EItemType.CHAPTER1_EMPTY_WATCH);
        gameObject.SetActive(false);
        GameManager.Instance.saveData.SaveMapItem(this);
    }
}
