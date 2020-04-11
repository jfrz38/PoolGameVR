# PoolGameVR

Suponiendo que el jugador utiliza la mano derecha para dar fuerza y la izquierda para apoyer el palo:

- El puntero del ratón simula la mano izquierda del jugador
- La mano derecha está siempre en el eje de la cámara: Se simula que está debajo de los ojos2
- Cuando se tiene el tamaño del palo se pulsa click derecho
- WASD gira la vista: Simula girar la cabeza del usuario
- Las flechas de dirección mueven la cámara: Simula el movimiento del jugador
- El teclado numérico (2468) mueve el palo: Simula el movimiento realizado para golpear la bola


Se ha añadido:

- Una mano con la posición final para coger el palo. Si estuviesen las gafas en vez del puntero se utilizaría esa posición como referencia
- Paredes y techo

Cómo "jugar":

#### Se inicia el juego y el usuario decide el tamaño que tendrá el palo:
1. El tamaño es la distancia entre el ratón y la cámara
2. Cuando se decide el tamaño se pulsa click derecho.
#### En el juego real sería:
1. El tamaño es la distancia entre la mano reconocida y el controlador sostenido en la otra mano
2. Cuando se decide el tamaño se pulsa un botón del controlador

#### Con el tamaño elegido (y antes de elegirlo también) el usuario puede moverse por la escena:
1. Con las teclas (ASDW) se gira la vista
2. Con las felchas de dirección (←↑↓→) se mueve la posición de la cámara
3. Con el teclado numérico (2468) se mueve el palo.
#### En el juego real sería:
1. Mover la cabeza
2. Mover el cuerpo (la posición del cuerpo)
3. Mover las manos
