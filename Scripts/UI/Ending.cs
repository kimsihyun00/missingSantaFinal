using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public Text LineText;

    string[] lines =
    {
        "산타 아저씨와 이별한 후, 아이들을 위해서 새로운 산타가 등장했습니다.",
        "새로운 산타 아저씨와 아이들은 모두 함께 즐거운 크리스마스를 보냈습니다."
    };

    private void Start()
    {
        LineText.text = lines[0];
        StartCoroutine(Line1(lines[1]));
        StartCoroutine(LoadStartScene());
    }

    public IEnumerator Line1(string line)
    {
        yield return new WaitForSeconds(3f);
        LineText.text = line;
    }


    IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(10f);

        SceneManager.LoadScene("StartScene");
    }

    public void skipBtnClicked()
    {
        SceneManager.LoadScene("StartScene");
    }

}
