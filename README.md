# 제목적는마크다운(H1)
## h2
### h3
#### h4
##### h5
###### h6

hello GitHub!


```CS
using UnityEngine;
public class sample : Monobeviour
{
  void start()
  {
    Debug.Log("Hello Unity");
  }

}

```

**프로젝트 1일차**

~~줄긋기~~

> 상위
>> 중위
>>> 하위
>>>

![Image](https://github.com/user-attachments/assets/544e17a8-b76e-40e9-a547-afa3ee394143)

+ 1
  + 2
  + 3
* 4
  * 5
    * 6
- 7 
  - 8 
      - 9


|제목|내용|설명
|:----------|----:|:----:|
|sample1|content1|des|
|sample1|content1|des|
|sample1|content1|des|


## Audio Mixer
- 오디소 소스에 대한 제어 균형 조절을 제공하는 도구
- 믹서 만드는법
  - create - audio - audiomixer

1. 유니티 레코더
   - 패키지 매니저
   - 유니티 레지스트리 -> 검색후 설치
   - 실행법
   - window - general - recorder - recoder window
   - Exit play
     - 체크시 녹화끝나면 플레이도 끝남
   - Recording Mode
   - PlackBack : 녹화중 일정 프레임 유지
   - Target FPS
   - Cap
     - 설정한
   - 우클릭
     - Movie : 게임녹화
       - source
         
2. 오디소 소스
- 씬에서 오디오 클립을 재생하는 도구
- 재생을 하기 위해서는 오디오 리스너 혹은 오디오 믹서를 이용해야 한다.
    - 믹서의 경우는 따로 만들어야 하면
    - 리스너의 경우는 메인카메라에 있다.
- Component Property
    - audio resource : 재생을 진행할 사운드 클립에 대한 등록
    - output :
        - 디폴트 : 오디오 리스너에 직접출력(None)
        - 따로만든 믹서가 있으면 그 믹서에서 출력됨
    - Mute : 체크시 음소거
    - Bypass Effects : 오디오소스에 적용되어있는 필터 효과 분리
    - Bypass Listener Effects : 리스너 효과 온오프
    - Bypass Reverb Effects : 리버브존 온오프
        - 리버브 존  :  리스너의 위치에 따라 잔향음 효과 설정
    - Play On Awake
        - 해당 옵션 체크시 씬이 실행되는 시점에 사운드 재생이 처리된다.( 배경음)
        - 공격이나 이벤트시 발생한 음악이나 효과음은  해당기능 비활성화후
        - 스크립트를 통해 제어 ( Play()메소드)
    - Loop
        - 활성화하면 재생이 한바퀴 돌때 다시 루프
    - Priority
        - 우선순위
        - 0 :최우선 128:기본 256: 최하위
    - Volume
        - 리스너 기준 소리 수치
        - 컴퓨터 내의 소리를 재생하는 여러가지 요소중 하나를 제
    - Pitch
        - 수치가 높을수록 재생속도가 빨리지며 음도 좀 올라감?  1이 일반속도
    - Stereo Pan
        - 소리 재생시 스피커 간의 소리 분포 조절 기능
        - -1 왼쪽 0 양쪽 균등 1 오른쪽 스피커
    - Stereo Blend
        - 2D : 거리에 상관없이 소리가 일정함 ( 0 )
        - 3D : 카메라 위치 따라 볼륨이 달라짐 ( 1 )
    - Reverb Zone mix
        - 리버브 존에 대한 출력 신호양을 조절합니다.
        - 1 : 오디오 소스와 리버즈 존 사이의 신호를 최대치
        - 0 : 영향을 받지 않겠다.
        - 1.1 : 10 데시벨 증폭
        - 리버브존 사용하는 경우
            - 동굴에서 소리가 울리는 소리 연출
            - 소리가 반사되서 울리는 소리
        - 3D sound Settings
            - doppler level : 거리에 따른 사운드의 높낮이
                - 0 효과 x 1: 디폴트
            - spread
                - 소리 커지는 각도
                - 0 한점 360 모든방향 균일
            - Rollof Mode : 그래프 설정
                - 로그
                - 선형
                - 커스텀



