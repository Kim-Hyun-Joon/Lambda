using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : MonoBehaviour
{
    public delegate void Send(string reciever);

    Send onSend;

    void SendMail(string receiver) {
        Debug.Log("Mail sent to: " + receiver);
    }
    void SendMoney(string receiver) {
        Debug.Log("Money sent to: " + receiver);
    }
    private void Start() {
        onSend += SendMail;
        onSend += SendMoney;
        onSend += man => { Debug.Log("Assainate " + man); };

        onSend += (string man) => { Debug.Log("Assanate " + man); };
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            onSend("Joon");
        }
    }
}
