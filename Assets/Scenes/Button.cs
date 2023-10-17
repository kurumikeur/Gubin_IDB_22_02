using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject Cube;
    // Start is called before the first frame update
    public void OnClick()
    {
        if (Cube.gameObject.activeInHierarchy == false)
            Cube.gameObject.SetActive(true);
        else
            Cube.gameObject.SetActive(false);
    }
}