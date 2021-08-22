﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

public class CardView : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private GameObject _cardToDrag;

    public RectTransform DragArea
    {
        get;
        internal set;
    }
    public string Model
    {
        get;
        internal set;
    }
    private void DragCard()
    {
        _cardToDrag = new GameObject("DraggedCard");

        // Keep created card 
        _cardToDrag.transform.SetParent(DragArea, false);

        // Add image component to dragged card gameobject
        Image component = _cardToDrag.AddComponent<Image>();

        // Turn off raycast on card to detect underlying tile.
        component.raycastTarget = false;
        
        // Set sprite of dragged card
        component.sprite = GetComponent<Image>().sprite;

        // Pixel perfect
        component.SetNativeSize();
    }
    private void MoveCard(PointerEventData eventData)
    {
        RectTransform _cardTransform = _cardToDrag.GetComponent<RectTransform>();
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(DragArea, eventData.position + new Vector2(0f, -75f), eventData.pressEventCamera, out Vector3 vector3))
        {
            _cardTransform.position = vector3;
            _cardTransform.rotation = DragArea.rotation;
        }
    }

    internal void Played()
    {
        Destroy(_cardToDrag);
        Destroy(gameObject);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        DragCard();
        MoveCard(eventData);
        SingletonMonoBehaviour<GameLoop>.Instance.OnCardDragStart(Model);
    }

    public void OnDrag(PointerEventData eventData)
    {
        MoveCard(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(_cardToDrag);
    }
}
