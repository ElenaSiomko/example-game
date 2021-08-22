using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCube: MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    private void Awake()
    {
        cube.SetActive(false);
    }
}
