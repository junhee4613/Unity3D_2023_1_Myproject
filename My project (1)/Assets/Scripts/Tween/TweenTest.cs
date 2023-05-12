using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;                      //Dotween을 쓰기 위해 선언

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;
    Sequence sequenceLoop;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMovex(5, 2);                       //x축으로 5만큼 2초 동안 이동
        //transform.DORotate(new Vector3(0, 0, 180), 2); //z축으로 180도 회전
        //transform.DOScale(new Vector3(2, 2, 2), 2);     //2초 동안 스케일이 2배로 커짐

        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2).OnComplete(SequenceEnd));

        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        //sequence.SetLoops(-1, LoopType.Yoyo);
        //sequenceLoop.Kill();
    }

    void SequenceEnd()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isPunch)
            {
                isPunch = true;
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);
            }
        }
        
    }
    void EndPunch()
    {
        isPunch = false;
    }
}

