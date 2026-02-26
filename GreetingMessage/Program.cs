using System;
using F = Formal;
using C = Casual;
using static System.Console;


// README.md를 읽고 아래에 코드를 작성하세요.


F.Message message = new F.Message();
C.Message message1 = new C.Message();

WriteLine("=== 인사 테스트 ===");
WriteLine("[격식체]");
message.SayHello("홍길동");
message.SayBye("홍길동");
WriteLine();
WriteLine("[비격식체]");
message1.SayHello("철수");
message1.SayBye("철수");