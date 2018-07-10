using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotaoB : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public Animator BolaAnima;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        BolaAnima.SetBool("Chute", true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
       BolaAnima.SetBool("Chute", false);

    }
}
