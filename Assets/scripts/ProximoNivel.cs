using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProximoNivel : MonoBehaviour
{
    public Button SA;
    public Button PO;
    public GameObject Proximo;
    void Start()
    {
        Proximo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(SA.colors.normalColor == Color.green && PO.colors.normalColor == Color.green)
        {
            Proximo.SetActive(true);
        }
    }
}
