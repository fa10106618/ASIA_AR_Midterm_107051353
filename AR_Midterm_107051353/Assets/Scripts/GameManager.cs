using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("怪人")]
    public Transform slender;
    [Header("女孩")]
    public Transform girl;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"), Range(0.1f, 10f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 1.5f;

    private void Start()
    {
        print("開始事件");
    }
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        slender.Rotate(0, joystick.Horizontal * size, 0);
        girl.Rotate(0, joystick.Horizontal * size, 0);

        slender.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        girl.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
    }

}
