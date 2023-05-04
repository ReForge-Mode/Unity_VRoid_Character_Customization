using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CopyCharacters : MonoBehaviour
{
    [HideInInspector] public GameObject sourceModel;
    public GameObject targetModel;

    public void CopyFace()
    {
        //Get the materials
        SkinnedMeshRenderer sourceMesh = sourceModel.transform.Find("Face").GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetModel.transform.Find("Face").GetComponent<SkinnedMeshRenderer>();
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
                    if (targetMaterials[i].name.Substring(11) == sourceMaterials[j].name.Substring(11))
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

    public void CopyEyes()
    {
        //Get the materials
        SkinnedMeshRenderer sourceMesh = sourceModel.transform.Find("Face").GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetModel.transform.Find("Face").GetComponent<SkinnedMeshRenderer>();
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
                    if (targetMaterials[i].name.Substring(11) == sourceMaterials[j].name.Substring(11))
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

    public void CopyBody()
    {
        //Get the materials
        SkinnedMeshRenderer sourceMesh = sourceModel.transform.Find("Body").GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetModel.transform.Find("Body").GetComponent<SkinnedMeshRenderer>();
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
                    if (targetMaterials[i].name.Substring(11) == sourceMaterials[j].name.Substring(11))
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

    public void CopyClothes()
    {
        //Get the materials
        SkinnedMeshRenderer sourceMesh = sourceModel.transform.Find("Body").GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetModel.transform.Find("Body").GetComponent<SkinnedMeshRenderer>();
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

    public void CopyHair()
    {
        //Also do hairback swap

        //Get the materials
        //Of course, if you have multiple hair object, this needs to be modified
        SkinnedMeshRenderer sourceMesh = sourceModel.transform.Find("Hairs").Find("Hair001").GetComponent<SkinnedMeshRenderer>();
        SkinnedMeshRenderer targetMesh = targetModel.transform.Find("Hairs").Find("Hair001").GetComponent<SkinnedMeshRenderer>();

        //Copy Mesh
        targetMesh.sharedMesh = sourceMesh.sharedMesh;

        //Copy Bounds
        targetMesh.bounds = sourceMesh.bounds;

        //Copy materials
        targetMesh.materials = sourceMesh.sharedMaterials;
    }
}
