
1.What
==

1.1 프로젝트 이름 과 구성
--
![image](https://user-images.githubusercontent.com/49605999/62818042-feb29a00-bb7b-11e9-8ed2-2227089c97bc.png)

1.2.현 프로그램의 장점과 단점
--

장점 
 - 직원이 전체적인 데이터를 관리하고 처리하기 쉽다.
 - 중고책 구매자가 프로그램을 이용해서 온라인으로 쉽게 책을 구매 할 수 있다.
 - 직원용 과 고객용 총 2개의 프로그램으로 나뉘어 있다.

단점
 - 중고책 판매자가 중고책을 팔기 위해서 프로그램에 등록은 할 수 있지만 책을 들고 매장에 직접 방문 해야 한다는 번거로움이 있다.
 - 판매 등록시 MetaDataBook에 의존한다.
 - 구매, 판매, 등록 을 여러 개가 아니라 한 개 씩 등록 할 수 있다.

1.3 직원용 과 고객용 메인 화면
--
![image](https://user-images.githubusercontent.com/49605999/62818055-40dbdb80-bb7c-11e9-9663-558bbf41ffd8.png)
 
2.HOW
==

2.1 DB 설계
--
![image](https://user-images.githubusercontent.com/49605999/62818065-7b457880-bb7c-11e9-84ca-1c846153deb4.png)


2.2 전체 솔루션 구성
--

전체 솔루션 구성은 직원용 프로젝트 고객용 프로젝트 그리고 전체적인 클래스 라이브러리를 관리하는 Data 프로젝트 총 3개로 나누어서 관리 하였다.
이렇게 만듬으로 인해서 추후 유지보수를 쉽게 할수 있으며 어디에 무엇이 있으며 어떻게 들어갈수있는지 직관적으로 볼수 있도록 만들었다.
 
![image](https://user-images.githubusercontent.com/49605999/62818069-9d3efb00-bb7c-11e9-8b53-5d8a57ea2f91.png)
 
 
2.3 개발 환경
--
운영 체제 : Windows 7 Professional K

컴파일 버전(언어) : _MSC_VER 1916 (표준 C언어)

CPU : IntelⓇ Core™ i7-4790 CPU @ 3.60GHz

메모리 : 8GB

IDE : Microsoft Visual Studio Community 2019 버전 16.0.3

Microsoft .NET Framework 4.6


3.사용 방법
==
직원용은 관리자를  통햇허 아이디 비밀 번호를 발급 받아야 하며
고객용은 회원가입을 통해서 쉽게 가입할수 있도록 만들었다.





