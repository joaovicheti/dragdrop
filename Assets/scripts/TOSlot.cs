using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TOSlot : MonoBehaviour, IDropHandler
{
    public Button slot;
    public RectTransform rect;

    public void Start()
    {
        slot = GetComponent<Button>();
        rect = GetComponent<RectTransform>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            var TO = eventData.pointerDrag.GetComponent<Text>().text;

            if (TO == "TO")
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = rect.anchoredPosition;
                var colors = slot.colors;
                colors.normalColor = Color.green;
                slot.colors = colors;
            }
            else
            {
                var colors = slot.colors;
                colors.normalColor = Color.red;
                slot.colors = colors;
            }

        }
    }
}