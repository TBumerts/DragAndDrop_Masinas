using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragAndDrop : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler{
    //Uzglabās norādi uz Objekti skriptu
    public Objekti objektuSkripts;
    //Uzglabās norādi uz katra objekta CanvasGroup
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;
    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    void Start () {
		kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf= GetComponent<RectTransform>();

	}

}
