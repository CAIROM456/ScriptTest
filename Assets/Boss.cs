using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
	public int hp = 43;// �̗�
	public int mp = 53;// �l�o
	public int power = 13; // �U����
	public int guard = 23;// �h���
	public void Attack()
	{
		// �U���p�̊֐�
	}
	public void Defence(int damage)
	{
		// �h��p�̊֐�
	}
	public void Magic(int MagicPower)
	{
		if (mp >= 5)
		{
			// �c��mp�����炷
			this.mp -= MagicPower;
			Debug.Log ($"���@�U���������B�c��MP��{mp}�B");
		}
		else
		{
			Debug.Log ("MP������Ȃ����߁A���@���g���Ȃ��B");
		}
	// ���@�p�̊֐�
		Debug.Log( MagicPower+"�̃_���[�W���󂯂�" );
		// �c��hp�����炷
		this.hp -= MagicPower;
	}
}
