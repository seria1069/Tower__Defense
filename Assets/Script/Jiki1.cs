using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Jiki1 : MonoBehaviour
{

	private int power; //自機の攻撃力
	private float frequency; //自機の攻撃頻度
	private int level; //自機のレベル
	private int purchase_cost; //購入コスト
	private int cost; //レベルアップ時のコスト 
	private float range; // 射程
	private int EXP; //コストアップ時の累乗する数

    // Start is called before the first frame update
    void Start()
    {
        power = 2;
        //frequency
        level = 1;
        purchase_cost = 100;
        cost = 1;
        EXP = 2;

    }

    // Update is called once per frame
    void Update()
    {
        /*
        レベルアップしたら
        if (){
        	level += 1;
        	power = Math.Pow(power, level);
        	cost = Math.Pow(level, EXP);
        }
        */
        /*
        攻撃のプログラム
        GetComponent
        
        */
    }
}
