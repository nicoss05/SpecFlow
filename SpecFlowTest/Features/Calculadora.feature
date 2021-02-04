# language: es
Característica: Calculadora
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Calculadora simple para sumar dos números
Link to a feature: [Calculator](SpecFlowTest/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Escenario: Sumar dos números
	Dado que el primer número es 50
	Y el segundo número es 70
	Cuando los dos números son sumados
	Entonces el resultado debe ser 120

Escenario: Restar dos números
	Dado que el primer número es 35
	Y el segundo número es 15
	Cuando los dos números son restados
	Entonces el resultado debe ser 20

Escenario: Calcular la función escalonada de un número
	Dado que el primer número es 2
	Cuando se calcula la función escalonada
	Entonces el resultado debe ser 1

Esquema del escenario: Calcular la función escalonada de un número - tabla
    Dado que el primer número es <primerNumero>
	Cuando se calcula la función escalonada
	Entonces el resultado debe ser <resultado>

Ejemplos: 
| primerNumero | resultado |
| 0            | -1        |
| 0,5          | 0         |
| 1            | 0         |
| -0,5         | -1        |

