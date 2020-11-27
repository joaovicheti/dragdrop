using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProximoNivel : MonoBehaviour
{
    public Button SA;
    public Button PO;
    public GameObject Proximo;
    private AudioSource audioSource;
    public AudioClip palavraInteira;
    private bool terminouFase = false;

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        Proximo.SetActive(false);
    }

    IEnumerator tocaAtrasado()
    {
        yield return new WaitForSeconds(0.5f);

        if (palavraInteira)
            audioSource.PlayOneShot(palavraInteira);

        yield return new WaitForSeconds(palavraInteira? palavraInteira.length : 0.5f);

        
        Proximo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (terminouFase)
            return;

        if(SA.colors.normalColor == Color.green && PO.colors.normalColor == Color.green)
        {

            StartCoroutine(tocaAtrasado());

            terminouFase = true;

        }
    }
}
