using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script to iventory collect cherry.
public class Iventory : MonoBehaviour
{
    public Text Cherry;
    private Dictionary<string, int> myInventory = new Dictionary<string, int>();

    private void Start()
    {
        // Add cherry to inventory.
        myInventory.Add("Cherry", 0);

        DisplayInventory();
    }
    private void Update()
    {
        Value();
        DisplayInventory();
    }
    // Show value cherry.
    public void DisplayInventory()
    {
        Cherry.text = "";
        if (myInventory.Count <= 0)
        {
            Cherry.text = "0!!!";
        }
        foreach (var item in myInventory)
            Cherry.text += item.Value +"/10" + "\n";
    }
    //Configure Cherry.
    public void Value()
    {
        myInventory["Cherry"] = Gamemanager.Instance.Cherry;
    }

}
