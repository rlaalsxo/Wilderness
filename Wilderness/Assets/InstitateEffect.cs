using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InstitateEffect : MonoBehaviour
{
    public GameObject prefabEffect;
    public GameObject sword;
    public void InstantiateEffect()
    {
        Instantiate(prefabEffect, sword.transform.position, sword.transform.rotation);
    }
}
