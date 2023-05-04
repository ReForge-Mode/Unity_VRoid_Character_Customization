using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CopyMaterials : MonoBehaviour
{
    [HideInInspector] public GameObject sourceModel;
    public GameObject targetModel;

    public void CopyFaceMaterial()
    {
        //Get the materials from the character's Face
        Transform sourceFace = sourceModel.transform.Find("Face");
        Transform targetFace = targetModel.transform.Find("Face");
        SkinnedMeshRenderer sourceMesh = sourceFace.GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetFace.GetComponent<SkinnedMeshRenderer>();
        Material[] sourceMaterials = sourceMesh.sharedMaterials;
        Material[] targetMaterials = targetMesh.sharedMaterials;

        //Set the Target materials as the Source material
        //This keeps the order of the material in the list, very important
        for (int i = 0; i < targetMaterials.Length; i++)
        {
            //We don't want any eye materials. Just everything else except the eyes
            if (targetMaterials[i].name.Contains("EyeWhite") ||
                targetMaterials[i].name.Contains("EyeIris") ||
                targetMaterials[i].name.Contains("EyeHighlight") ||
                targetMaterials[i].name.Contains("EyeExtra") ||
                targetMaterials[i].name.Contains("FaceEyeline") ||
                targetMaterials[i].name.Contains("FaceEyelash"))
            {
                continue;
            }
            else
            {
                for (int j = 0; j < sourceMaterials.Length; j++)
                {
                    //It's important to skip the first F/M letter in the material name
                    if (targetMaterials[i].name.Substring(11) ==
                        sourceMaterials[j].name.Substring(11))
                    {
                        targetMaterials[i] = sourceMaterials[j];
                        break;
                    }
                    else if (j == sourceMaterials.Length - 1)
                    {
                        Debug.Log("Name match is not found!");
                    }
                }
            }
        }

        //Set the new List as materials
        targetMesh.materials = targetMaterials;
    }

    public void CopyEyesMaterial()
    {
        //Get the materials
        Transform sourceFace = sourceModel.transform.Find("Face");
        Transform targetFace = targetModel.transform.Find("Face");
        SkinnedMeshRenderer sourceMesh = sourceFace.GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetFace.GetComponent<SkinnedMeshRenderer>();
        Material[] sourceMaterials = sourceMesh.sharedMaterials;
        Material[] targetMaterials = targetMesh.sharedMaterials;

        //Set the Target materials as the Source material
        //This keeps the order of the material in the list the same, very important
        for (int i = 0; i < targetMaterials.Length; i++)
        {
            //We only want all eyes materials to be swapped
            if (!targetMaterials[i].name.Contains("EyeWhite") &&
                !targetMaterials[i].name.Contains("EyeIris") &&
                !targetMaterials[i].name.Contains("EyeHighlight") &&
                !targetMaterials[i].name.Contains("EyeExtra") &&
                !targetMaterials[i].name.Contains("FaceEyeline") &&
                !targetMaterials[i].name.Contains("FaceEyelash"))
            {
                continue;
            }
            else
            {
                for (int j = 0; j < sourceMaterials.Length; j++)
                {
                    //It's important to skip the first F/M letter in the material name
                    if (targetMaterials[i].name.Substring(11) ==
                        sourceMaterials[j].name.Substring(11))
                    {
                        targetMaterials[i] = sourceMaterials[j];
                        break;
                    }
                    else if (j == sourceMaterials.Length - 1)
                    {
                        Debug.Log("Name match is not found!");
                    }
                }
            }
        }

        //Set the new List as materials
        targetMesh.materials = targetMaterials;
    }

    public void CopyBodySkinMaterial()
    {
        //Get the materials
        Transform sourceFace = sourceModel.transform.Find("Body");
        Transform targetFace = targetModel.transform.Find("Body");
        SkinnedMeshRenderer sourceMesh = sourceFace.GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetFace.GetComponent<SkinnedMeshRenderer>();
        Material[] sourceMaterials = sourceMesh.sharedMaterials;
        Material[] targetMaterials = targetMesh.sharedMaterials;

        //Set the Target materials as the Source material
        //This keeps the order of the material in the list, very important
        for (int i = 0; i < targetMaterials.Length; i++)
        {
            //We don't want any eye materials. Just everything else except the eyes
            if (!targetMaterials[i].name.Contains("Body"))
            {
                continue;
            }
            else
            {
                for (int j = 0; j < sourceMaterials.Length; j++)
                {
                    //It's important to skip the first F/M letter in the material name
                    if (targetMaterials[i].name.Substring(11) ==
                        sourceMaterials[j].name.Substring(11))
                    {
                        targetMaterials[i] = sourceMaterials[j];
                        break;
                    }
                    else if (j == sourceMaterials.Length - 1)
                    {
                        Debug.Log("Name match is not found!");
                    }
                }
            }
        }

        //Set the new List as materials
        targetMesh.materials = targetMaterials;
    }

    public void CopyClothesMaterial()
    {
        //Get the materials
        Transform sourceFace = sourceModel.transform.Find("Body");
        Transform targetFace = targetModel.transform.Find("Body");
        SkinnedMeshRenderer sourceMesh = sourceFace.GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetFace.GetComponent<SkinnedMeshRenderer>();
        Material[] sourceMaterials = sourceMesh.sharedMaterials;
        Material[] targetMaterials = targetMesh.sharedMaterials;

        //Set the Target materials as the Source material
        //This keeps the order of the material in the list, very important
        for (int i = 0; i < targetMaterials.Length; i++)
        {
            //We don't want any eye materials. Just everything else except the eyes
            if (!targetMaterials[i].name.Contains("Onepice") &&
                !targetMaterials[i].name.Contains("Tops") &&
                !targetMaterials[i].name.Contains("Bottoms") &&
                !targetMaterials[i].name.Contains("Accessory") &&
                !targetMaterials[i].name.Contains("Shoes"))
            {
                continue;
            }
            else
            {
                for (int j = 0; j < sourceMaterials.Length; j++)
                {
                    //It's important to skip the first F/M letter in the material name
                    //There are just way too many variations of tops and one-piece
                    if (targetMaterials[i].name.Substring(11) == sourceMaterials[j].name.Substring(11) ||
                        (targetMaterials[i].name.Contains("Onepice") && sourceMaterials[j].name.Contains("Tops")) ||
                        (targetMaterials[i].name.Contains("Tops") && sourceMaterials[j].name.Contains("Onepice")))
                    {
                        targetMaterials[i] = sourceMaterials[j];
                        break;
                    }
                    else if (j == sourceMaterials.Length - 1)
                    {
                        Debug.Log("Name match is not found!");
                    }
                }
            }
        }

        //Set the new List as materials
        targetMesh.materials = targetMaterials;
    }
}
