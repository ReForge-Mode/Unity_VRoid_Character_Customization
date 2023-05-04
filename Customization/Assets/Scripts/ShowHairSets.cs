using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseHairSets : MonoBehaviour
{
    public HairSets[] hairsetLists;

    public void ShowHair(int index)
    {
        //Disable every hair first
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
