using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

public class ButtonosScriptos : MonoBehaviour
{
    public void GetItem(int index)
    {
        ItemV2 itemBought = ShopV2.listItems[index];
        int penize = 100; //Odn�kud dostat prachy
        if (itemBought.cena >= penize)
        {
            //Nahradit item kter� pr�v� vlastn�m za ten kterej jsem koupil
            //Kdy�tak p�eparsovat ItemV2 staty na staty gameobjectu
            penize -= (int)itemBought.cena;
        }

    }


}
