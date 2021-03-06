using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Inventory inventory;

    public List<Item> itemDictionary;

    private int activatedUINum;

    void Start()
    {
        InitActivatedUINum();
    }

    public void InitActivatedUINum()
    {
        activatedUINum = 0;
    }

    public void IncreaseActivatedUINum()
    {
        activatedUINum++;
    }

    public void DecreaseActivatedUINum()
    {
        activatedUINum--;
    }
}
