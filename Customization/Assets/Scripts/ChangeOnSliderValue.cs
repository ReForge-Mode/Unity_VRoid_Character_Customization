using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOnSliderValue : MonoBehaviour
{
    public CopyMaterials copyMaterials;
    public ChooseHairSets chooseHairSets;
    public Slider sliderAll;
    public Slider sliderFace;
    public Slider sliderEyes;
    public Slider sliderSkin;
    public Slider sliderClothes;
    public Slider sliderHair;

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
}