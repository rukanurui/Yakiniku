using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに。
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gage : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 100;

    //最低HP
    int minHp = 0;

    public float currentHp;
    float happyHp;
    float healthHp;
    public float cigarettesHp;

    //public Eat eat;
    //Sliderを入れる
    public Slider slider;
    public Slider happySlider;
    public Slider healthSlider;
    public Slider cigarettesSlider;

    public static Gage instance;
    public float point;
    public float happyPoint;
    public float healthPoint;
    public float cigarettesPoint;


    public bool cigarettesFever=false;

    public static float score = 0;
    public static int pointLostTime = 0;

    private bool isPlaying=false;
  //  [SerializeField] ParticleSystem particle;
 //   [SerializeField] ParticleSystem particle_kira;

    public GameObject Particle1;
    public GameObject Particle2;

    // public string name;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public static float GetScore()
    {
        return score;
    }

    void Start()
    {
        //ポイントを50にする
        point = 50;
        happyPoint = 50;
        healthPoint = 50;
        //Sliderを満タンにする。
        slider.value = 50;
        happySlider.value = 50;
        healthSlider.value =50;
        //現在のHPを50と同じに。
        currentHp = 50;
        happyHp = 50;
        healthHp = 50;
        pointLostTime = 0;
        isPlaying = false;

        Debug.Log("Start currentHp : " + currentHp);
    }


    public void ScoreUpdate(string name,int firelevel)
    {

        //幸福などのゲージにも制限を付ける
        //tagの中に含まれる対応した名前でスコア変化
        if(name.Contains("Karubi") && firelevel == 2)//肉　ウェルダン
        {
            if (cigarettesFever == false) point += 15;
            happyPoint += 25;
            healthPoint -= 10;

            score += 50;
        }
        else if(name.Contains("Karubi") && firelevel == 3)//肉 焦げ肉
        {
            if (cigarettesFever == false) point += 5;
            happyPoint -= 10;
            healthPoint -= 20;

            score += 25;
        }
        else if(name.Contains("kyabetu") && firelevel == 2)//野菜　ウェルダン
        {
            if (cigarettesFever == false) point += 10;
            happyPoint -= 15;
            healthPoint += 20;

            score += 25;
        }
        else if (name.Contains("kyabetu") && firelevel == 3)//野菜　焦げ
        {
            if (cigarettesFever == false) point += 5;
            happyPoint -= 15;
            healthPoint += 0;

            score -= 5;
        }
        else if (name.Contains("kabocha") && firelevel == 2)//かぼちゃ　ウェルダン
        {
            if (cigarettesFever == false) point += 10;
            happyPoint -= 10;
            healthPoint += 15;

            score += 15;
        }
        else if (name.Contains("kabocha") && firelevel == 3)//かぼちゃ　焦げ
        {
            if (cigarettesFever == false) point += 5;
            happyPoint -= 20;
            healthPoint += 0;

            score -= 5;
        }
        else if (name.Contains("pi-man") && firelevel == 2)//ぴーまん　ウェルダン
        {
            if (cigarettesFever == false) point += 10;
            happyPoint -= 15;
            healthPoint += 20;

            score += 5;
        }
        else if (name.Contains("pi-man") && firelevel == 3)//ぴーまん　焦げ
        {
            if (cigarettesFever == false) point += 5;
            happyPoint -= 30;
            healthPoint += 0;

            score -= 5;
        }
        else if (name.Contains("horumon") && firelevel == 2)//ホルモン　ウェルダン
        {
            if (cigarettesFever == false) point += 15;
            happyPoint += 20;
            healthPoint -= 15;

            score += 40;
        }
        else if (name.Contains("horumon") && firelevel == 3)//ホルモン　焦げ
        {
            if (cigarettesFever == false) point += 5;
            happyPoint -= 20;
            healthPoint -= 25;

            score += 20;
        }
        else if (name.Contains("tori") && firelevel == 2)//鳥　ウェルダン
        {
            if (cigarettesFever == false) point += 15;
            happyPoint += 15;
            healthPoint -= 5;

            score += 25;
        }
        else if (name.Contains("tori") && firelevel == 3)//鳥　焦げ
        {
            if (cigarettesFever == false) point += 5;
            happyPoint -= 10;
            healthPoint -= 10;

            score += 15;
        }
        else
        {
            if (cigarettesFever == false) point += 10;
            happyPoint += 10;
            healthPoint -= 5;

            score += 3;
        }

        Eat.instance.GetFlag = false;
        
    }


    public void OnClickSquatButton()
    {
        //ボタン押したらステータスを下げる
        point -= 1.0f;
        currentHp -= 1.0f;
    }


    public void Switch()
    {
        if (isPlaying)
        {
            Particle1.SetActive(true);
            Particle2.SetActive(true);
            //   particle.Stop();
            //    particle.Stop();

        }
        else
        {
            Particle1.SetActive(false);
            Particle2.SetActive(false);
            // particle.Play();
            //  particle_kira.Play();
        }
        //isPlaying = !isPlaying;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)&& cigarettesFever == false)
        {
            cigarettesPoint += 0.5f;

            cigarettesHp += 0.5f;
        }

        // 空腹が０だとカウントダウン始まる
        if (point<=0)
        {
            pointLostTime += 1;
            //カウントダウンが終わるとゲーム終了
            if (pointLostTime > 180)
            {
                //空腹が0かつ一定時間立った時
                SceneManager.LoadScene("result");
            }
        }
        else
        {
            pointLostTime = 0;
        }

        //たばこpointが百になったらfever
        if(cigarettesPoint>=100)
        {
            cigarettesFever = true;
        }

        
        //fever中の時の処理
        if (cigarettesFever == true)
        {
            
            isPlaying = true;
            //true中は溜まったポイントを消費する
            cigarettesPoint -= 0.05f;

            //フィーバー中は健康度が減る
             healthPoint -= 0.01f;

            //pointが0になったらフラグを0にする
            if (cigarettesPoint<=0)
            {
                cigarettesFever = false;             
            }
        }
        else
        {
            isPlaying = false;
        }

        Switch();

    
        currentHp = point;

      

        point -= 0.001f;
        currentHp -= 0.001f;

        //最低値、最高値を超えたら修正
        if (point > maxHp)
        {
            point = maxHp;
        }
        else if(point<minHp)
        {
            point = minHp;
        }
        //最低値、最高値を超えたら修正
        if (happyPoint > maxHp)
        {
            happyPoint = maxHp;
        }
        else if (happyPoint < minHp)
        {
            happyPoint = minHp;
        }
        //最低値、最高値を超えたら修正
        if (healthPoint > maxHp)
        {
            healthPoint = maxHp;
        }
        else if (healthPoint < minHp)
        {
            healthPoint = minHp;
        }
        //最低値、最高値を超えたら修正
        if (cigarettesPoint > maxHp)
        {
            cigarettesPoint = maxHp;
        }
        else if (cigarettesPoint < minHp)
        {
            cigarettesPoint = minHp;
        }


        happyHp = happyPoint;
        healthHp = healthPoint;
        cigarettesHp = cigarettesPoint;


        slider.value = (float)currentHp / (float)maxHp; ;
        happySlider.value = (float)happyHp / (float)maxHp; ;
        healthSlider.value = (float)healthHp / (float)maxHp; ;
        cigarettesSlider.value = (float)cigarettesHp / (float)maxHp; ;
    }
}
