using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	// Start is called before the first frame update
	void Start ()
	{
		//�R���\�[����Hello, World�ƕ\��
		Debug.Log("Hello, World");
		//�ϐ��̐錾
		int score;
		//�ϐ��̑��
		score = 150;
		//�R���\�[���ɕϐ��̒��g��\��
		Debug.Log(score);
		int score2 = 150;
		Debug.Log(score2);
		// �ϐ�������������
		int a = 3;
		int b = 4;
		// �ϐ�a�ƕϐ�b�̍��v�l��ϐ�c�ɑ������
		int c = a + b;
		// �ϐ�c��\������@
		Debug.Log (c);
		// money��200�ŏ���������
		int money = 50;
		if (money <= 50)
		{
			// money�̒l��100�ȏ�̏ꍇ�A�������\������
			Debug.Log ("����𔄂�");
		}
		else if (money >= 200)
		{
			Debug.Log ("����𔃂�");
		}
		else
		{
			Debug.Log ("�|�[�V�����𔃂�");
		}
		// num��1�ŏ���������
		int num = 1;
		// val�ɑ������l�������ɂ���ĕς���(�O�����Z�q)
		int val = (num == 1) ? -100 : 100;
		// val�̒l��\������
		Debug.Log(val);
		// 5�񏈗����J��Ԃ�
		for (int i = 0; i < 5; i++)
		{
			Debug.Log (i);
		}
		// sum��0�ŏ���������
		int sum = 0;
		// 10�񏈗����J��Ԃ�
		for (int i = 1; i <= 10; i++)
		{
			// i�̒l��sum�ɑ���
			sum += i;
		}
		// sum�̒l��\������
		Debug.Log (sum);
		// �v�f��5�̔z�������������
		int[] points = new int[5];
		// �z��̊e�v�f�ɒl��������
		points [0] = 30;
		points [1] = 20;
		points [2] = 50;
		points [3] = 10;
		points [4] = 80;
		// �z��̗v�f�����ׂĕ\������
		for (int i = 0; i < 5; i++)
		{
			Debug.Log (points [i]);
		}
		// �z�������������
		int[] points2 = {30, 20, 50, 10, 80, 15, 60, 100};
		// �z��̗v�f���̂Ԃ񂾂��������J��Ԃ�
		for (int i = 0; i < points2.Length; i++)
		{
			// �z��̗v�f��50�ȏ�̏ꍇ
			if( points2[i] >= 50 )
			{
				// �z��̗v�f��\������
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
			Debug.Log ("�A�o�o");
		}
		Boss boss = new Boss();
		boss.Magic(5);
		Debug.Log ("�A�o�o");
		for (int i = 0; i <= 9; i++)
		{
			boss.Magic(5);
		}
		Debug.Log ("�A�o�o");
		boss.Magic(5);
	}
	// Update is called once per frame
	void Update ()
	{

	}
}