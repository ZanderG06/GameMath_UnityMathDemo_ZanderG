using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;

public class ZanderG_ChestWeights : MonoBehaviour
{
    [Header("Chest Types")]
    [SerializeField] int WoodChest;
    [SerializeField] int BronzeChest;
    [SerializeField] int SilverChest;
    [SerializeField] int GoldChest;
    [SerializeField] int PlatinumChest;

    [Header("Wooden Chest")]
    [SerializeField] int WoodChestCommon;
    [SerializeField] int WoodChestUncommon;
    [SerializeField] int WoodChestRare;
    [SerializeField] int WoodChestEpic;
    [SerializeField] int WoodChestLegendary;

    [Header("Bronze Chest")]
    [SerializeField] int BronzeChestCommon;
    [SerializeField] int BronzeChestUncommon;
    [SerializeField] int BronzeChestRare;
    [SerializeField] int BronzeChestEpic;
    [SerializeField] int BronzeChestLegendary;

    [Header("Silver Chest")]
    [SerializeField] int SilverChestCommon;
    [SerializeField] int SilverChestUncommon;
    [SerializeField] int SilverChestRare;
    [SerializeField] int SilverChestEpic;
    [SerializeField] int SilverChestLegendary;

    [Header("Gold Chest")]
    [SerializeField] int GoldChestCommon;
    [SerializeField] int GoldChestUncommon;
    [SerializeField] int GoldChestRare;
    [SerializeField] int GoldChestEpic;
    [SerializeField] int GoldChestLegendary;

    [Header("Platinum Chest")]
    [SerializeField] int PlatinumChestCommon;
    [SerializeField] int PlatinumChestUncommon;
    [SerializeField] int PlatinumChestRare;
    [SerializeField] int PlatinumChestEpic;
    [SerializeField] int PlatinumChestLegendary;

    static int chestTypeTotal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> chestTypes = new List<int>() { WoodChest, BronzeChest, SilverChest, GoldChest, PlatinumChest };

        chestTypeTotal = WoodChest + BronzeChest + SilverChest + GoldChest + PlatinumChest;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomNumber = Random.Range(0, chestTypeTotal+1);

            if(randomNumber <= WoodChest)
            {
                Debug.Log("Wooden");
            }
            else if(randomNumber <= BronzeChest + WoodChest)
            {
                Debug.Log("Bronze");
            }
            else if (randomNumber <= SilverChest + BronzeChest + WoodChest)
            {
                Debug.Log("Silver");
            }
            else if (randomNumber <= GoldChest + SilverChest + BronzeChest + WoodChest)
            {
                Debug.Log("Gold");
            }
            else
            {
                Debug.Log("Platinum");
            }
        }
    }
}
