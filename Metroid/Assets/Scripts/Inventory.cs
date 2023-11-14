using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Arroyo, Jordan
/// 11/13/2023
/// This script is to allow the player to pick up different
/// items and put them into an inventory
/// </summary>

public class Inventory : MonoBehaviour
{
    public Item[] inventoryArray;

    // Start is called before the first frame update
    void Start()
    {
        inventoryArray = new Item[2];

        for (int count = 0; count < inventoryArray.Length; count++)
        {
            inventoryArray[count] = null;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Item>())
        {
            Item holdItem = other.GetComponent<Item>();
        }
    }

    private bool AddToInventory(Item itemToAdd)
    {
        for (int index = 0; index < inventoryArray.Length; index++)
        {
            if (inventoryArray[index] == null)
            {
                inventoryArray[index] = itemToAdd;

                return true;
            }
        }

        return false;
    }
}
