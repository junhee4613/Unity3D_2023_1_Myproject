using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {     //한번만 실행
        int age;            //변수 age를 선언
        age = 30;           //변수 age에 30의 값을 입력
        Debug.Log(age);     //age에 입력된 값을 유니티 Console 창에 보여줌

        float heigh1 = 160.5f;          //heigh1에 160.5 값 선언
        float heigh2;                   //heigh2에 선

        heigh2 = heigh1;                //heigh2에 heigh1값을 입력
        Debug.Log(heigh2);              //heigh2에 입력된 값을 유니티 Console 창에 보여줌

        string name;                    //name을 선언
        name = "Sera";                  //Name에 Sera 입력
        Debug.Log(name);                //Name 입력된 값을 유니티 Console 창에 보여줌 
           

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
