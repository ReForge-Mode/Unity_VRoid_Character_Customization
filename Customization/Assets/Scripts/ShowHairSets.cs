using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the script that show or hides the selected hair on all models.
/// </summary>
public class ChooseHairSets : MonoBehaviour
{
    public HairSets[] hairsetLists;

    public void ShowHair(int index)
    {
        //Disable all hair first
        //Disable a gameobject instantly makes it disappear from the camera
        for (int i = 0; i < hairsetLists.Length; i++)
        {
            for (int j = 0; j < hairsetLists[i].hairList.Length; j++)
            {
                hairsetLists[i].hairList[j].SetActive(false);
            }
        }

        //Enable the chosen hair
        for (int i = 0; i < hairsetLists.Length; i++)
        {
            hairsetLists[i].hairList[index].SetActive(true);
        }
    }

    [System.Serializable]
    public struct HairSets
    {
        public GameObject model;
        public GameObject[] hairList;
    }
}
