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
        objektuSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        velkObjRectTransf.anchoredPosition += eventData.delta / objektuSkripts.kanva.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;
        if (objektuSkripts.vaiIstajaVieta == false)
            kanvasGrupa.blocksRaycasts = true;
        else
            objektuSkripts.pedejaisVilktais = null;

        objektuSkripts.vaiIstajaVieta = false;
    }

    void Start () {
		kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf= GetComponent<RectTransform>();

	}

}
