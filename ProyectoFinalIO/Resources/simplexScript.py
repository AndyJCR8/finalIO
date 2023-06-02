import sys
from scipy.optimize import linprog

def resolver_simplex(coeficientes, matriz_restricciones, resultados, tipo_optimizacion):
    if tipo_optimizacion == "max":
        coefNegativos = [-coef for coef in coeficientes]
        resultado = linprog(c=coefNegativos, A_ub=matriz_restricciones, b_ub=resultados)
    elif tipo_optimizacion == "min":
        resultado = linprog(c=coeficientes, A_ub=matriz_restricciones, b_ub=resultados)
    else:
        raise ValueError("Tipo de optimización no válido")
    return resultado

#print(f"sysArgv[1].split: {sys.argv[1].split(',')}")

# Obtener los argumentos pasados desde C#
coeficientes = [int(arg) for arg in sys.argv[1].split(',')]
matriz_restricciones = [[int(arg) for arg in row.split(',')] for row in sys.argv[2:-1]]
tipo_optimizacion = sys.argv[-1]

ecuaciones = [subl[:-1] for subl in matriz_restricciones]
resultados = [subl[-1] for subl in matriz_restricciones]

#print(f"coeficientes: {coeficientes}\nMatrizRestricciones: {matriz_restricciones}\ntipo: {tipo_optimizacion}\nA_ub: {ecuaciones}\nb_ub: {resultados}\n\n")
# Llamar a la función para resolver el método simplex
resultado = resolver_simplex(coeficientes, ecuaciones, resultados, tipo_optimizacion)

# Imprimir los resultados
print("Resultado: ", abs(resultado.fun))