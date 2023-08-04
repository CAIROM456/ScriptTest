using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
	public int hp = 43;// 体力
	public int mp = 53;// ＭＰ
	public int power = 13; // 攻撃力
	public int guard = 23;// 防御力
	public void Attack()
	{
		// 攻撃用の関数
	}
	public void Defence(int damage)
	{
		// 防御用の関数
	}
	public void Magic(int MagicPower)
	{
		if (mp >= 5)
		{
			// 残りmpを減らす
			this.mp -= MagicPower;
			Debug.Log ($"魔法攻撃をした。残りMPは{mp}。");
		}
		else
		{
			Debug.Log ("MPが足りないため、魔法が使えない。");
		}
	// 魔法用の関数
		Debug.Log( MagicPower+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= MagicPower;
	}
}
