using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject test1;
    private bool moving;
    private bool finish;

    private float testx;
    private float testy;

    private Vector3 resetposition;
    void Start()
    {
        resetposition = this.transform.localPosition;
    }

    void Update()
    {
        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousepos;
                mousepos = Input.mousePosition;
                mousepos = Camera.main.ScreenToWorldPoint(mousepos);

                this.gameObject.transform.localPosition = new Vector3(mousepos.x - testx, mousepos.y - testy, this.gameObject.transform.localPosition.z);
            }
        }

    }


    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousepos;
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);

            testx = mousepos.x - this.transform.localPosition.x;

            testy = mousepos.y - this.transform.localPosition.y;

            moving = true;
        }

    }
    private void OnMouseUp()
    {
        moving = false;
        if (Mathf.Abs(this.transform.localPosition.x - test1.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - test1.transform.localPosition.y) <= 0.5f)

        {
            this.transform.position = new Vector3(test1.transform.position.x, test1.transform.position.y, test1.transform.position.z);
            finish = true;
            GameObject.Find("ganhou").GetComponent<wins>().addpoint();
        }
        else
        {
            this.transform.localPosition = new Vector3(resetposition.x, resetposition.y, resetposition.z);
        }
    }
}