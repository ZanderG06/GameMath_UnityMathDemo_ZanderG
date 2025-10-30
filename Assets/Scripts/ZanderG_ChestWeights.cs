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
    static int woodChestTotal;
    static int bronzeChestTotal;
    static int silverChestTotal;
    static int goldChestTotal;
    static int platinumChestTotal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> chestTypes = new List<int>() { WoodChest, BronzeChest, SilverChest, GoldChest, PlatinumChest };

        chestTypeTotal = WoodChest + BronzeChest + SilverChest + GoldChest + PlatinumChest;
        woodChestTotal = WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary;
        bronzeChestTotal = BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic + BronzeChestLegendary;
        silverChestTotal = SilverChestCommon + SilverChestUncommon + SilverChestRare + SilverChestEpic + SilverChestLegendary;
        goldChestTotal = GoldChestCommon + GoldChestUncommon + GoldChestRare + GoldChestEpic + GoldChestLegendary;
        platinumChestTotal = PlatinumChestCommon + PlatinumChestUncommon + PlatinumChestRare + PlatinumChestEpic + PlatinumChestLegendary;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomNumber = Random.Range(0, chestTypeTotal+1);

            if (randomNumber <= WoodChest)
            {
                WoodenChestItems();
            }
            else if (randomNumber <= BronzeChest + WoodChest)
            {
                BronzeChestItems();
            }
            else if (randomNumber <= SilverChest + BronzeChest + WoodChest)
            {
                SilverChestItems();
            }
            else if (randomNumber <= GoldChest + SilverChest + BronzeChest + WoodChest)
            {
                GoldChestItems();
            }
            else
            {
                PlatinumChestItems();
            }
        }
    }

    private void WoodenChestItems()
    {
        int randomNumber = Random.Range(0, woodChestTotal + 1);

        if (randomNumber <= WoodChestCommon)
        {
            Debug.Log("Wooden Chest, Common Item");
        }
        else if (randomNumber <= WoodChestUncommon + WoodChestCommon)
        {
            Debug.Log("Wooden Chest, Uncommon Item");
        }
        else if (randomNumber <= WoodChestRare + WoodChestUncommon + WoodChestCommon)
        {
            Debug.Log("Wooden Chest, Rare Item");
        }
        else if (randomNumber <= WoodChestEpic + WoodChestRare + WoodChestUncommon + WoodChestCommon)
        {
            Debug.Log("Wooden Chest, Epic Item");
        }
        else
        {
            Debug.Log("Wooden Chest, Legendary Item");
        }
    }

    private void BronzeChestItems()
    {
        int randomNumber = Random.Range(0, bronzeChestTotal + 1);

        if (randomNumber <= BronzeChestCommon)
        {
            Debug.Log("Bronze Chest, Common Item");
        }
        else if (randomNumber <= BronzeChestUncommon + BronzeChestCommon)
        {
            Debug.Log("Bronze Chest, Uncommon Item");
        }
        else if (randomNumber <= BronzeChestRare + BronzeChestUncommon + BronzeChestCommon)
        {
            Debug.Log("Bronze Chest, Rare Item");
        }
        else if (randomNumber <= BronzeChestEpic + BronzeChestRare + BronzeChestUncommon + BronzeChestCommon)
        {
            Debug.Log("Bronze Chest, Epic Item");
        }
        else
        {
            Debug.Log("Bronze Chest, Legendary Item");
        }
    }

    private void SilverChestItems()
    {
        int randomNumber = Random.Range(0, silverChestTotal + 1);

        if (randomNumber <= SilverChestCommon)
        {
            Debug.Log("Silver Chest, Common Item");
        }
        else if (randomNumber <= SilverChestUncommon + SilverChestCommon)
        {
            Debug.Log("Silver Chest, Uncommon Item");
        }
        else if (randomNumber <= SilverChestRare + SilverChestUncommon + SilverChestCommon)
        {
            Debug.Log("Silver Chest, Rare Item");
        }
        else if (randomNumber <= SilverChestEpic + SilverChestRare + SilverChestUncommon + SilverChestCommon)
        {
            Debug.Log("Silver Chest, Epic Item");
        }
        else
        {
            Debug.Log("Silver Chest, Legendary Item");
        }
    }

    private void GoldChestItems()
    {
        int randomNumber = Random.Range(0, goldChestTotal + 1);

        if (randomNumber <= GoldChestCommon)
        {
            Debug.Log("Gold Chest, Common Item");
        }
        else if (randomNumber <= GoldChestUncommon + GoldChestCommon)
        {
            Debug.Log("Gold Chest, Uncommon Item");
        }
        else if (randomNumber <= GoldChestRare + GoldChestUncommon + GoldChestCommon)
        {
            Debug.Log("Gold Chest, Rare Item");
        }
        else if (randomNumber <= GoldChestEpic + GoldChestRare + GoldChestUncommon + GoldChestCommon)
        {
            Debug.Log("Gold Chest, Epic Item");
        }
        else
        {
            Debug.Log("Gold Chest, Legendary Item");
        }
    }

    private void PlatinumChestItems()
    {
        int randomNumber = Random.Range(0, platinumChestTotal + 1);

        if (randomNumber <= PlatinumChestCommon)
        {
            Debug.Log("Platinum Chest, Common Item");
        }
        else if (randomNumber <= PlatinumChestUncommon + PlatinumChestCommon)
        {
            Debug.Log("Platinum Chest, Uncommon Item");
        }
        else if (randomNumber <= PlatinumChestRare + PlatinumChestUncommon + PlatinumChestCommon)
        {
            Debug.Log("Platinum Chest, Rare Item");
        }
        else if (randomNumber <= PlatinumChestEpic + PlatinumChestRare + PlatinumChestUncommon + PlatinumChestCommon)
        {
            Debug.Log("Platinum Chest, Epic Item");
        }
        else
        {
            Debug.Log("Platinum Chest, Legendary Item");
        }
    }
}
