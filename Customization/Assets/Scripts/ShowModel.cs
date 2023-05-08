using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the script used to show or hide models when you click on the model number UI.
/// </summary>
public class ShowModel : MonoBehaviour
{
    public CopyMaterials copyMaterials;

    [Header("List of Models")]
    public GameObject modelDress;
    public GameObject modelHoodie;
    public GameObject modelHoodie2;
    public GameObject modelUniform;
    public GameObject modelUniform2;

    public void ShowModelDress()
    {
        HideAllModel();
        modelDress.SetActive(true);
        copyMaterials.targetModel = modelDress;
    }

    public void ShowModelHoodie()
    {
        HideAllModel();
        modelHoodie.SetActive(true);
        copyMaterials.targetModel = modelHoodie;
    }

    public void ShowModel2Hoodie()
    {
        HideAllModel();
        modelHoodie2.SetActive(true);
        copyMaterials.targetModel = modelHoodie2;
    }

    public void ShowModelUniform()
    {
        HideAllModel();
        modelUniform.SetActive(true);
        copyMaterials.targetModel = modelUniform;
    }

    public void ShowModelUniform2()
    {
        HideAllModel();
        modelUniform2.SetActive(true);
        copyMaterials.targetModel = modelUniform2;
    }


    public void HideAllModel()
    {
        modelDress.SetActive(false);
        modelHoodie.SetActive(false);
        modelHoodie2.SetActive(false);
        modelUniform.SetActive(false);
        modelUniform2.SetActive(false);
    }
}
