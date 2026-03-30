using UnityEngine;
using UnityEngine.SceneManagement; // 씬을 넘어가기 위해 꼭 필요한 코드예요!

public class MenuManager : MonoBehaviour
{
    // 방금 만든 도움말 창을 연결할 변수예요.
    public GameObject helpPanel;

    // 1. '게임 시작' 버튼을 누르면 실행될 함수
    public void StartGame()
    {
        // "GameScene"이라는 이름의 씬으로 넘어갑니다.
        // (괄호 안의 이름은 학생이 만든 실제 게임 화면 씬 이름으로 꼭 바꿔주세요!)
        SceneManager.LoadScene("PlayScene_Door2");
    }

    // 2. '도움말' 버튼을 누르면 실행될 함수
    public void ShowHelp()
    {
        // 도움말 창을 화면에 보이게 켭니다.
        helpPanel.SetActive(true);
    }

    // 3. 도움말 창을 닫고 싶을 때 쓸 함수 (보너스!)
    public void CloseHelp()
    {
        // 도움말 창을 다시 안 보이게 끕니다.
        helpPanel.SetActive(false);
    }
}// Start is called once before the first execution of Update after the MonoBehaviour is created


    
    

