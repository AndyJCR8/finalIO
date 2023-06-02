import sys
from scipy.optimize import linprog

def resolver_simplex(coeficientes, matriz_restricciones):
    # Realizar los cálculos del método simplex utilizando SciPy
    resultado = linprog(c=-coeficientes, A_ub=matriz_restricciones[:-1, :-1], b_ub=matriz_restricciones[:-1, -1])
    return resultado

# Obtener los argumentos pasados desde C#
coeficientes = [float(arg) for arg in sys.argv[1:3]]
matriz_restricciones = [[float(arg) for arg in row.split(',')] for row in sys.argv[3:]]

# Llamar a la función para resolver el método simplex
resultado = resolver_simplex(coeficientes, matriz_restricciones)

# Imprimir los resultados
print("Resultado: ", resultado)