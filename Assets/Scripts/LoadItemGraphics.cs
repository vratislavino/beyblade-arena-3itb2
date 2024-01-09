using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LoadItemGraphics : MonoBehaviour
{
    GameObject panel;
    GameObject itemPanel;

    public void Load(GameObject panel, GameObject itemPanel, List <ItemV2> items)
    {
        this.panel = panel;
        this.itemPanel = itemPanel;

        for (int i = 0; i < 5; i++)
        {
            CreateItemPanel(i, items[i]);
        }
        itemPanel.active = false;
    }

    void CreateItemPanel(int i, ItemV2 item)
    {
        GameObject itemPanelPrefab = Instantiate(itemPanel,panel.transform);

        itemPanelPrefab.transform.localPosition -= new Vector3(0, i * itemPanelPrefab.GetComponent<RectTransform>().rect.height, 0);

        GameObject text = itemPanelPrefab.transform.GetChild(0).gameObject;
        GameObject button = itemPanelPrefab.transform.GetChild(1).gameObject;

        button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => GetItem(i));

        text.GetComponent<TextMeshProUGUI>().text = $"{i} Název: {item.item.name}       Cena: {item.cena}\nRychlost Toèení: {(int)item.rychlostToceni}      Stamina: {(int)item.stamina}\nDamage: {(int)item.damage}        Defense: {(int)item.defense}";

    }

    public void GetItem(int index) //KOUPÌ ITEMU!!!!!!!!!!!!!!!!!!!!!!!!!!!
    {
        Debug.Log("KKT");
        ItemV2 itemBought = ShopV2.listItems[index];
        int penize = 100; //Odnìkud dostat prachy

        Debug.Log(itemBought.cena);

        if (itemBought.cena >= penize)
        {

            //Nahradit item který právì vlastním za ten kterej jsem koupil
            //Kdyžtak pøeparsovat ItemV2 staty na staty gameobjectu


            penize -= (int)itemBought.cena;
        }

    }
}
