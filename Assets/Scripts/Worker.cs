using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Worker : MonoBehaviour
{
    //delegate void Work();
    //입력값이 없고, 리턴값이 void인 함수는 너무 많다
    //그래서 이러한 delegate를 사용하기 위해서
    Action work;    //Action을 사용한다
    //==delegate void Action();

    void MoveBricks() {
        Debug.Log("벽돌을 옮겼다");
    }
    void DigIn() {
        Debug.Log("땅을 팠다");
    }
    private void Start() {
        work += MoveBricks;
        work += DigIn;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            work();
        }
    }
}
