import math

class AreaCalc:
    # TODO: Implement calculate method
    def calculate(self, len:int, wid:int = None)-> float:
        if wid is None:
            return round(len * len * math.pi, 2)
        return len * wid
    
# Don't modify the following code
calc = AreaCalc()
print(calc.calculate(5))    
print(calc.calculate(4, 6))
