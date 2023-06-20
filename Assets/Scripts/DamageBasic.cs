using System.Runtime.CompilerServices;
using UnityEngine;

public class DamageBasic : MonoBehaviour
{
	[Header("資料")]
	public DataBasic data;

	private float hp;

	private void Awake()
	{
		hp = data.hp;
	}
	public void damage(float damage)
	{
		hp -= damage;

		print($"<color=#ffee66>{gameObject.name}血量剩下:{hp}</color>");

		if (hp <= 0) Dead();
	}

	private void Dead()
	{
		print($"<color=#ffee66>{gameObject.name}死亡</color>");
	}
}
