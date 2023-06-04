﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NovietosanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;
	
	// Use this for initialization
	void Start () {
		
	} 
	
	// Update is called once per frame
	void Update () {
     
    }

    public void OnDrop(PointerEventData eventData)
    {
		if (eventData.pointerDrag != null) {
			if (eventData.pointerDrag.tag.Equals(tag)) { 
				vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
				velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs(velkObjZRot- vietasZRot);
				velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
				vietasIzm = GetComponent<RectTransform>().localScale;
				xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
				yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba>=354 && rotacijasStarpiba<=360))&& (xIzmeruStarp<= 0.1&&yIzmeruStarp <=0.1)){

					objektuSkripts.vaiIstajaVieta = true;
					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
					eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
					eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
					switch (eventData.pointerDrag.tag) {
						case "akritumi":
							objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
							break;
						case "medicina":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            break;
						case "buss":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
							break;
						case "e61":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
						case "policija":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
						case "e46":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
					}
				}
			}else{
				objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);
                switch (eventData.pointerDrag.tag)
                {
                    case "akritumi":
						objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
                        objektuSkripts.punkti++;
                        break;
                    case "medicina":
                        objektuSkripts.atraPalidzibaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atraPKoord;
                        objektuSkripts.punkti++;
                        break;
                    case "buss":
                        objektuSkripts.autobussaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.abuusMKoord;
                        objektuSkripts.punkti++;
                        break;
                    case "e61":
                        objektuSkripts.e61Masina.GetComponent<RectTransform>().localPosition = objektuSkripts.e61MKoord;
                        objektuSkripts.punkti++;
                        break;
                    case "policija":
                        objektuSkripts.policijasMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.polMKoord;
                        objektuSkripts.punkti++;
                        break;
                    case "e46":
                        objektuSkripts.e46Masina.GetComponent<RectTransform>().localPosition = objektuSkripts.e46MKoord;
                        objektuSkripts.punkti++;
                        break;
					case "traktors1":
                        objektuSkripts.traktors1M.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors1Koord;
                        objektuSkripts.punkti++;
                        break;
					case "traktors5":
                        objektuSkripts.traktors5M.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors5Koord;
                        objektuSkripts.punkti++;
                        break;
					case "eskavators":
                        objektuSkripts.Ekskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.EkskavatorsKoord;
                        objektuSkripts.punkti++;
                        break;
					case "cementa":
                        objektuSkripts.CementaM.GetComponent<RectTransform>().localPosition = objektuSkripts.CementaKoord;
                        objektuSkripts.punkti++;
                        break;
                }
                }
            }
		}
    }
