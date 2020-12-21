using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TypingEffect : MonoBehaviour
{
    public Text LineText;

    string[] lines =
    {
        "어느 마을에 8명의 아이들이 마녀의 집과 산타의 집에 살고 있었습니다.",
        "할로윈데이에 아이들은 마녀의 집에서 사탕을 받고 크리스마스에는 모두 함께 파티하기로 다짐했죠.",
        "그러나 12월 24일 아침, 산타 아저씨가 사라졌습니다. 산타는 어디로 간 걸까요?"
    };

    private void Start()
    {
        LineText.text = lines[0];

        StartCoroutine(Line1(lines[1]));
        StartCoroutine(Line2(lines[2]));
        StartCoroutine(LoadSantaScene());
    }

    public IEnumerator Line1(string line)
    {
        yield return new WaitForSeconds(3f);
        LineText.text = line;
    }

    public IEnumerator Line2(string line)
    {
        yield return new WaitForSeconds(6f);
        LineText.text = line;
    }

    IEnumerator LoadSantaScene()
    {
        yield return new WaitForSeconds(10f);

        Map.PlayerPlace = (int)Places.SANTA_HOUSE;
        SceneManager.LoadScene("SantaHouseOutScene");
    }

    public void skipBtnClicked()
    {
        Map.PlayerPlace = (int)Places.SANTA_HOUSE;
        SceneManager.LoadScene("SantaHouseOutScene");
    }
}
