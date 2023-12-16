using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    int c = 0;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = c.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        --c;
        text.text = c.ToString();
    }
}
