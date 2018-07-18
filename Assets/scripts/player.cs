using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    int key=0;
    float speed = 0.03f;

    string state;

    //コンポーネット宣言
    Animator _anim; //　プレイヤーアニメ


	// Use this for initialization
	void Start () {
        //　プレイヤーに設定されたAnimator呼び出し
        _anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		GetInputkey();
        ChangeAnim();
        Move();
	}

    /// <summary>
    /// アニメ切り替えの管理
    /// </summary>


    void ChangeAnim()
    {
        switch(state)
        {
            case "Idle":
                _anim.SetBool("isIdle" , true);
                _anim.SetBool("isRun" , false);
                break;
            case "Run":
                _anim.SetBool("isRun" , true);
                _anim.SetBool("isIdle" , false);
                break;
        }

    }


    void GetInputkey()
    { 

        key = 0;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
    }

    void Move()
    {
        transform.position += new Vector3(key*speed,0,0);   
    }
}
