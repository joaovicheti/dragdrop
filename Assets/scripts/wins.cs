using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wins : MonoBehaviour
{
    private int pointowin;
    private int currentpoints;
    public GameObject mysword;
    void Start()
    {
        pointowin = mysword.transform.childCount;
    }

    void Update()
    {
        if (currentpoints >= pointowin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void addpoint()
    {
        currentpoints++;
    }
}
