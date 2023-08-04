using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	// Start is called before the first frame update
	void Start ()
	{
		//コンソールにHello, Worldと表示
		Debug.Log("Hello, World");
		//変数の宣言
		int score;
		//変数の代入
		score = 150;
		//コンソールに変数の中身を表示
		Debug.Log(score);
		int score2 = 150;
		Debug.Log(score2);
		// 変数を初期化する
		int a = 3;
		int b = 4;
		// 変数aと変数bの合計値を変数cに代入する
		int c = a + b;
		// 変数cを表示する　
		Debug.Log (c);
		// moneyを200で初期化する
		int money = 50;
		if (money <= 50)
		{
			// moneyの値が100以上の場合、文字列を表示する
			Debug.Log ("武器を売る");
		}
		else if (money >= 200)
		{
			Debug.Log ("武器を買う");
		}
		else
		{
			Debug.Log ("ポーションを買う");
		}
		// numを1で初期化する
		int num = 1;
		// valに代入する値を条件によって変える(三項演算子)
		int val = (num == 1) ? -100 : 100;
		// valの値を表示する
		Debug.Log(val);
		// 5回処理を繰り返す
		for (int i = 0; i < 5; i++)
		{
			Debug.Log (i);
		}
		// sumを0で初期化する
		int sum = 0;
		// 10回処理を繰り返す
		for (int i = 1; i <= 10; i++)
		{
			// iの値をsumに足す
			sum += i;
		}
		// sumの値を表示する
		Debug.Log (sum);
		// 要素数5の配列を初期化する
		int[] points = new int[5];
		// 配列の各要素に値を代入する
		points [0] = 30;
		points [1] = 20;
		points [2] = 50;
		points [3] = 10;
		points [4] = 80;
		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++)
		{
			Debug.Log (points [i]);
		}
		// 配列を初期化する
		int[] points2 = {30, 20, 50, 10, 80, 15, 60, 100};
		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < points2.Length; i++)
		{
			// 配列の要素が50以上の場合
			if( points2[i] >= 50 )
			{
				// 配列の要素を表示する
				Debug.Log (points2 [i]);
			}
		}
		int[] array = new int[5];
		for (int i = 0; i <= 4; i++)
		{
			array[i] = i;
			Debug.Log (array [i]);
		}
		for (int i = 4; i >= 0; i--)
		{
			Debug.Log (array [i]);
		}
		score = 150;
		while(score == 8){
			Debug.Log ("アババ");
		}
		Boss boss = new Boss();
		boss.Magic(5);
		Debug.Log ("アババ");
		for (int i = 0; i <= 9; i++)
		{
			boss.Magic(5);
		}
		Debug.Log ("アババ");
		boss.Magic(5);
	}
	// Update is called once per frame
	void Update ()
	{

	}
}