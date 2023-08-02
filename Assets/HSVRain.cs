using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSVRain : MonoBehaviour
{
	//�F���ς��^�C�~���O(����)���uCube�v��Inspector(Duration)�Ŏw��A�����l��1.0F
	public float duration = 1.0F;
	//Hierarchy�ɂ���uCube�v���uCube 1�v�Ƀh���b�O����(�uCube�v��Inspector�ɂ���)
	public GameObject cube1;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//duration�̎��Ԃ��ƂɐF���ς��
		float phi = Time.time / duration * 2 * Mathf.PI;
		float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
		//�F��RGB�ł͂Ȃ�HSV�Ŏw��
		cube1.GetComponent<Renderer>().material.color = Color.HSVToRGB(amplitude, 1, 1);

	}
}
