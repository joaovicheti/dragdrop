using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class Silaba : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rextTransform;
    private CanvasGroup canvasGroup;
    private AudioSource audioSource;
    public AudioClip silaba;
    private void Awake()
    {
        rextTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    private void PlaySound()
    {
        if (audioSource)
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
            
            if (silaba)
                audioSource.PlayOneShot(silaba);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        PlaySound();
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }


    public void OnDrag(PointerEventData eventData)
    {
        rextTransform.anchoredPosition += eventData.delta;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
}