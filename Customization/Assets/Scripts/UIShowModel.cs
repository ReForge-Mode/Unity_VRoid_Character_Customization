using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShowModel : MonoBehaviour
{
    public CopyCharacters copyCharacters;
    public GameObject modelDress;
    public GameObject modelHoodie;
    public GameObject modelHoodie2;
    public GameObject modelUniform;
    public GameObject modelUniform2;

    public void ShowModelDress()
    {
        modelDress.SetActive(true);
        modelHoodie.SetActive(false);
        modelHoodie2.SetActive(false);
        modelUniform.SetActive(false);
        modelUniform2.SetActive(false);
        copyCharacters.targetModel = modelDress;
    }

    public void ShowModelHoodie()
    {
        modelDress.SetActive(false);
        modelHoodie.SetActive(true);
        modelHoodie2.SetActive(false);
        modelUniform.SetActive(false);
        modelUniform2.SetActive(false);
        copyCharacters.targetModel = modelHoodie;
    }

    public void ShowModel2Hoodie()
    {
        modelDress.SetActive(false);
        modelHoodie.SetActive(false);
        modelHoodie2.SetActive(true);
        modelUniform.SetActive(false);
        modelUniform2.SetActive(false);
        copyCharacters.targetModel = modelHoodie2;
    }

    public void ShowModelUniform()
    {
        modelDress.SetActive(false);
        modelHoodie.SetActive(false);
        modelHoodie2.SetActive(false);
        modelUniform.SetActive(true);
        modelUniform2.SetActive(false);
        copyCharacters.targetModel = modelUniform;
    }

    public void ShowModelUniform2()
    {
        modelDress.SetActive(false);
        modelHoodie.SetActive(false);
        modelHoodie2.SetActive(false);
        modelUniform.SetActive(false);
        modelUniform2.SetActive(true);
        copyCharacters.targetModel = modelUniform2;
    }
}
