using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening

public class WindowUI : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    Vector3 MouseDragStartPos;
    RectTransform
    public PointerEventData.InputButton dragMouseButton;
    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.button == dragMouseButton)
        {
            transform.localPosition = Input.mousePosition - MouseDragStartPos;
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        MouseDragStartPos = Input.mousePosition - transform.localPosition;
        transform.SetAsLastSibling();
    }

    public void OnOpen()
    {
        .DOScale(1, 0.5f).From(0);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
