using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//発展課題
public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	//int型の変数mpを宣言し、53で初期化
	public int mp = 53;

	//mpを消費して魔法攻撃をするMagic関数を作成
	public void Magic(){
		//Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示
		if (mp >= 5) {
			mp = mp - 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} 
		//mpが足りない場合、「MPが足りないため魔法が使えない。」と表示
		else {
			mp = mp - 5;
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//課題
		// 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
		int[] array = new int[5]{1,3,5,7,9};

		// 配列の各要素の値を順番に表示
		for (int i=0;i<5;i++){
			Debug.Log (array [i]);
		}

		// for文を使い、配列の各要素の値を逆順に表示
		for (int i=0;i<5;i++){
			Debug.Log (array [4-i]);
		}
		//発展課題
		Boss lastboss = new Boss();
		//Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認
		while (lastboss.mp > 0) {
			//Magic関数を呼び出して、魔法を使用
			lastboss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
