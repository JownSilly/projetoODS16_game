using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SwipeEffect : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector3 _InitialPosition;
    private float _distanceMoved;
    private bool _swipeLeft;
    public event Action cardMoved;
    Image Cardcolor;
    void Start()
    {
        Cardcolor = gameObject.GetComponent<Image>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = new Vector2(transform.localPosition.x + eventData.delta.x, transform.localPosition.y);
        if(transform.localPosition.x - _InitialPosition.x > 0)
        {
            transform.localEulerAngles = new Vector3(0, 0, Mathf.LerpAngle(0, -30, (_InitialPosition.x+transform.localPosition.x)/(Screen.width/2)));
        }
        else
        {
            transform.localEulerAngles = new Vector3(0, 0, Mathf.LerpAngle(0, 30, (_InitialPosition.x - transform.localPosition.x) / (Screen.width / 2)));
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        _InitialPosition = transform.localPosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        _distanceMoved = Mathf.Abs(transform.localPosition.x - _InitialPosition.x);
        if (_distanceMoved < 0.4 * Screen.width)
        {
            transform.localPosition = _InitialPosition;
            transform.localEulerAngles = Vector3.zero;
        }
        else
        {
            if (transform.localPosition.x > _InitialPosition.x)
            {
                _swipeLeft = false;
                Cardcolor.color = Color.green;
            }
            else
            {
                _swipeLeft = true;
                Cardcolor.color = Color.red;
            }
           
            cardMoved?.Invoke();
            StartCoroutine(MovedCard());
        }
        
    }
    private IEnumerator MovedCard()
    {
        float time = 0;
        while(GetComponent<Image>().color != new Color(1, 1, 1, 0))
        {
            time += Time.deltaTime;
            if (_swipeLeft)
            {
                transform.localPosition = new Vector3(Mathf.SmoothStep(transform.localPosition.x, transform.localPosition.x - Screen.width, 4*time), transform.localPosition.y, 0);
            }
            else
            {
                transform.localPosition = new Vector3(Mathf.SmoothStep(transform.localPosition.x, transform.localPosition.x + Screen.width, 4 * time), transform.localPosition.y, 0);
            }
            GetComponent<Image>().color = new Color(1, 1, 1, Mathf.SmoothStep(1, 0, 4 * time));
            yield return null;
        }
        Destroy(gameObject);
    }
   
}
