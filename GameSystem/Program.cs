using System;
using MyGame.Character;
using MyGame.Items;

//using MyGame.Character;
// README.md를 읽고 아래에 코드를 작성하세요.

Player p1 = new Player("용사");
Enemy e1 = new Enemy("고블린");
Weapon sword = new Weapon("불꽃검");
Potion potion = new Potion("체력 포션");

Console.WriteLine("=== 캐릭터 시스템 ===");
p1.Attack();
e1.TakeDamage();
Console.WriteLine();
Console.WriteLine("=== 아이템 시스템 ===");
sword.GetDamage();
potion.Use();
Console.WriteLine();