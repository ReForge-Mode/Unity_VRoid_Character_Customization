using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// This script contains functions that are triggered by the OnValueChanged event
/// in the UI Slider objects, and the UI arrow button OnClick event.
/// It is a script that calls another script!
/// You can find this as a component on "UI Interactive" gameobject
/// </summary>
public class ChangeOnSliderValue : MonoBehaviour
{
    public CopyMaterials copyMaterials;
    public ChooseHairSets chooseHairSets;

    [Header("References to the Slider UI")]
    public Slider sliderAll;
    public Slider sliderFace;
    public Slider sliderEyes;
    public Slider sliderSkin;
    public Slider sliderClothes;
    public Slider sliderHair;

    [Header("List of all premade models to copy materials from")]
    public List<GameObject> models;

    private void Awake()
    {
        int modelCount = models.Count - 1;
        sliderAll.maxValue      = modelCount;
        sliderFace.maxValue     = modelCount;
        sliderEyes.maxValue     = modelCount;
        sliderSkin.maxValue     = modelCount;
        sliderClothes.maxValue  = modelCount;
        sliderHair.maxValue     = modelCount;
    }

    #region These are functions used by the OnValueChanged() event on the UI sliders
    public void OnAllValueChanged()
    {
        sliderFace.value    = sliderAll.value;
        sliderEyes.value    = sliderAll.value;
        sliderSkin.value    = sliderAll.value;
        sliderClothes.value = sliderAll.value;
        sliderHair.value = sliderAll.value;

        OnFaceValueChanged();
        OnEyesValueChanged();
        OnSkinValueChanged();
        OnClothesValueChanged();
        OnHairValueChanged();
    }

    public void OnFaceValueChanged()
    {
        copyMaterials.sourceModel = models[(int)sliderFace.value];
        copyMaterials.CopyFaceMaterial();
    }

    public void OnEyesValueChanged()
    {
        copyMaterials.sourceModel = models[(int)sliderEyes.value];
        copyMaterials.CopyEyesMaterial();
    }

    public void OnSkinValueChanged()
    {
        copyMaterials.sourceModel = models[(int)sliderSkin.value];
        copyMaterials.CopyBodySkinMaterial();
    }

    public void OnClothesValueChanged()
    {
        copyMaterials.sourceModel = models[(int)sliderClothes.value];
        copyMaterials.CopyClothesMaterial();
    }

    public void OnHairValueChanged()
    {
        int index = (int)sliderHair.value;
        chooseHairSets.ShowHair(index);
    }
    #endregion


    #region These are functions used by the OnClick() event on the UI arrow buttons
    public void IncreaseAllSliderValue(int value)
    {
        sliderAll.value += value;

        if (sliderAll.value < sliderAll.maxValue)
            sliderAll.value = sliderAll.maxValue;

        if (sliderAll.value < 0)
            sliderAll.value = 0;

        OnAllValueChanged();
    }

    public void IncreaseFaceSliderValue(int value)
    {
        sliderFace.value += value;

        if (sliderFace.value > sliderFace.maxValue)
            sliderFace.value = sliderFace.maxValue;

        if (sliderFace.value < 0)
            sliderFace.value = 0;

        OnFaceValueChanged();
    }

    public void IncreaseEyesSliderValue(int value)
    {
        sliderEyes.value += value;

        if (sliderEyes.value > sliderEyes.maxValue)
            sliderEyes.value = sliderEyes.maxValue;

        if (sliderEyes.value < 0)
            sliderEyes.value = 0;

        OnEyesValueChanged();
    }

    public void IncreaseSkinSliderValue(int value)
    {
        sliderSkin.value += value;

        if (sliderSkin.value > sliderSkin.maxValue)
            sliderSkin.value = sliderSkin.maxValue;

        if (sliderSkin.value < 0)
            sliderSkin.value = 0;

        OnSkinValueChanged();
    }

    public void IncreaseClothesSliderValue(int value)
    {
        sliderClothes.value += value;

        if (sliderClothes.value > sliderClothes.maxValue)
            sliderClothes.value = sliderClothes.maxValue;

        if (sliderClothes.value < 0)
            sliderClothes.value = 0;

        OnClothesValueChanged();
    }

    public void IncreaseHairSliderValue(int value)
    {
        sliderHair.value += value;

        if (sliderHair.value > sliderHair.maxValue)
            sliderHair.value = sliderHair.maxValue;

        if (sliderHair.value < 0)
            sliderHair.value = 0;

        OnHairValueChanged();
    }
    #endregion
}