using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;                      //Dotween�� ���� ���� ����

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;
    Sequence sequenceLoop;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMovex(5, 2);                       //x������ 5��ŭ 2�� ���� �̵�
        //transform.DORotate(new Vector3(0, 0, 180), 2); //z������ 180�� ȸ��
        //transform.DOScale(new Vector3(2, 2, 2), 2);     //2�� ���� �������� 2��� Ŀ��

        //sequenceLoop = DOTween.Sequence();
        //sequenceLoop.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        //sequenceLoop.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //sequenceLoop.Append(transform.DOScale(new Vector3(2, 2, 2), 2).OnComplete(SequenceEnd));

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
        if (Input.GetKey(KeyCode.Space))
        {
            if (!isPunch)
            {
                isPunch = true;                    //ũ��           
                transform.DOPunchScale(new Vector3(5, 5, 5), 10f, 10, 10).OnComplete(EndPunch);
            }
        }
        
    }
    void EndPunch()
    {
        isPunch = false;
    }
}

