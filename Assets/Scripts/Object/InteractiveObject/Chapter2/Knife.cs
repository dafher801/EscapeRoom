using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public void Interact()
    {
        GameManager.Instance.inventory.GainItem(EItemType.CHAPTER2_KNIFE);
        Destroy(gameObject);
    }
}