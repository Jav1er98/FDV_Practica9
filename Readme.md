## Práctica 9: Técnicas.
## Objetivo: Desarrollar ejemplos que implementen los siguientes casos:

1. Scroll con movimiento del fondo.

  - Para llevar a cabo este tipo de scroll tenemos que comprobar si la posición del fondo más su ancho son menores a la posición de la cámara. Con ello recolocamos el fondo 1 hacia la posición del fondo 2 más el ancho del 1 y así sucesivamente.
  
      ![gif ejercicio 1](/gifs/Captura1.png)
      
      ![gif ejercicio 1](/gifs/Ejercicio1.gif)
     
2. Scroll con movimiento del personaje. 

 - Movemos ambos fondos, mientras la cámara esta fija.
  
      ![gif ejercicio 2](/gifs/Captura2.png)
      
      ![gif ejercicio 2](/gifs/Ejercicio2.gif)
    

3. Fondo con efecto parallax. El efecto empieza cuando el jugador empieza a moverse, esto se debe comunicar mediante eventos. 

 - Para poder llevar esto a cabo, lo primero es crear un GameObject vacío, el cual llamare como Background y le añadiré los diferentes sprites que conforman el fondo de la escena. Esta técnica se fundamente en que el fondo de nuestro juego tiene que estar dividido en varias capas, de tal forma que a cada una de ellas se le pueda indicar una velocidad de movimiento diferente.
 
  - Una vez definido el fondo de la escena, dividido en varias capas, lo siguiente es crear el script que se va a encargar de determinar el desplazamiento que debe realizar el fondo de nuestra escena para dar la sensación de movimiento, en función del movimiento que realice la cámara.
  
      ![gif ejercicio 3](/gifs/Ejercicio3.gif)
       
4. Utilizar la técnica de pool de objetos para ir creando elementos en el juego que el jugador irá recolectando.

  - Creo una "moneda" con un sprite de un circulo de color azul, luego la convierto a un prefab, se moverá a la izquierda en el momento en que se active. Creo un script que guarda una lista con las instancias de la "monedas" y un tamaño para la pool, asi como la referencia a la "moneda".
  
      ![gif ejercicio 4](/gifs/Captura3.png)
      ![gif ejercicio 4](/gifs/Captura4.png)
      
  - En el primer gifs se observan más instancias de "monedas", esto sucede cuando el zombie se aleja, en el segundo se observa el spawn de las monedas y como el zombie las recolecta.
  
       ![gif ejercicio 4](/gifs/Ejercicio4.gif)
       ![gif ejercicio 5](/gifs/Ejercicio5.gif)
