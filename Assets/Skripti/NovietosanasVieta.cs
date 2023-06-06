using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NovietosanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;
	
	// Use this for initialization
	void Start () {
        objektuSkripts.zvaigzne1.SetActive(false);
        objektuSkripts.zvaigzne2.SetActive(false);
        objektuSkripts.zvaigzne3.SetActive(false);
        objektuSkripts.restartaPoga.SetActive(false);
    } 
	
	// Update is called once per frame
	void Update () {
        if (objektuSkripts.laiks <= 80)
        {
            objektuSkripts.zvaigzne1.SetActive(true);
            objektuSkripts.zvaigzne2.SetActive(true);
            objektuSkripts.zvaigzne3.SetActive(true);
        }
        else if (objektuSkripts.laiks > 80 && objektuSkripts.laiks <= 110)
        {
            objektuSkripts.zvaigzne1.SetActive(true);
            objektuSkripts.zvaigzne2.SetActive(true);
            objektuSkripts.zvaigzne3.SetActive(false);
        }
        else if (objektuSkripts.laiks > 110)
        {
            objektuSkripts.zvaigzne1.SetActive(true);
            objektuSkripts.zvaigzne2.SetActive(false);
            objektuSkripts.zvaigzne3.SetActive(false);
        }

    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null) {
            if (eventData.pointerDrag.tag.Equals(tag)) {
                vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
                velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);
                velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                vietasIzm = GetComponent<RectTransform>().localScale;
                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);
                if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {

                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
                    switch (eventData.pointerDrag.tag) {
                        case "akritumi":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
                            objektuSkripts.punkti++;
                            break;
                        case "medicina":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            objektuSkripts.punkti++;
                            break;
                        case "buss":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            objektuSkripts.punkti++;
                            break;
                        case "e61":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
                            objektuSkripts.punkti++;
                            break;
                        case "policija":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[5]);
                            objektuSkripts.punkti++;
                            break;
                        case "e46":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[6]);
                            objektuSkripts.punkti++;
                            break;
                        case "traktors1":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[7]);
                            objektuSkripts.punkti++;
                            break;
                        case "traktors5":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[8]);
                            objektuSkripts.punkti++;
                            break;
                        case "eskavators":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[9]);
                            objektuSkripts.punkti++;
                            break;
                        case "cementa":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[10]);
                            objektuSkripts.punkti++;
                            break;
                        case "uguns":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[11]);
                            objektuSkripts.punkti++;
                            break;
                    }
                }
            } else {
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);
                switch (eventData.pointerDrag.tag)
                {
                    case "akritumi":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
                        break;
                    case "medicina":
                        objektuSkripts.atraPalidzibaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atraPKoord;
                        break;
                    case "buss":
                        objektuSkripts.autobussaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.abuusMKoord;
                        break;
                    case "e61":
                        objektuSkripts.e61Masina.GetComponent<RectTransform>().localPosition = objektuSkripts.e61MKoord;
                        break;
                    case "policija":
                        objektuSkripts.policijasMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.polMKoord;
                        break;
                    case "e46":
                        objektuSkripts.e46Masina.GetComponent<RectTransform>().localPosition = objektuSkripts.e46MKoord;
                        break;
                    case "traktors1":
                        objektuSkripts.traktors1M.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors1Koord;
                        break;
                    case "traktors5":
                        objektuSkripts.traktors5M.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors5Koord;
                        break;
                    case "eskavators":
                        objektuSkripts.Ekskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.EkskavatorsKoord;

                        break;
                    case "cementa":
                        objektuSkripts.CementaM.GetComponent<RectTransform>().localPosition = objektuSkripts.CementaKoord;
                        break;
                    case "uguns":
                        objektuSkripts.UgunsM.GetComponent<RectTransform>().localPosition = objektuSkripts.UgunsKoord;
                        break;
                }
            }
        }
        if (objektuSkripts.punkti == 11)
        {
            objektuSkripts.PabeigsanasLogs.SetActive(true);
            objektuSkripts.laiksAktivs = false;
            objektuSkripts.laikaParadisana.GetComponent<Text>().enabled = true;
            objektuSkripts.laikaParadisana.text = "Spēle pabeigta " + Mathf.Round(objektuSkripts.laiks).ToString() + " sekundes!";
            objektuSkripts.restartaPoga.SetActive(true);
        }
        }
        }
