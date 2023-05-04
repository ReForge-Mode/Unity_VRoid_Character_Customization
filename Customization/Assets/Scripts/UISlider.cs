using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlider : MonoBehaviour
{
    public CopyCharacters copyCharacters;
    public Slider sliderAll;
    public Slider sliderFace;
    public Slider sliderEyes;
    public Slider sliderSkin;
    public Slider sliderClothes;

    public List<GameObject> models;

    private void Awake()
    {
        sliderAll.maxValue      = models.Count - 1;
        sliderFace.maxValue     = models.Count - 1;
        sliderEyes.maxValue     = models.Count - 1;
        sliderSkin.maxValue     = models.Count - 1;
        sliderClothes.maxValue  = models.Count - 1;
    }

    public void OnAllValueChanged()
    {
        sliderFace.value    = sliderAll.value;
        sliderEyes.value    = sliderAll.value;
        sliderSkin.value    = sliderAll.value;
        sliderClothes.value = sliderAll.value;

        OnFaceValueChanged();
        OnEyesValueChanged();
        OnSkinValueChanged();
        OnClothesValueChanged();
    }

    public void OnFaceValueChanged()
    {
        //Run the CopyFace function
        copyCharacters.sourceModel = models[(int)sliderFace.value];
        copyCharacters.CopyFace();
    }

    public void OnEyesValueChanged()
    {
        //Run the CopyEyes function
        copyCharacters.sourceModel = models[(int)sliderEyes.value];
        copyCharacters.CopyEyes();
    }

    public void OnSkinValueChanged()
    {
        //Run the CopyEyes function
        copyCharacters.sourceModel = models[(int)sliderSkin.value];
        copyCharacters.CopyBody();
    }

    public void OnClothesValueChanged()
    {
        //Run the CopyEyes function
        copyCharacters.sourceModel = models[(int)sliderClothes.value];
        copyCharacters.CopyClothes();
    }
}