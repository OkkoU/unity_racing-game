# Unity / C# - Racing Game

https://github.com/OkkoU/unity_racing-game/assets/95446418/a5804623-d2dc-4d69-ab34-fc6289d8336a



# Racing Game – Unity Dokumentation

•	Börja med att skapa ett nytt 2D-projekt i Unity.
•	I Unity-editor, skapa två nya, tomma GameObject. Döp dem till P1 och P2.
•	Från Sprites-mappen, tillägg bilder på bilar till respektive GameObject genom att dra bilden på GameObject.
•	Tillägg en Rigidbody 2D-komponent till båda objekten.
•	Ändra Rigidbody 2D-komponentens inställningar till följande:
o	Angular Drag: 0.1
o	Gravity Scale: 0
o	Interpolate: Interpolate
•	Under P1-objektet, klicka på bild-objektet. I Sprite Renderer-inställningarna:
o	Flip: kryssa i Y
o	Sorting Layer: Default
o	Order in Layer: 1
•	Tillägg en ny komponent: Polygon Collider 2D
•	Gör samma för P2.
•	Skapa ett C#-skript för att kunna styra bilarna. Döp skriptet till TopDownCarController.
•	Skapa ett till C#-skript för att hantera input från spelaren. Döp det till CarInputHandler.
•	Klicka på GameObject P1 och tillägg båda skripten som komponenter. Gör samma för P2.
•	 Skapa önskad mängd tomma GameObject som kommer att fungera som väggar på racing banan.
•	Tillägg Box Collider 2D- komponenten till alla object.
•	.......
