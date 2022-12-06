# Unity-Singleton
유니티용 싱글턴 상속만 받으면 된다!

2022-12-05 Ver.

싱글톤 클래스를 dll화하여 LazyInstance 적용

<h2>사용법</h2>
namespace : UnitySingleton <br>
사용할 MonoBehavior 클래스에 상속받고 제네릭 사용

예시
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySingleton; // 싱글턴 사용을 위한 네임스페이스 임포트.

public class GameManager : DontDestroySingleton<GameManager> // DontDestry가 싫으면 Singleton<T>
{
    public bool IsPaused { get; private set; } = false;
    public bool IsGameOver { get; private set; } = false;

    public void SetIsPaused(bool isPaused)
    {
        IsPaused = isPaused;
    }

    public void SetIsGameOver(bool isGameOver)
    {
        IsGameOver = isGameOver;
    }

    public bool IsPlaying()
    {
        return !IsPaused || !IsGameOver;
    }
    
    /// <summary>
    /// 게임패드 플레이중인지 검사
    /// </summary>
    /// <returns>게임패드가 인식되었다면 true.</returns>
    public bool IsGamePadPlaying()
    {
        var joystick = Input.GetJoystickNames();
        foreach (var value in joystick)
        {
            // 연결된 게임패드 발견
            if (value != string.Empty)
            {
                return true;
            }
        }

        return false;
    }
}


```

<br><br><hr>

참고:https://dev-nicitis.tistory.com/4

