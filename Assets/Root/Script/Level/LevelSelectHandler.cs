﻿using UnityEngine;
using System.Collections;

public class LevelSelectHandler : MonoBehaviour {

    public void onMissionBack() {
        t = 0f;
        direction = 0;
        isMove = true;
    }

    public void onLevelSelected() {
        t = 0f;
        direction = 1;
        isMove = true;
    }

    bool isMove = false;
    float t = 0f;
    int direction = -1;
    Vector3 targetPosition;

    void Update() {
        if (isMove) {
            if (t < 1) {
                transform.localPosition = Vector3.Lerp(transform.localPosition, direction* targetPosition, t);
                t += Time.deltaTime;
            }
            else {
                isMove = false;
            }
        }
    }

    void Start() {
         targetPosition = new Vector3(-1024,0,0);
    }
}
