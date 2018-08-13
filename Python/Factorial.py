class Factorial:

    def calculateFactorial(self, n):
        initFactorialValue = 1
        for index in range(2, n+1):
            initFactorialValue *= index
        return initFactorialValue


factorial = Factorial()

print("Factorial from 5! equals ", factorial.calculateFactorial(5))
